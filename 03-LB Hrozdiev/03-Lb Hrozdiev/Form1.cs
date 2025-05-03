using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _03_Lb_Hrozdiev
{
    public partial class Form1: Form
    {
        class Ukraine
        {
             //означає, що поле або метод доступні
             //тільки всередині цього класу.Інші класи
             //або форма не можуть звертатись до них напряму.
            private string name;
            private int area;
            private int population;
            private string nameadmin;
            private int adminpop;

            //Це конструктор, який автоматично викликається при 
            //створенні об'єкта. Конструктор без параметрів не приймає
            //значення і встановлює початкові дані.
            public Ukraine()
            {
                name = "Київська";
                area = 28000;
                population = 1500000;
                nameadmin = "Київ";
                adminpop = 1000000;
            }

            //Створення конструктору, він має таку саму назву як і клас,
            //і не має типу повернення, на приклад void
            public Ukraine(int population, string nameadmin, int adminpop)
            {
                this.population = population;
                this.nameadmin = nameadmin;
                this.adminpop = adminpop;
            }

            public Ukraine(string name, int area, int population, string nameadmin, int adminpop)
            {
                this.name = name;
                this.area = area;
                this.population = population;
                this.nameadmin = nameadmin;
                this.adminpop = adminpop;
            }

            //Реалізація методу, який замінить оператори присвоєння на
            //виклики конструкторів. 
            //Створюємо метод котрий  всередині себе створює об’єкт з 
            //потрібними параметрами через конструктор, а потім копіює 
            //значення в основні поля.
            public void InitWithAllFields(string name, int area, int population, string nameadmin, int adminpop)
            {
                Ukraine temp = new Ukraine(name, area, population, nameadmin, adminpop);
                this.name = temp.name;
                this.area = temp.area;
                this.population = temp.population;
                this.nameadmin = temp.nameadmin;
                this.adminpop = temp.adminpop;
            }

            public string GetName() { return name; }
            public int GetArea() { return area; }
            public int GetPopulation() { return population; }
            public string GetNameAdmin() { return nameadmin; }
            public int GetAdminPop() { return adminpop; }

        }

        Ukraine fUkraine = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fUkraine = new Ukraine(); // створення об'єкта
            fUkraine.InitWithAllFields(
                tbName.Text,
                Convert.ToInt32(tbArea.Text),
                Convert.ToInt32(tbPopulation.Text),
                tbAdminName.Text,
                Convert.ToInt32(tbAdminPop.Text)
            );

            MessageBox.Show("Save success");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fUkraine.ToString(), "03-Lb_hrozdiev", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Назва області України: " + fUkraine.GetName() + "\n" +
                       "Площа області України: " + fUkraine.GetArea() + "\n" +
                       "Населення області України: " + fUkraine.GetPopulation() + "\n" +
                       "Назва адміністративного центру області України: " + fUkraine.GetNameAdmin() + "\n" +
                       "Населення адміністративного центру: " + fUkraine.GetAdminPop());
        }
    }
}