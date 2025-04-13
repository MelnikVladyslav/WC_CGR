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

    private static string[] prefixes = { "Північ", "Південь", "Схід", "Захід", "Центральний", "Новий", "Старий", "Високий", "Низький" };
    private static string[] suffixes = { "град", "місто", "селище", "поле", "діл", "ліс", "затока", "ріка", "озеро", "долина" };
    private static string[] cities =  {
    "Київ", "Львів", "Харків", "Одеса", "Дніпро", "Донецьк", "Запоріжжя", "Луганськ", "Тернопіль", "Івано-Франківськ",
    "Херсон", "Хмельницький", "Чернігів", "Полтава", "Черкаси", "Суми", "Житомир", "Вінниця", "Миколаїв", "Рівне",
    "Кропивницький", "Чернівці", "Кривий Ріг", "Маріуполь", "Севастополь", "Ужгород", "Луцьк", "Симферополь", "Кам'янець-Подільський", "Ізмаїл",
    "Біла Церква", "Бердянськ", "Краматорськ", "Мелітополь", "Бровари", "Хмільник", "Прилуки", "Ізюм", "Слов'янськ", "Охтирка",
    "Бердичів", "Красноармійськ", "Коломия", "Нікополь", "Шостка", "Вознесенськ", "Кам'янка-Бузька", "Дружківка", "Світловодськ", "Бориспіль",
    "Новоград-Волинський", "Мукачево", "Куп'янськ", "Лисичанськ", "Лозова", "Славута", "Рені", "Ірпінь", "Лисичанськ", "Бровари",
    "Умань", "Скадовськ", "Жмеринка", "Буча", "Щастя", "Первомайськ", "Павлоград", "Васильків", "Боярка", "Макіївка",
    "Нововолинськ", "Ватутіне", "Сквира", "Нова Каховка", "Світлодарськ", "Переяслав-Хмельницький", "Миколаїв", "Дубно", "Самбір", "Іршава",
    "Жовті Води", "Славутич", "Комсомольськ", "Суми", "Дзержинськ", "Березне", "Ворзель", "Лебедин", "Теребовля", "Берегове", "Лондон", "Париж", "Берлін", "Мадрид", "Рим", "Амстердам", "Варшава", "Стокгольм", "Осло", "Афіни",
    "Брюссель", "Відень", "Лісабон", "Дублін", "Прага", "Будапешт", "Барселона", "Мюнхен", "Копенгаген", "Женева",
    "Хельсінкі", "Осло", "Берн", "Варшава", "Бухарест", "Белград", "Загреб", "Сараєво", "Брно", "Мілан",
    "Гамбург", "Мюнхен", "Кельн", "Франкфурт", "Дортмунд", "Штутгарт", "Дюссельдорф", "Ганновер", "Лейпциг", "Дрезден",
    "Антверпен", "Гент", "Люксембург", "Зюріх", "Базель", "Лілль", "Ніцца", "Тулуза", "Марсель", "Бордо",
    "Порто", "Ліссабон", "Брага", "Фуншал", "Краків", "Лодзь", "Вроцлав", "Катовіце", "Гданськ", "Познань",
    "Букарест", "Клуж-Напока", "Тімішоара", "Іасі", "Констанца", "Нові Сад", "Белград", "Ніш", "Скоп'є", "Охрид",
    "Софія", "Пловдив", "Варна", "Русе", "Велико Тарново", "Тирана", "Дуррес", "Влора", "Шкодра", "Саранда",
    "Подгорица", "Ніцца", "Канни", "Марсель", "Тулуза", "Нім", "Страсбург", "Амієн", "Лілль", "Метц",
    "Тур", "Бордо", "Нант", "Ренн", "Старгард", "Познань", "Гданськ", "Бідгощ", "Сопот", "Торунь",
    "Вроцлав", "Краків", "Закопане", "Познань", "Люблін", "Варшава", "Бельсько-Бяла", "Ольштин", "Торунь", "Сопот",
    "Брно", "Острава", "Пльзень", "Карлові Вари", "Усти-над-Лабем", "Ліберець", "Храдець Кралове", "Пардубіце", "Йонава", "Каунас",
    "Вільнюс", "Клайпеда", "Паневежис", "Шяуляй", "Шяуляй", "Вентспілс", "Резекне", "Єлгава", "Даугавпілс", "Лієпая",
    "Таллінн", "Тарту", "Пярну", "Нарва", "Вільнюс", "Каунас", "Клайпеда", "Шяуляй", "Таллінн", "Тарту",
    "Нарва", "Пярну", "Рига", "Даугавпілс", "Лієпая", "Вентспілс", "Резекне", "Єлгава", "Санкт-Петербург", "Москва"
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
                    Name = "Населення",
                    Value = random.Next(100, 100000)
                },
                new Parametr()
                {
                    Id = 1,
                    Name = "Кількість фабрик",
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
        //Перевірка чи цей регіон гравця
        bool isRegPl = false;
        for (int i = 0; i < pl.Player.regions.Count; i++)
        {
            if (pl.Player.regions[i].Id == currentRegion.Id)
            {
                controls.GetComponent<Text>().text = pl.Player.Name;
                isRegPl = true;
                break;  // Вихід з циклу, оскільки у нас вже знайдено регіон гравця.
            }
            if (pl.Player.regions[i].Id != currentRegion.Id)
            {
                controls.GetComponent<Text>().text = "Без контролю";
            }
        }
        //Перевірка чи цей регіон належить боту
        for (int i = 0; i < pl.bots.Count; i++)
        {
            for (int j = 0; j < pl.bots[i].regions.Count; j++)
            {
                if (pl.bots[i].regions[j].Id == currentRegion.Id)
                {
                    controls.GetComponent<Text>().text = pl.bots[i].Name;
                    break;  // Вихід з циклу, оскільки у нас вже знайдено регіон бота.
                }
                if (pl.bots[i].regions[j].Id != currentRegion.Id && !isRegPl)
                {
                    controls.GetComponent<Text>().text = "Без контролю";
                }
            }
        }
    }
}
