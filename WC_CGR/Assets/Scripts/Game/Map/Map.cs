using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game.Economic.Builds;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts.Game.Map
{
    public class Map : MonoBehaviour
    {
        #region Cells parametrs
        public GameObject prefabTemplate;
        public GameObject prefabTemplateCapital;
        public GameObject map;
        List<int> pos = new List<int>();
        List<int> posY = new List<int>();
        int h = 10, w = 30;
        int kilkPl = 0;
        int kilkPlPlaced = 0;
        bool isMapGen = false;
        Random random = new Random();
        [SerializeField] List<GameObject> cells = new List<GameObject>();
        [SerializeField] List<Cell> cellsCap = new List<Cell>();
        #endregion

        #region Players
        Load load = new Load();
        Save save = new Save();
        Players players = new Players();
        #endregion

        public Camera mainCamera = new Camera();
        public float panSpeed = 20f;
        public float panBorderThickness = 10f;

        // Use this for initialization
        void Start()
        {
            kilkPl = PlayerPrefs.GetInt("kilk");
            kilkPlPlaced = kilkPl;

            #region Generate map
            for (int i = 0; i < kilkPl; i++)
            {
                pos.Add(random.Next(0, w));
                posY.Add(random.Next(0, h));
            }
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if ((pos.Contains(j) && posY.Contains(i)) && kilkPlPlaced > 0)
                    {
                        GameObject capital = Instantiate(prefabTemplateCapital, new Vector3(map.transform.position.x + (3 * j), map.transform.position.y, map.transform.position.z), Quaternion.identity);
                        cells.Add(capital);
                        cellsCap.Add(capital.GetComponent<Cell>());
                        kilkPlPlaced--;
                    }
                    else
                    {
                        GameObject cell = Instantiate(prefabTemplate, new Vector3(map.transform.position.x + (3 * j), map.transform.position.y, map.transform.position.z), Quaternion.identity);
                        cells.Add(cell);
                    }
                }
                map.transform.position = new Vector3(map.transform.position.x, map.transform.position.y + 3, map.transform.position.z);
            }
            isMapGen = true;
            #endregion

        }

        void CapToPl()
        {
            players = load.LoadPlayersInfo();

            cellsCap[0].currentRegion.builds = new List<Build>()
                        {
                            new Build()
                            {
                                Id = 0,
                                Name = "Цивільні фабрики",
                                Cost = 1000
                            },
                            new Build()
                            {
                                Id = 1,
                                Name = "Інфаструктура",
                                Cost = 100
                            }
                        };
            cellsCap[0].currentRegion.armyBuilds = new List<ArmyBuild>()
                        {
                            new ArmyBuild()
                            {
                                Id = 0,
                                Name = "Військові заводи",
                                Cost = 1200
                            }
                        };
            cellsCap[0].currentRegion.defendBuilds = new List<DefendBuild>()
                        {
                            new DefendBuild()
                            {
                                Id = 0,
                                Name = "Укріплення",
                                Cost = 500,
                                Attack = 5,
                                Defend = 5
                            },
                            new DefendBuild()
                            {
                                Id = 1,
                                Name = "ППО",
                                Cost = 500,
                                Attack = 5,
                                Defend = 5
                            }
                        };
            cellsCap[0].currentRegion.parametrs[1].Value = cellsCap[0].currentRegion.builds.Count + cellsCap[0].currentRegion.armyBuilds.Count + cellsCap[0].currentRegion.defendBuilds.Count;
            players.Player.capital = cellsCap[0].currentRegion;
            players.Player.regions.Add(cellsCap[0].currentRegion);
            mainCamera.transform.position = new Vector3(cellsCap[0].currentRegion.prefab.transform.position.x, cellsCap[0].currentRegion.prefab.transform.position.y, mainCamera.transform.position.z);
            for (int i = 0; i < kilkPl - 1; i++)
            {
                cellsCap[i + 1].currentRegion.builds = new List<Build>()
                        {
                            new Build()
                            {
                                Id = 0,
                                Name = "Цивільні фабрики",
                                Cost = 1000
                            },
                            new Build()
                            {
                                Id = 1,
                                Name = "Інфаструктура",
                                Cost = 100
                            }
                        };
                cellsCap[i + 1].currentRegion.armyBuilds = new List<ArmyBuild>()
                        {
                            new ArmyBuild()
                            {
                                Id = 0,
                                Name = "Військові заводи",
                                Cost = 1200
                            }
                        };
                cellsCap[i + 1].currentRegion.defendBuilds = new List<DefendBuild>()
                        {
                            new DefendBuild()
                            {
                                Id = 0,
                                Name = "Укріплення",
                                Cost = 500,
                                Attack = 5,
                                Defend = 5
                            },
                            new DefendBuild()
                            {
                                Id = 1,
                                Name = "ППО",
                                Cost = 500,
                                Attack = 5,
                                Defend = 5
                            }
                        };
                cellsCap[i + 1].currentRegion.parametrs[1].Value = cellsCap[i + 1].currentRegion.builds.Count + cellsCap[i + 1].currentRegion.armyBuilds.Count + cellsCap[i + 1].currentRegion.defendBuilds.Count;
                players.bots[i].capital = cellsCap[i + 1].currentRegion;
                players.bots[i].regions.Add(cellsCap[i + 1].currentRegion);
            }
            save.SavePlayers(players);
            PlayerPrefs.SetInt("isFinAddCap", 0);
        }

        // Update is called once per frame
        void Update()
        {
            if (isMapGen)
            {
                CapToPl();
                isMapGen = false;
            }

            // Отримати вектор руху з клавіш
            Vector3 moveDirection = GetInput();

            // Застосувати переміщення до позиції камери
            mainCamera.transform.Translate(moveDirection * panSpeed * Time.deltaTime, Space.World);
        }

        Vector3 GetInput()
        {
            // Отримати горизонтальну та вертикальну компоненти руху
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            // Переміщення здійснюється за допомогою клавіш WASD або стрілок, або за межами екрану
            Vector3 moveDirection = new Vector3(horizontal, 0, vertical);

            // Переміщення камери за межами екрану
            if (Input.mousePosition.x >= Screen.width - panBorderThickness)
                moveDirection.x = 1f;
            if (Input.mousePosition.x <= panBorderThickness)
                moveDirection.x = -1f;
            if (Input.mousePosition.y >= Screen.height - panBorderThickness)
                moveDirection.y = 1f;
            if (Input.mousePosition.y <= panBorderThickness)
                moveDirection.y = -1f;

            return moveDirection.normalized;
        }
    }
}