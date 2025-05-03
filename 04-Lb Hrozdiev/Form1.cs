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

namespace _04_Lb_Hrozdiev
{
    public partial class Form1: Form
    {
        class Ukraine
        {
            private string name;
            private int area;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Area
            {
                get { return area; }
                set { area = value; }
            }

            public int Population { get; set; }
            public string NameAdmin { get; set; }
            public int AdminPop { get; set; }
            public string RegionType { get; set; }
            public int YearFounded { get; set; }

            public double PopulationDensity
            {
                get
                {
                    if (Area == 0) return 0;
                    return (double)Population / Area;
                }
            }

            public Ukraine()
            {
                Name = "Київська";
                Area = 28000;
                Population = 1500000;
                NameAdmin = "Київ";
                AdminPop = 1000000;
                RegionType = "Область";
                YearFounded = 1932;
            }

            public Ukraine(string name, int area, int population, string nameAdmin, int adminPop, string regionType, int yearFounded)
            {
                Name = name;
                Area = area;
                Population = population;
                NameAdmin = nameAdmin;
                AdminPop = adminPop;
                RegionType = regionType;
                YearFounded = yearFounded;
            }

            public void InitWithAllFields(string name, int area, int population, string nameAdmin, int adminPop, string regionType, int yearFounded)
            {
                Ukraine temp = new Ukraine(name, area, population, nameAdmin, adminPop, regionType, yearFounded);
                this.Name = temp.Name;
                this.Area = temp.Area;
                this.Population = temp.Population;
                this.NameAdmin = temp.NameAdmin;
                this.AdminPop = temp.AdminPop;
                this.RegionType = temp.RegionType;
                this.YearFounded = temp.YearFounded;
            }

            public void UpdatePopulation(int newPopulation)
            {
                Population = newPopulation;
            }

            public void UpdateRegionType(ref string newType)
            {
                RegionType = newType;
                newType = newType.ToUpper();
            }
        }

        Ukraine fUkraine = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fUkraine = new Ukraine();
            fUkraine.InitWithAllFields(
                tbName.Text,
                Convert.ToInt32(tbArea.Text),
                Convert.ToInt32(tbPopulation.Text),
                tbAdminName.Text,
                Convert.ToInt32(tbAdminPop.Text),
                tbRegionType.Text,
                Convert.ToInt32(tbYearFounded.Text)
            );

            MessageBox.Show("Збережено успішно!");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string info = "Назва області України: " + fUkraine.Name + "\n" +
                          "Площа області України: " + fUkraine.Area + " км²\n" +
                          "Населення області України: " + fUkraine.Population + "\n" +
                          "Адміністративний центр: " + fUkraine.NameAdmin + "\n" +
                          "Населення адмінцентру: " + fUkraine.AdminPop + "\n" +
                          "Тип регіону: " + fUkraine.RegionType + "\n" +
                          "Рік утворення: " + fUkraine.YearFounded + "\n" +
                          "Щільність населення: " + fUkraine.PopulationDensity.ToString("F2") + " осіб/км²";

            MessageBox.Show(info, "Інформація про область", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

