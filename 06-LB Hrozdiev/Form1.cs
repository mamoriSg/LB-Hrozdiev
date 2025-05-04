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

            regionList = new List<Ukraine>();

            // Додати наперед визначені області
            regionList.Add(new Ukraine("Київська", 28131, 1780000, "Київ", 2884000));
            regionList.Add(new Ukraine("Львівська", 21833, 2514000, "Львів", 721301));
            regionList.Add(new Ukraine("Одеська", 33314, 2375000, "Одеса", 1017000));
            regionList.Add(new Ukraine("Харківська", 31415, 2660000, "Харків", 1440000));
            regionList.Add(new Ukraine("Дніпропетровська", 31923, 3150000, "Дніпро", 980948));
        }

        interface IRegion
        {
            string Name { get; set; }
            int Area { get; set; }
            int Population { get; set; }
            string AdminCenter { get; set; }
            int AdminPopulation { get; set; }

            string GetInfo();
        }

        // Клас Ukraine реалізує інтерфейси IRegion і IComparable
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

            // Порівняння за площею області
            public int CompareTo(Ukraine other)
            {
                return this.Area.CompareTo(other.Area);
            }
        }

        private List<Ukraine> regionList = new List<Ukraine>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Додавання нового об'єкта до колекції
            Ukraine region = new Ukraine(
                tbName.Text,
                Convert.ToInt32(tbArea.Text),
                Convert.ToInt32(tbPopulation.Text),
                tbAdminName.Text,
                Convert.ToInt32(tbAdminPop.Text)
            );

            regionList.Add(region);
            MessageBox.Show("Область додано до колекції!");
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            try
            {
                Ukraine region = new Ukraine(
                    tbName.Text,
                    Convert.ToInt32(tbArea.Text),
                    Convert.ToInt32(tbPopulation.Text),
                    tbAdminName.Text,
                    Convert.ToInt32(tbAdminPop.Text)
                );

                MessageBox.Show(region.GetInfo(), "Інформація про введену область", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при зчитуванні даних: " + ex.Message);
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnShowPredefined_Click_Click(object sender, EventArgs e)
        {
            if (regionList.Count == 0)
            {
                MessageBox.Show("Наперед заданих областей немає!");
                return;
            }

            // Вивести тільки ті, що були додані в Form1
            string predefinedOutput = "Наперед створені області:\n";

            // Тільки перші 5 (бо ми їх додали у Form1)
            for (int i = 0; i < 5 && i < regionList.Count; i++)
            {
                predefinedOutput += regionList[i].GetInfo() + "\n\n";
            }

            MessageBox.Show(predefinedOutput, "Наперед створені області");
        }
    }
}

