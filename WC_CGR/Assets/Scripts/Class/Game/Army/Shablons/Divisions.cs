using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Army.Shablons
{
    [Serializable]
    public class Divisions
    {
        public int Id;
        public string Name;
        public List<Rotes> rotes = new List<Rotes>();
        public List<Parametr> parametrs = new List<Parametr>();

        public Dictionary<string, float> CalculateAverageParametrValues()
        {
            var parametrValues = new Dictionary<string, List<float>>();
            var sumParametrs = new Dictionary<string, float>(); // Зберігатиме суму значень для кожного параметра

            // Пройдемось по всіх підрозділах у роті
            foreach (var rota in rotes)
            {
                // Пройдемось по всіх параметрах у підрозділі
                foreach (var pidrozdil in rota.batalions)
                {
                    foreach (var parametr in pidrozdil.parametrs)
                    {
                        // Якщо для даного параметра ще не створено список, створимо його
                        if (!parametrValues.ContainsKey(parametr.Name))
                        {
                            parametrValues[parametr.Name] = new List<float>();
                        }

                        // Додамо значення параметра до списку
                        parametrValues[parametr.Name].Add(parametr.Value);

                        // Якщо параметр має назву "кількість військових", додамо його значення до суми
                        if (parametr.Name == "Кількість військових")
                        {
                            if (!sumParametrs.ContainsKey(parametr.Name))
                            {
                                sumParametrs[parametr.Name] = 0;
                            }
                            sumParametrs[parametr.Name] += parametr.Value;
                        }
                    }
                }
            }

            // Обчислимо середнє значення для кожного параметра, крім "кількості військових"
            var averageParametrValues = new Dictionary<string, float>();
            foreach (var kvp in parametrValues)
            {
                if (kvp.Key != "Кількість військових")
                {
                    float averageValue = kvp.Value.Average();
                    averageParametrValues[kvp.Key] = averageValue;
                }
            }

            // Додаємо суму параметра "кількість військових" до результатів
            foreach (var kvp in sumParametrs)
            {
                averageParametrValues[kvp.Key] = kvp.Value;
            }

            return averageParametrValues;
        }

        public Dictionary<string, double> CalculateSumWeaponQuantities()
        {
            var weaponQuantities = new Dictionary<string, List<int>>();

            // Пройдемось по всіх підрозділах у роті
            foreach (var rota in rotes)
            {
                // Пройдемось по всіх зброях у підрозділі
                foreach (var pidrozdil in rota.batalions)
                {
                    foreach (var weapon in pidrozdil.weapons)
                    {
                        // Якщо для даної зброї ще не створено список, створимо його
                        if (!weaponQuantities.ContainsKey(weapon.weapon))
                        {
                            weaponQuantities[weapon.weapon] = new List<int>();
                        }

                        // Додамо кількість зброї до списку
                        weaponQuantities[weapon.weapon].Add(weapon.Kilkisty);
                    }
                }
            }

            // Обчислимо середню кількість для кожної зброї
            var sumWeaponQuantities = new Dictionary<string, double>();
            foreach (var kvp in weaponQuantities)
            {
                double sumQuantity = kvp.Value.Sum();
                sumWeaponQuantities[kvp.Key] = sumQuantity;
            }

            return sumWeaponQuantities;
        }
    }
}
