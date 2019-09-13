using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arma3ProjectLife_Crafting.Properties;
using Arma3ProjectLife_Crafting.utilities;

namespace Arma3ProjectLife_Crafting.ui
{
    public partial class CraftingMenu : Form
    {
        //Dropdown Menu
        private bool isCollapsed;

        public CraftingMenu()
        {
            InitializeComponent();
            
        }

        private void CraftingMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonVehicleTypeCar_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;
            comboBoxVehicleList.Items.Add("2017 Lamborghini LP 640-4 Performant");
        }

        private void buttonVehicleTypeSUV_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;
            comboBoxVehicleList.Items.Add("Chevrolet Suburban");
        }

        private void buttonVehicleTypeTruck_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;
            comboBoxVehicleList.Items.Add("Ford F-150 Marker Lights");
        }

        private void buttonVehicleTypeTrailer_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;
            comboBoxVehicleList.Items.Add("Lowloader Trailer");
        }

        private void buttonVehicleTypeOther_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;
            comboBoxVehicleList.Items.Add("2018 Harley Davidson Street 500");
        }


        private void buttonChooseVehicleType_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                buttonChooseVehicleType.Image = Resources.Collapse_Arrow_20px;
                panelVehicleType.Height += 10;
                if (panelVehicleType.Size == panelVehicleType.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                buttonChooseVehicleType.Image = Resources.Expand_Arrow_20px;
                panelVehicleType.Height -= 10;
                if (panelVehicleType.Size == panelVehicleType.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        /*
            private void loadVehicles(string vehicleType)
        {
            private string vehicle;
            //WIP
            for (int i = 0; i < VehicleManager.dict.Count(); i++)
            {
                if dict.ContainsValue(vehicleType) {
                    comboBoxVehicleList.Items.Add(vehicle)
                }
            }
        }
        */
    }
}
