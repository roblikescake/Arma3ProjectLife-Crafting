using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma3ProjectLife_Crafting.utilities
{
    public class VehicleRecipe
    {
        //Internal Recipe Values
        private string vehicleType;
        private int qtyEngine;
        private int qtyTransmission;
        private int qtyRadiator;
        private int qtyBrakeRotors;
        private int qtyDifferential;
        private int qty4WDDifferential;
        private int qtyFuelTank;
        private int qtyChassisRails;
        private int qtyDriveShaft;
        private int qtyExhaustPipes;
        private int qtyWindows;
        private int qtySteelRims;
        private int qtyAlloyRims;
        private int qtyTyres;
        private int qtyHighEndEngine;
        private int qtyHighEndTransmission;
        private int qtyHighEndRadiator;
        private int qtyHighEndBrakeRotors;
        private int qtyHighEndFuelTank;
        private int qtyHighEndChassisRails;
        private int qtyHighEndDriveShaft;
        private int qtyHighEndExhaustPipes;
        private int qtyHighEndDifferential;
        private int qtyPalletsAluminum;
        private int qtyPalletsTitanium;
        private int qtyPalletsSteel;
        private int qtySheetsSteel;

        public VehicleRecipe(string vehicleType, int qtyEngine, int qtyTransmission, int qtyRadiator, int qtyBrakeRotors,  int qtyDifferential, int qty4WDDifferential, int qtyFuelTank, int qtyChassisRails, int qtyDriveShaft, int qtyExhaustPipes, int qtyWindows, int qtySteelRims, int qtyAlloyRims, int qtyTyres, int qtyHighEndEngine, int qtyHighEndTransmission, int qtyHighEndRadiator, int qtyHighEndBrakeRotors, int qtyHighEndFuelTank, int qtyHighEndChassisRails, int qtyHighEndDriveShaft, int qtyHighEndExhaustPipes, int qtyHighEndDifferential, int qtyPalletsAluminum, int qtyPalletsTitanium, int qtyPalletsSteel, int qtySheetsSteel)
        {
            //External Recipe Values
            this.vehicleType = vehicleType;
            this.qtyEngine = qtyEngine;
            this.qtyTransmission = qtyTransmission;
            this.qtyRadiator = qtyRadiator;
            this.qtyBrakeRotors = qtyBrakeRotors;
            this.qtyDifferential = qtyDifferential;
            this.qty4WDDifferential = qty4WDDifferential;
            this.qtyFuelTank = qtyFuelTank;
            this.qtyChassisRails = qtyChassisRails;
            this.qtyDriveShaft = qtyDriveShaft;
            this.qtyExhaustPipes = qtyExhaustPipes;
            this.qtyWindows = qtyWindows;
            this.qtySteelRims = qtySteelRims;
            this.qtyAlloyRims = qtyAlloyRims;
            this.qtyTyres = qtyTyres;
            this.qtyHighEndEngine = qtyHighEndEngine;
            this.qtyHighEndTransmission = qtyHighEndTransmission;
            this.qtyHighEndRadiator = qtyHighEndRadiator;
            this.qtyHighEndBrakeRotors = qtyHighEndBrakeRotors;
            this.qtyHighEndFuelTank = qtyHighEndFuelTank;
            this.qtyHighEndChassisRails = qtyHighEndChassisRails;
            this.qtyHighEndDriveShaft = qtyHighEndDriveShaft;
            this.qtyHighEndExhaustPipes = qtyHighEndExhaustPipes;
            this.qtyHighEndDifferential = qtyHighEndDifferential;
            this.qtyPalletsAluminum = qtyPalletsAluminum;
            this.qtyPalletsTitanium = qtyPalletsTitanium;
            this.qtyPalletsSteel = qtyPalletsSteel;
            this.qtySheetsSteel = qtySheetsSteel;
    }
        //Useable values
        public string getVehicleType()
        {
            return vehicleType;
        }
        public int getQtyEngine()
        {
            return qtyEngine;
        }
        public int getQtyTransmission()
        {
            return qtyTransmission;
        }
        public int getQtyRadiator()
        {
            return qtyRadiator;
        }
        public int getQtyBrakeRotors()
        {
            return qtyBrakeRotors;
        }
        public int getQtyDifferential()
        {
            return qtyDifferential;
        }
        public int getQty4WDDifferential()
        {
            return qty4WDDifferential;
        }
        public int getQtyFuelTank()
        {
            return qtyFuelTank;
        }
        public int getQtyChassisRails()
        {
            return qtyChassisRails;
        }
        public int getQtyDriveShaft()
        {
            return qtyDriveShaft;
        }
        public int getQtyExhaustPipes()
        {
            return qtyExhaustPipes;
        }
        public int getQtyWindows()
        {
            return qtyWindows;
        }
        public int getQtySteelRims()
        {
            return qtySteelRims;
        }
        public int getQtyAlloyRims()
        {
            return qtyAlloyRims;
        }
        public int getQtyTyres()
        {
            return qtyTyres;
        }
        public int getQtyHighEndEngine()
        {
            return qtyHighEndEngine;
        }
        public int getQtyHighEndTransmission()
        {
            return qtyHighEndTransmission;
        }
        public int getQtyHighEndRadiator()
        {
            return qtyHighEndRadiator;
        }
        public int getQtyHighEndBrakeRotors()
        {
            return qtyHighEndBrakeRotors;
        }
        public int getQtyHighEndFuelTank()
        {
            return qtyHighEndFuelTank;
        }
        public int getQtyHighEndChassisRails()
        {
            return qtyHighEndChassisRails;
        }
        public int getQtyHighEndDriveShaft()
        {
            return qtyHighEndDriveShaft;
        }
        public int getQtyHighEndExhaustPipes()
        {
            return qtyHighEndExhaustPipes;
        }
        public int getQtyHighEndDifferential()
        {
            return qtyHighEndDifferential;
        }
        public int getQtyPalletsAluminum()
        {
            return qtyPalletsAluminum;
        }
        public int getQtyPalletsTitanium()
        {
            return qtyPalletsTitanium;
        }
        public int getQtyPalletsSteel()
        {
            return qtyPalletsSteel;
        }
        public int getQtySheetsSteel()
        {
            return qtySheetsSteel;
        }
    }
}
