using Arma3ProjectLife_Crafting.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma3ProjectLife_Crafting.utilities
{
    public class SelectedVehicleData
    {
        //Dictionary of Selected Vehicle's Steel Parts
        public static Dictionary<string, int> GetSelectedVehicleDataSTL(string _vehicleName)
        {
            VehicleData.GetVehicles().TryGetValue(_vehicleName, out VehicleData value);
            var selectedVehicleData = new Dictionary<string, int>
            {
                { "Engine", value.QtyEngine },
                { "Transmission", value.QtyTransmission },
                { "Radiator", value.QtyRadiator },
                { "Brake Rotors", value.QtyBrakeRotors },
                { "Differential", value.QtyDifferential },
                { "Drive Shaft", value.QtyDriveShaft },
                { "Steel Rims", value.QtySteelRims },
                { "High End Transmission", value.QtyHighEndTransmission },
                { "High End Radiator", value.QtyHighEndRadiator },
                { "High End Brake Rotors", value.QtyHighEndBrakeRotors },
                { "High End Differential", value.QtyHighEndDifferential },
            };
            return selectedVehicleData;
        }

        //Dictionary of Selected Vehicle's Aluminum Parts
        public static Dictionary<string, int> GetSelectedVehicleDataALU(string _vehicleName)
        {
            VehicleData.GetVehicles().TryGetValue(_vehicleName, out VehicleData value);
            var selectedVehicleData = new Dictionary<string, int>
            {
                { "4WD Differential", value.Qty4WDDifferential },
                { "Fuel Tank", value.QtyFuelTank },
                { "Chassis Rails", value.QtyChassisRails },
                { "Exhaust Pipes", value.QtyExhaustPipes },
                { "Alloy Rims", value.QtyAlloyRims },
                { "High End Engine", value.QtyHighEndEngine },
                { "High End Fuel Tank", value.QtyHighEndFuelTank },
                { "High End Chassis Rails", value.QtyHighEndChassisRails },
                { "High End Drive Shaft", value.QtyHighEndDriveShaft },
                { "High End Exhaust Pipes", value.QtyHighEndExhaustPipes },
            };
            return selectedVehicleData;
        }

        //Dictionary of Selected Vehicle's Other Parts
        public static Dictionary<string, int> GetSelectedVehicleDataOther(string _vehicleName)
        {
            VehicleData.GetVehicles().TryGetValue(_vehicleName, out VehicleData value);
            var selectedVehicleData = new Dictionary<string, int>
            {
                { "Windows", value.QtyWindows },
                { "Tyres", value.QtyTyres },
                { "Steel Sheets", value.QtySheetsSteel },
                { "Steel Pallets", value.QtyPalletsSteel },
                { "Aluminum Pallets", value.QtyPalletsAluminum },
                { "Titanium Pallets", value.QtyPalletsTitanium },
            };
            return selectedVehicleData;
        }
    }
}
