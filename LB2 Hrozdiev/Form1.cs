using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_Prystupa
{
    public partial class Form1: Form
    {
        class Ukraine
        {
            
           private string name;
           private int area;
           public int population;
           public string nameadmin;
           public int adminpop;

           public Ukraine(int population, string nameadmin, int adminpop)
            {
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

            public string GetName() {  return this.name; }
            public int GetArea() { return this.area; }

        }

        public Form1()
        {
            InitializeComponent();
        }

        Ukraine fUkraine = null;

        private void btnSave_Click(object sender, EventArgs e)
        {
            fUkraine = new Ukraine(Convert.ToInt32(tbPopulation.Text), tbAdminName.Text, Convert.ToInt32(tbAdminPop.Text));
            fUkraine.SetName(tbName.Text);
            fUkraine.SetArea(Convert.ToInt32(tbArea.Text));
            MessageBox.Show("Save success");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Назва області України: " + fUkraine.GetName() + "\n" +
                "Площа області України: " + fUkraine.GetArea() + "\n" +
                "Населення області України: " + fUkraine.population + "\n" +
                "Назва адміністративного центру області України: " + fUkraine.nameadmin + "\n" +
                "Населення адіміністративного центру: " + fUkraine.adminpop + "\n", "02-Lb_hrozdiev", MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }
    }
}
