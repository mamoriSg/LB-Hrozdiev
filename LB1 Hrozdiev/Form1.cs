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
            
           public string name;
           public int area;
           public int population;
           public string nameadmin;
           public int adminpop;

           public Ukraine(string name, int area, int population, string nameadmin, int adminpop)
            {

                this.name = name;
                this.area = area;
                this.population = population;
                this.nameadmin = nameadmin;
                this.adminpop = adminpop;

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        Ukraine fUkraine = null;

        private void btnSave_Click(object sender, EventArgs e)
        {
            fUkraine = new Ukraine(tbName.Text, Convert.ToInt32(tbArea.Text), Convert.ToInt32(tbPopulation.Text), tbAdminName.Text, Convert.ToInt32(tbAdminPop.Text));

            MessageBox.Show("Save success");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Назва області України: " + fUkraine.name + "\n" +
                "Площа області України: " + fUkraine.area + "\n" +
                "Населення області України: " + fUkraine.population + "\n" +
                "Назва адміністративного центру області України: " + fUkraine.nameadmin + "\n" +
                "Населення адіміністративного центру: " + fUkraine.adminpop + "\n", "01-Lb_hrozdiev", MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }
    }
}
