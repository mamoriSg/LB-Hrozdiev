using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_LB_Hrozdiev
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Оголошення інтерфейсу IRegion, який описує властивості та метод для класу-реалізації
        interface IRegion
        {
            string Name { get; set; }
            int Area { get; set; }
            int Population { get; set; }
            string AdminCenter { get; set; }
            int AdminPopulation { get; set; }

            string GetInfo();
        }

        // Клас Ukraine реалізує інтерфейс IRegion
        class Ukraine : IRegion
        {
            public string Name { get; set; }
            public int Area { get; set; }
            public int Population { get; set; }
            public string AdminCenter { get; set; }
            public int AdminPopulation { get; set; }

            // Конструктор класу — ініціалізує об'єкт значеннями з параметрів
            public Ukraine(string name, int area, int population, string adminCenter, int adminPopulation)
            {
                Name = name;
                Area = area;
                Population = population;
                AdminCenter = adminCenter;
                AdminPopulation = adminPopulation;
            }

            // Метод повертає інформацію про об'єкт у вигляді форматованого рядка
            public string GetInfo()
            {
                return $"Область: {Name}\n" +
                       $"Площа: {Area} км²\n" +
                       $"Населення: {Population} осіб\n" +
                       $"Адміністративний центр: {AdminCenter}\n" +
                       $"Населення центру: {AdminPopulation} осіб";
            }
        }

        private Ukraine myRegion; // Змінна для збереження створеного об'єкта класу Ukraine

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
            if (myRegion != null)
                MessageBox.Show(myRegion.GetInfo(), "Інформація про область", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Область не створено!");
        }
    }
}

    
