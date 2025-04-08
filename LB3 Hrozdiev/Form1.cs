using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb_Hrozdiev
{
    public partial class Form1 : Form
    {
        class Ukraine
        {
            private string name;
            private int area;
            private int population;
            private string nameadmin;
            private int adminpop;

            public Ukraine()
            {
                this.name = "Запорізька";
                this.area = 20;
                this.population = 30;
                this.nameadmin = "Запоріжжя";
                this.adminpop = 40;
            }

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

            public void SetName(string name)
            {
                this.name = name;
            }

            public void SetArea(int area)
            {
                this.area = area;
            }
            public void SetPopulation(int population)
            {
                this.population = population;
            }

            public void SetNameAdmin(string  nameadmin)
            {
                this.nameadmin = nameadmin;
            }

            public void SetAdminPop(int adminpop)
            {
                this.adminpop = adminpop;
            }

            public string GetName() { return this.name; }
            public int GetArea() { return this.area; }
            public int GetPopulation() {  return this.population; }
            public string GetNameAdmin() {  return this.nameadmin; }
            public int GetAdminPop() {  return this.adminpop; }

            public void InitializeFields(string name, int area, int population, string nameadmin, int adminpop)
            {
                Ukraine fUkraine = new Ukraine(name, area, population, nameadmin, adminpop);
                this.name = fUkraine.name;
                this.area = fUkraine.area;
                this.population = fUkraine.population;
                this.nameadmin = fUkraine.nameadmin;
                this.adminpop = fUkraine.adminpop;                                   
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        Ukraine fUkraine = null;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (fUkraine == null) { 
            
            }
            fUkraine = new Ukraine();
            fUkraine.InitializeFields(tbName.Text, Convert.ToInt32(tbArea.Text), Convert.ToInt32(tbPopulation.Text), tbAdminName.Text, Convert.ToInt32(tbAdminPop.Text));
            MessageBox.Show("Save success");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Назва області України: " + fUkraine.GetName() + "\n" +
                "Площа області України: " + fUkraine.GetArea() + "\n" +
                "Населення області України: " + fUkraine.population + "\n" +
                "Назва адміністративного центру області України: " + fUkraine.nameadmin + "\n" +
                "Населення адміністративного центру: " + fUkraine.adminpop + "\n",
                "02-Lb_hrozdiev", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
