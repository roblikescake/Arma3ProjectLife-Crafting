using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma3ProjectLife_Crafting.utilities
{
    public class VehicleRecipe
    {
        public string VehicleType { get; set; }
        public int QtyEngine { get; set; }
        public int QtyTransmission { get; set; }
        public int QtyRadiator { get; set; }
        public int QtyBrakeRotors { get; set; }
        public int QtyDifferential { get; set; }
        public int Qty4WDDifferential { get; set; }
        public int QtyFuelTank { get; set; }
        public int QtyChassisRails { get; set; }
        public int QtyDriveShaft { get; set; }
        public int QtyExhaustPipes { get; set; }
        public int QtyWindows { get; set; }
        public int QtySteelRims { get; set; }
        public int QtyAlloyRims { get; set; }
        public int QtyTyres { get; set; }
        public int QtyHighEndEngine { get; set; }
        public int QtyHighEndTransmission { get; set; }
        public int QtyHighEndRadiator { get; set; }
        public int QtyHighEndBrakeRotors { get; set; }
        public int QtyHighEndFuelTank { get; set; }
        public int QtyHighEndChassisRails { get; set; }
        public int QtyHighEndDriveShaft { get; set; }
        public int QtyHighEndExhaustPipes { get; set; }
        public int QtyHighEndDifferential { get; set; }
        public int QtyPalletsAluminum { get; set; }
        public int QtyPalletsTitanium { get; set; }
        public int QtyPalletsSteel { get; set; }
        public int QtySheetsSteel { get; set; }

        public VehicleRecipe(string vehicleType, int qtyEngine, int qtyTransmission, int qtyRadiator, int qtyBrakeRotors, int qtyDifferential, int qty4WDDifferential, int qtyFuelTank, int qtyChassisRails, int qtyDriveShaft, int qtyExhaustPipes, int qtyWindows, int qtySteelRims, int qtyAlloyRims, int qtyTyres, int qtyHighEndEngine, int qtyHighEndTransmission, int qtyHighEndRadiator, int qtyHighEndBrakeRotors, int qtyHighEndFuelTank, int qtyHighEndChassisRails, int qtyHighEndDriveShaft, int qtyHighEndExhaustPipes, int qtyHighEndDifferential, int qtyPalletsAluminum, int qtyPalletsTitanium, int qtyPalletsSteel, int qtySheetsSteel)
        {
            VehicleType = vehicleType;
            QtyEngine = qtyEngine;
            QtyTransmission = qtyTransmission;
            QtyRadiator = qtyRadiator;
            QtyBrakeRotors = qtyBrakeRotors;
            QtyDifferential = qtyDifferential;
            Qty4WDDifferential = qty4WDDifferential;
            QtyFuelTank = qtyFuelTank;
            QtyChassisRails = qtyChassisRails;
            QtyDriveShaft = qtyDriveShaft;
            QtyExhaustPipes = qtyExhaustPipes;
            QtyWindows = qtyWindows;
            QtySteelRims = qtySteelRims;
            QtyAlloyRims = qtyAlloyRims;
            QtyTyres = qtyTyres;
            QtyHighEndEngine = qtyHighEndEngine;
            QtyHighEndTransmission = qtyHighEndTransmission;
            QtyHighEndRadiator = qtyHighEndRadiator;
            QtyHighEndBrakeRotors = qtyHighEndBrakeRotors;
            QtyHighEndFuelTank = qtyHighEndFuelTank;
            QtyHighEndChassisRails = qtyHighEndChassisRails;
            QtyHighEndDriveShaft = qtyHighEndDriveShaft;
            QtyHighEndExhaustPipes = qtyHighEndExhaustPipes;
            QtyHighEndDifferential = qtyHighEndDifferential;
            QtyPalletsAluminum = qtyPalletsAluminum;
            QtyPalletsTitanium = qtyPalletsTitanium;
            QtyPalletsSteel = qtyPalletsSteel;
            QtySheetsSteel = qtySheetsSteel;
        }


        public static Dictionary<string, VehicleRecipe> GetVehicles()
        {
            var allVehicles = new Dictionary<string, VehicleRecipe>();

            //Vehicle Type: Car
            allVehicles.Add("Ford Mustang", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 16, 0, 0, 0));
            allVehicles.Add("BMW M3 E92", new VehicleRecipe("Car", 1, 0, 1, 4, 0, 0, 0, 1, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0));
            allVehicles.Add("Ford Crown Victoria [Rusted]", new VehicleRecipe("Car", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Ford Crown Victoria", new VehicleRecipe("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Dodge Charger", new VehicleRecipe("Car", 0, 0, 1, 4, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 0, 0, 1, 1, 1, 1, 1, 12, 0, 0, 0));
            allVehicles.Add("Lamborghini Gallardo", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 0, 35, 0, 0));
            allVehicles.Add("Chevrolet Camaro", new VehicleRecipe("Car", 1, 1, 1, 4, 1, 0, 1, 1, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Chevrolet Corvette ZR1", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 25, 0, 0));
            allVehicles.Add("1969 Dodge Charger R/T", new VehicleRecipe("Car", 1, 1, 2, 4, 1, 0, 1, 1, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Honda CR-X", new VehicleRecipe("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Porsche 911 GT2", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 30, 0, 0));
            allVehicles.Add("Challenger Hellcat", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 18, 0, 0, 0));
            allVehicles.Add("Dodge Charger 2015", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 1, 2, 1, 1, 1, 1, 1, 16, 0, 0, 0));
            allVehicles.Add("Ford Crown Victoria Taxi", new VehicleRecipe("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2018 Chevrolet Camaro SS", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 4, 2, 0, 30, 0, 0));
            allVehicles.Add("2013 Ford Taurus", new VehicleRecipe("Car", 0, 0, 2, 2, 0, 1, 0, 1, 4, 2, 6, 4, 0, 4, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2015 Dodge Charger Hellcat", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 2, 2, 0, 30, 0, 0));
            allVehicles.Add("2014 Chevrolet Corvette", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 2, 2, 0, 30, 0, 0));
            allVehicles.Add("2017 Lamborghini LP 640-4 Performant", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 50, 0, 0));
            allVehicles.Add("2018 Dodge Demon SRT", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 30, 0, 0));
            allVehicles.Add("2018 Dodge Demon Hellcat", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 30, 0, 0));

            //Vehicle Type: SUV
            allVehicles.Add("Chevrolet Tahoe", new VehicleRecipe("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Jeep Wrangler", new VehicleRecipe("SUV", 1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 3, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2011 BMW X5", new VehicleRecipe("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 2, 1, 0, 0, 0, 0, 15, 0, 0, 0));
            allVehicles.Add("2012 Range Rover", new VehicleRecipe("SUV", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 10, 0, 0, 0));
            allVehicles.Add("2014 Ford E-350 Delivery", new VehicleRecipe("SUV", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2014 Ford E-350 Passenger", new VehicleRecipe("SUV", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2016 Ford Explorer", new VehicleRecipe("SUV", 0, 0, 2, 4, 1, 1, 1, 1, 0, 4, 6, 4, 0, 4, 1, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Chevrolet Suburban", new VehicleRecipe("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0));

            //Vehicle Type: Truck
            allVehicles.Add("Ford F150", new VehicleRecipe("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 2, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Dodge Ram", new VehicleRecipe("Truck", 1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Chevrolet Silverado", new VehicleRecipe("Truck", 0, 0, 2, 0, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 1, 1, 0, 4, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Fuel Truck", new VehicleRecipe("Truck", 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Peterbilt 362 Tow Truck", new VehicleRecipe("Truck", 1, 1, 2, 6, 2, 0, 0, 1, 1, 0, 2, 6, 0, 6, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Ford F-150 Marker Lights", new VehicleRecipe("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Mail Truck", new VehicleRecipe("Truck", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Peterbilt 362", new VehicleRecipe("Truck", 0, 1, 2, 0, 2, 0, 0, 1, 1, 1, 3, 6, 0, 6, 1, 0, 0, 6, 2, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2014 Ford E-350 Box Truck", new VehicleRecipe("Truck", 0, 1, 0, 4, 1, 0, 0, 0, 0, 1, 4, 4, 0, 4, 1, 0, 1, 0, 0, 0, 1, 0, 0, 5, 0, 0, 0));
            allVehicles.Add("2014 Ford E-350 Box Truck [Extended]", new VehicleRecipe("Truck", 0, 1, 0, 4, 1, 0, 0, 0, 0, 1, 4, 4, 0, 4, 1, 0, 1, 0, 0, 0, 1, 0, 0, 10, 0, 0, 0));
            allVehicles.Add("2018 Ford F-150 King Ranch Crew Cab", new VehicleRecipe("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 2, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2018 Ford F-150 Raptor", new VehicleRecipe("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 2, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2018 Ford F-150 Lariat Crew Cab", new VehicleRecipe("Truck", 0, 0, 2, 6, 0, 1, 1, 0, 0, 2, 6, 0, 6, 6, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2018 Ford F-150 Lariat Crew Cab Dually", new VehicleRecipe("Truck", 0, 0, 2, 6, 0, 1, 1, 0, 0, 2, 6, 0, 6, 6, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));


            //Vehicle Type: Trailer
            allVehicles.Add("Semi Boat Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6));
            allVehicles.Add("Box Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Lowloader Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Tanker Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 4, 2, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Drill Trailer", new VehicleRecipe("Trailer", 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Boat Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 2, 1, 0, 0, 1, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Car Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 4, 1, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

            //Vehicle Type: Other
            allVehicles.Add("Scooter", new VehicleRecipe("Other", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Quad", new VehicleRecipe("Other", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("Mini Excavator", new VehicleRecipe("Other", 0, 1, 1, 4, 0, 1, 1, 1, 1, 1, 1, 4, 0, 4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0));
            allVehicles.Add("Van Transport", new VehicleRecipe("Other", 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 6, 0, 4, 4, 0, 0, 1, 4, 0, 0, 1, 0, 0, 0, 0, 0, 0));
            allVehicles.Add("2018 Harley Davidson Street 500", new VehicleRecipe("Other", 0, 0, 1, 2, 1, 0, 1, 1, 0, 4, 0, 4, 0, 2, 1, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0));

            return allVehicles;
        }
    }
