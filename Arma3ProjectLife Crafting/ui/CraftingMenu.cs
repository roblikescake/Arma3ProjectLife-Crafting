using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Arma3ProjectLife_Crafting.Properties;
using Arma3ProjectLife_Crafting.utilities;

namespace Arma3ProjectLife_Crafting.ui
{
    public partial class CraftingMenu : Form
    {
        //Dropdown Menu
        private bool _isCollapsed;

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

            comboBoxVehicleList.Items.Clear();
            loadVehiclesByType("Car");
        }

        private void buttonVehicleTypeSUV_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;

            comboBoxVehicleList.Items.Clear();
            loadVehiclesByType("SUV");
        }

        private void buttonVehicleTypeTruck_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;

            comboBoxVehicleList.Items.Clear();
            loadVehiclesByType("Truck");
        }

        private void buttonVehicleTypeTrailer_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;

            comboBoxVehicleList.Items.Clear();
            loadVehiclesByType("Trailer");
        }

        private void buttonVehicleTypeOther_Click(object sender, EventArgs e)
        {
            //do stuff
            comboBoxVehicleList.Visible = true;
            staticLabelChooseVehicle.Visible = true;

            comboBoxVehicleList.Items.Clear();
            loadVehiclesByType("Other");
        }

        private void loadVehiclesByType(string _vehicleType)
        {
            foreach (KeyValuePair<string, VehicleData> entry in VehicleData.GetVehicles())
            {
                string vehicleName = entry.Key;
                var value = entry.Value;

                if (value.VehicleType == _vehicleType)
                {
                    comboBoxVehicleList.Items.Add(vehicleName);
                }
            }
        }

        //debug crap
        private void loadVehicleData()
        {
            string _vehicleName = comboBoxVehicleList.SelectedItem.ToString();

            if (VehicleData.GetVehicles().ContainsKey(_vehicleName))
            {
                //label1.Text = "KEY VehicleName Found: " + _vehicleName;
                label1.Text = VehicleData.GetVehicles()[_vehicleName].ToString();
            }
            else
            {
                label1.Text = "NOT Found: " + _vehicleName;
            }
        }


        //Internal Usage Only
        private void ComboBoxVehicleList_SelectionChangeCommited (object sender, EventArgs e)
        {
            loadVehicleData();
        }

        private void buttonChooseVehicleType_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isCollapsed)
            {
                buttonChooseVehicleType.Image = Resources.Collapse_Arrow_20px;
                panelVehicleType.Height += 10;
                if (panelVehicleType.Size == panelVehicleType.MaximumSize)
                {
                    timer1.Stop();
                    _isCollapsed = false;
                }
            }
            else
            {
                buttonChooseVehicleType.Image = Resources.Expand_Arrow_20px;
                panelVehicleType.Height -= 10;
                if (panelVehicleType.Size == panelVehicleType.MinimumSize)
                {
                    timer1.Stop();
                    _isCollapsed = true;
                }
            }
        }
    }
}
