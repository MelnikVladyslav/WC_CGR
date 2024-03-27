using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class Cell : MonoBehaviour
{
    public Region currentRegion;
    GameObject currentPrefab;
    Random random = new Random();

    private static string[] prefixes = { "ϳ���", "ϳ�����", "����", "�����", "�����������", "�����", "������", "�������", "�������" };
    private static string[] suffixes = { "����", "����", "������", "����", "��", "��", "������", "���", "�����", "������" };
    private static string[] cities =  {
    "���", "����", "�����", "�����", "�����", "�������", "��������", "��������", "��������", "�����-���������",
    "������", "������������", "������", "�������", "�������", "����", "�������", "³�����", "�������", "г���",
    "�������������", "�������", "������ г�", "��������", "�����������", "�������", "�����", "�����������", "���'�����-����������", "�����",
    "���� ������", "���������", "�����������", "���������", "�������", "�������", "�������", "����", "����'�����", "�������",
    "��������", "�������������", "�������", "ͳ������", "������", "�����������", "���'����-������", "��������", "�����������", "��������",
    "��������-����������", "��������", "���'�����", "����������", "������", "�������", "���", "�����", "����������", "�������",
    "�����", "���������", "��������", "����", "�����", "�����������", "���������", "��������", "������", "��곿���",
    "������������", "�������", "������", "���� �������", "�����������", "���������-������������", "�������", "�����", "�����", "������",
    "���� ����", "��������", "������������", "����", "����������", "�������", "�������", "�������", "���������", "��������", "������", "�����", "�����", "������", "���", "���������", "�������", "���������", "����", "�����",
    "��������", "³����", "˳�����", "�����", "�����", "��������", "���������", "������", "����������", "������",
    "�������", "����", "����", "�������", "��������", "�������", "������", "������", "����", "̳���",
    "�������", "������", "�����", "���������", "��������", "��������", "�����������", "��������", "�������", "�������",
    "���������", "����", "����������", "����", "������", "˳���", "ͳ���", "������", "�������", "�����",
    "�����", "˳������", "�����", "������", "�����", "�����", "�������", "�������", "�������", "�������",
    "��������", "����-������", "ҳ������", "���", "���������", "��� ���", "�������", "ͳ�", "����'�", "�����",
    "�����", "�������", "�����", "����", "������ �������", "������", "������", "�����", "������", "�������",
    "���������", "ͳ���", "�����", "�������", "������", "ͳ�", "���������", "�쳺�", "˳���", "����",
    "���", "�����", "����", "����", "��������", "�������", "�������", "������", "�����", "������",
    "�������", "�����", "��������", "�������", "�����", "�������", "��������-����", "�������", "������", "�����",
    "����", "�������", "�������", "������ ����", "����-���-�����", "˳������", "������� �������", "��������", "������", "������",
    "³�����", "��������", "���������", "������", "������", "��������", "�������", "������", "���������", "˳����",
    "������", "�����", "�����", "�����", "³�����", "������", "��������", "������", "������", "�����",
    "�����", "�����", "����", "���������", "˳����", "��������", "�������", "������", "�����-���������", "������"
};

    public Renderer rend;
    Color originalColor;

    Load load = new Load();
    Players pl;

    public GameObject bottomPanel;
    public GameObject name;
    public GameObject nameCity;
    public GameObject parametrs;
    public GameObject controls;

    private void Start()
    {
        currentRegion = new Region()
        {
            Id = random.Next(1000, 9999),
            Name = GenerateProvinceName(),
            nameCity = GenerateCityName(),
            parametrs = new List<Parametr>()
            {
                new Parametr()
                {
                    Id = 0,
                    Name = "���������",
                    Value = random.Next(100, 100000)
                },
                new Parametr()
                {
                    Id = 1,
                    Name = "ʳ������ ������",
                    Value = 0
                }
            },
            prefab = this.gameObject
        };

        rend = GetComponent<Renderer>();

        originalColor = rend.material.color;

        bottomPanel = GameObject.Find("Canvas/Game/bottomPanel");
        name = GameObject.Find("Canvas/Game/bottomPanel/Name");
        nameCity = GameObject.Find("Canvas/Game/bottomPanel/nameCity");
        parametrs = GameObject.Find("Canvas/Game/bottomPanel/parametrs");
        controls = GameObject.Find("Canvas/Game/bottomPanel/control");
    }

    private void Update()
    {
        
    }

    public static string GenerateProvinceName()
    {
        Random random = new Random();

        string prefix = prefixes[random.Next(prefixes.Length)];
        string suffix = suffixes[random.Next(suffixes.Length)];

        return $"{prefix} {suffix}";
    }

    public static string GenerateCityName()
    {
        Random random = new Random();

        string prefix = cities[random.Next(cities.Length)];

        return $"{prefix}";
    }

    private void OnMouseEnter()
    {
        rend.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        rend.material.color = originalColor;
    }

    private void OnMouseDown()
    {
        bottomPanel.SetActive(true);
        pl = load.LoadPlayersInfo();
        for (int i = 0; i < pl.Player.regions.Count; i++)
        {
            if (pl.Player.regions[i].Id == currentRegion.Id)
            {
                currentRegion = pl.Player.regions[i];
            }
        }
        name.GetComponent<Text>().text = currentRegion.Name;
        nameCity.GetComponent<Text>().text = currentRegion.nameCity;
        parametrs.GetComponent<Text>().text = " ";
        for (int i = 0; i < currentRegion.parametrs.Count; i++)
        {
            parametrs.GetComponent<Text>().text += currentRegion.parametrs[i].Name + ": " + currentRegion.parametrs[i].Value + "\n";
        }
        //�������� �� ��� ����� ������
        bool isRegPl = false;
        for (int i = 0; i < pl.Player.regions.Count; i++)
        {
            if (pl.Player.regions[i].Id == currentRegion.Id)
            {
                controls.GetComponent<Text>().text = pl.Player.Name;
                isRegPl = true;
                break;  // ����� � �����, ������� � ��� ��� �������� ����� ������.
            }
            if (pl.Player.regions[i].Id != currentRegion.Id)
            {
                controls.GetComponent<Text>().text = "��� ��������";
            }
        }
        //�������� �� ��� ����� �������� ����
        for (int i = 0; i < pl.bots.Count; i++)
        {
            for (int j = 0; j < pl.bots[i].regions.Count; j++)
            {
                if (pl.bots[i].regions[j].Id == currentRegion.Id)
                {
                    controls.GetComponent<Text>().text = pl.bots[i].Name;
                    break;  // ����� � �����, ������� � ��� ��� �������� ����� ����.
                }
                if (pl.bots[i].regions[j].Id != currentRegion.Id && !isRegPl)
                {
                    controls.GetComponent<Text>().text = "��� ��������";
                }
            }
        }
    }
}
