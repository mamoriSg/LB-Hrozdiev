using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _06_LB_Hrozdiev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Інтерфейс, який описує основні властивості області
        interface IRegion
        {
            string Name { get; set; }
            int Area { get; set; }
            int Population { get; set; }
            string AdminCenter { get; set; }
            int AdminPopulation { get; set; }

            string GetInfo();
        }

        // Клас Ukraine реалізує інтерфейси IRegion і IComparable<Ukraine>
        class Ukraine : IRegion, IComparable<Ukraine>
        {
            public string Name { get; set; }
            public int Area { get; set; }
            public int Population { get; set; }
            public string AdminCenter { get; set; }
            public int AdminPopulation { get; set; }

            // Конструктор класу
            public Ukraine(string name, int area, int population, string adminCenter, int adminPopulation)
            {
                Name = name;
                Area = area;
                Population = population;
                AdminCenter = adminCenter;
                AdminPopulation = adminPopulation;
            }

            // Метод повертає інформацію про область
            public string GetInfo()
            {
                return $"Область: {Name}\n" +
                       $"Площа: {Area} км²\n" +
                       $"Населення: {Population} осіб\n" +
                       $"Адмін. центр: {AdminCenter}\n" +
                       $"Нас. центру: {AdminPopulation} осіб";
            }

            // Реалізація CompareTo для сортування за площею
            public int CompareTo(Ukraine other)
            {
                return this.Area.CompareTo(other.Area);
            }
        }

        // Змінні для збереження одного об'єкта та списку об'єктів
        private Ukraine myRegion;
        private List<Ukraine> regionList = new List<Ukraine>();

        // Кнопка "Зберегти" — створення одного об'єкта та додавання його до списку
        private void btnSave_Click(object sender, EventArgs e)
        {
            myRegion = new Ukraine(
                tbName.Text,
                Convert.ToInt32(tbArea.Text),
                Convert.ToInt32(tbPopulation.Text),
                tbAdminName.Text,
                Convert.ToInt32(tbAdminPop.Text)
            );

            regionList.Add(myRegion); // Додаємо в колекцію
            MessageBox.Show("Дані збережено!");
        }

        // Кнопка "Показати" — вивід усіх об'єктів у колекції через цикл for
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            string result = "=== Вивід через for ===\n";
            for (int i = 0; i < regionList.Count; i++)
            {
                result += regionList[i].GetInfo() + "\n\n";
            }

            result += "=== Вивід через foreach ===\n";
            foreach (var region in regionList)
            {
                result += region.GetInfo() + "\n\n";
            }

            MessageBox.Show(result, "Інформація про області", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Кнопка "Додати елементи вручну" — додає ще 5+ елементів за допомогою Add та Insert
        private void btnAddSample_Click_1(object sender, EventArgs e)
        {
            regionList.Add(new Ukraine("Київська", 28900, 1780000, "Київ", 2900000));
            regionList.Add(new Ukraine("Дніпропетровська", 31900, 1300000, "Дніпро", 980000));
            regionList.Insert(2, new Ukraine("Запорізька", 27100, 1050000, "Запоріжжя", 750000));
            MessageBox.Show("Елементи додано до списку!");
        }

        // Кнопка "Сортувати" — сортує список за площею
        private void btnSort_Click_1(object sender, EventArgs e)
        {
            regionList.Sort(); // використовує CompareTo
            MessageBox.Show("Список відсортовано за площею!");
        }
    }
}

