using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_LB_Hrozdiev
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Київська");
            comboBox1.Items.Add("Львівська");
            comboBox1.Items.Add("Одеська");
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

        // Клас реалізує інтерфейси IRegion і IComparable, а також має атрибут Serializable
        [Serializable]
        public class Ukraine : IRegion, IComparable<Ukraine>
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
                       $"Адмін. центр: {AdminCenter}\n" +
                       $"Нас. центру: {AdminPopulation} осіб";
            }

            public int CompareTo(Ukraine other)
            {
                return this.Area.CompareTo(other.Area);
            }
        }

        private Ukraine myRegion;
        private List<Ukraine> regionList = new List<Ukraine>();


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            myRegion = new Ukraine(
            tbName.Text,
            Convert.ToInt32(tbArea.Text),
            Convert.ToInt32(tbPopulation.Text),
            tbAdminName.Text,
            Convert.ToInt32(tbAdminPop.Text)
            );

            regionList.Add(myRegion);
            MessageBox.Show("Дані збережено!");
        }

        private void btnShow_Click(object sender, EventArgs e)
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

        private void btnAddSample_Click(object sender, EventArgs e)
        {
            regionList.Add(new Ukraine("Київська", 28900, 1780000, "Київ", 2900000));
            regionList.Add(new Ukraine("Дніпропетровська", 31900, 1300000, "Дніпро", 980000));
            regionList.Insert(2, new Ukraine("Запорізька", 27100, 1050000, "Запоріжжя", 750000));
            MessageBox.Show("Елементи додано до списку!");
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            regionList.Sort();
            MessageBox.Show("Список відсортовано за площею!");
        }

        private void btnSaveToTextFile_Click(object sender, EventArgs e)
        {
            if (myRegion == null)
            {
                MessageBox.Show("Спочатку створіть об'єкт області!");
                return;
            }

            string path = "region_info.txt";
            File.WriteAllText(path, myRegion.GetInfo());

            MessageBox.Show("Інформацію записано в файл region_info.txt");
        }

        private void btnSerializeBinary_Click_1(object sender, EventArgs e)
        {
            if (myRegion == null)
            {
                MessageBox.Show("Спочатку створіть об'єкт області!");
                return;
            }

            string path = "region_binary.dat";

            // Використання BinaryFormatter для серіалізації
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
#pragma warning disable SYSLIB0011 
                formatter.Serialize(fs, myRegion);
#pragma warning restore SYSLIB0011
            }

            MessageBox.Show("Об'єкт серіалізовано у файл region_binary.dat");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbArea.Clear();
            tbPopulation.Clear();
            tbAdminName.Clear();
            tbAdminPop.Clear();
            comboBox1.SelectedIndex = -1;
            MessageBox.Show("Поля очищено!");
        }

        private void btnDeleteLast_Click_1(object sender, EventArgs e)
        {
            if (regionList.Count > 0)
            {
                regionList.RemoveAt(regionList.Count - 1);
                MessageBox.Show("Останній елемент видалено!");
            }
            else
            {
                MessageBox.Show("Список порожній!");
            }
        }

        private void btnCount_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Кількість об'єктів у списку: {regionList.Count}");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && textBoxResult != null)
            {
                textBoxResult.Text = $"Вибрано: {comboBox1.SelectedItem.ToString()}";
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.Show();
        }

        private void btnCalculateDensity_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbArea.Text, out int area) && int.TryParse(tbPopulation.Text, out int population) && area > 0)
            {
                double density = (double)population / area;
                tbDensityResult.Text = $"Щільність населення: {density:F2} осіб/км²";
            }
            else
            {
                MessageBox.Show("Некоректні дані для розрахунку.");
            }
        }
    }
}

