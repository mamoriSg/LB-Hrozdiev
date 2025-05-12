using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_LB_Hrozdiev
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Інтерфейс регіону
        interface IRegion
        {
            string Name { get; set; }
            int Area { get; set; }
            int Population { get; set; }
            string AdminCenter { get; set; }
            int AdminPopulation { get; set; }

            string GetInfo();
        }

        // Клас Ukraine
        class Ukraine : IRegion, IComparable<Ukraine>
        {
            public string Name { get; set; }
            public int Area { get; set; }
            public int Population { get; set; }
            public string AdminCenter { get; set; }
            public int AdminPopulation { get; set; }

            public Ukraine(string name, int area, int population, string adminCenter, int adminPopulation)
            {
                Name = name;
                Area = area;
                Population = population;
                AdminCenter = adminCenter;
                AdminPopulation = adminPopulation;
            }

            public string GetInfo()
            {
                return $"Область: {Name}\n" +
                       $"Площа: {Area} км²\n" +
                       $"Населення: {Population} осіб\n" +
                       $"Адміністративний центр: {AdminCenter}\n" +
                       $"Населення центру: {AdminPopulation} осіб";
            }

            // Порівняння по площі
            public int CompareTo(Ukraine other)
            {
                return this.Area.CompareTo(other.Area);
            }
        }

        private Ukraine myRegion; // Об'єкт із форми
        private List<Ukraine> regions = new List<Ukraine>(); // Колекція областей

        private void btnSave_Click(object sender, EventArgs e)
        {
            myRegion = new Ukraine(
                tbName.Text,
                Convert.ToInt32(tbArea.Text),
                Convert.ToInt32(tbPopulation.Text),
                tbAdminName.Text,
                Convert.ToInt32(tbAdminPop.Text)
            );

            MessageBox.Show("Дані збережено!");
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            regions.Clear(); // очищаємо список перед додаванням (щоб не дублювалось)
            
            // Додаємо область із форми
            if (myRegion != null)
            {
                regions.Add(myRegion);
            }

            // Додаємо інші області
            regions.Add(new Ukraine("Київська", 28131, 1780000, "Київ", 2950000));
            regions.Add(new Ukraine("Львівська", 21833, 2500000, "Львів", 720000));
            regions.Add(new Ukraine("Одеська", 33310, 2370000, "Одеса", 1000000));
            regions.Add(new Ukraine("Харківська", 31415, 2650000, "Харків", 1440000));
            regions.Insert(2, new Ukraine("Дніпропетровська", 31914, 3200000, "Дніпро", 1000000));
            regions.Insert(0, new Ukraine("Запорізька", 27183, 1600000, "Запоріжжя", 730000));

            // Вивід через цикл for
            string output = "=== Вивід через for ===\n\n";
            for (int i = 0; i < regions.Count; i++)
            {
                output += regions[i].GetInfo() + "\n\n";
            }

            // Вивід через foreach
            //string output = "=== Вивід через foreach ===\n\n";
            //foreach (var region in regions)
            //{
            //    output += region.GetInfo() + "\n\n";
            //}

            // Сортування по площі
            //regions.Sort();

            //string output = "=== Після сортування по площі ===\n\n";
            //foreach (var region in regions)
            //{
            //    output += region.GetInfo() + "\n\n";
            //}

            //Вивід у повідомленні
            MessageBox.Show(output, "Колекція регіонів", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
