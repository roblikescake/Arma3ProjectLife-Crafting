using System.Collections.Generic;

namespace Arma3ProjectLife_Crafting.utilities
{
    public class VehicleData
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

        public VehicleData(string vehicleType, int qtyEngine, int qtyTransmission, int qtyRadiator, int qtyBrakeRotors, int qtyDifferential, int qty4WDDifferential, int qtyFuelTank, int qtyChassisRails, int qtyDriveShaft, int qtyExhaustPipes, int qtyWindows, int qtySteelRims, int qtyAlloyRims, int qtyTyres, int qtyHighEndEngine, int qtyHighEndTransmission, int qtyHighEndRadiator, int qtyHighEndBrakeRotors, int qtyHighEndFuelTank, int qtyHighEndChassisRails, int qtyHighEndDriveShaft, int qtyHighEndExhaustPipes, int qtyHighEndDifferential, int qtyPalletsAluminum, int qtyPalletsTitanium, int qtyPalletsSteel, int qtySheetsSteel)
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


        public static Dictionary<string, VehicleData> GetVehicles()
        {
            var allVehicles = new Dictionary<string, VehicleData>
            {

                //Vehicle Type: Car
                { "Ford Mustang", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 16, 0, 0, 0) },
                { "BMW M3 E92", new VehicleData("Car", 1, 0, 1, 4, 0, 0, 0, 1, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0) },
                { "Ford Crown Victoria [Rusted]", new VehicleData("Car", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Ford Crown Victoria", new VehicleData("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Dodge Charger", new VehicleData("Car", 0, 0, 1, 4, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 0, 0, 1, 1, 1, 1, 1, 12, 0, 0, 0) },
                { "Lamborghini Gallardo", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 0, 35, 0, 0) },
                { "Chevrolet Camaro", new VehicleData("Car", 1, 1, 1, 4, 1, 0, 1, 1, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Chevrolet Corvette ZR1", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 25, 0, 0) },
                { "1969 Dodge Charger R/T", new VehicleData("Car", 1, 1, 2, 4, 1, 0, 1, 1, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Honda CR-X", new VehicleData("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Porsche 911 GT2", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 30, 0, 0) },
                { "Challenger Hellcat", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 18, 0, 0, 0) },
                { "Dodge Charger 2015", new VehicleData("Car", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 1, 2, 1, 1, 1, 1, 1, 16, 0, 0, 0) },
                { "Ford Crown Victoria Taxi", new VehicleData("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "2018 Chevrolet Camaro SS", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 4, 2, 0, 30, 0, 0) },
                { "2013 Ford Taurus", new VehicleData("Car", 0, 0, 2, 2, 0, 1, 0, 1, 4, 2, 6, 4, 0, 4, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "2015 Dodge Charger Hellcat", new VehicleData("Car", 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 2, 2, 0, 30, 0, 0) },
                { "2014 Chevrolet Corvette", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 2, 2, 0, 30, 0, 0) },
                { "2017 Lamborghini LP 640-4 Performant", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 50, 0, 0) },
                { "2018 Dodge Demon SRT", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 30, 0, 0) },
                { "2018 Dodge Demon Hellcat", new VehicleData("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 30, 0, 0) },

                //Vehicle Type: SUV
                { "Chevrolet Tahoe", new VehicleData("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Jeep Wrangler", new VehicleData("SUV", 1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 3, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "2011 BMW X5", new VehicleData("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 2, 1, 0, 0, 0, 0, 15, 0, 0, 0) },
                { "2012 Range Rover", new VehicleData("SUV", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 10, 0, 0, 0) },
                { "2014 Ford E-350 Delivery", new VehicleData("SUV", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "2014 Ford E-350 Passenger", new VehicleData("SUV", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "2016 Ford Explorer", new VehicleData("SUV", 0, 0, 2, 4, 1, 1, 1, 1, 0, 4, 6, 4, 0, 4, 1, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0) },
                { "Chevrolet Suburban", new VehicleData("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0) },

                //Vehicle Type: Truck
                { "Ford F150", new VehicleData("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 2, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "Dodge Ram", new VehicleData("Truck", 1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Chevrolet Silverado", new VehicleData("Truck", 0, 0, 2, 0, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 1, 1, 0, 4, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "Fuel Truck", new VehicleData("Truck", 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Peterbilt 362 Tow Truck", new VehicleData("Truck", 1, 1, 2, 6, 2, 0, 0, 1, 1, 0, 2, 6, 0, 6, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Ford F-150 Marker Lights", new VehicleData("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "Mail Truck", new VehicleData("Truck", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Peterbilt 362", new VehicleData("Truck", 0, 1, 2, 0, 2, 0, 0, 1, 1, 1, 3, 6, 0, 6, 1, 0, 0, 6, 2, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "2014 Ford E-350 Box Truck", new VehicleData("Truck", 0, 1, 0, 4, 1, 0, 0, 0, 0, 1, 4, 4, 0, 4, 1, 0, 1, 0, 0, 0, 1, 0, 0, 5, 0, 0, 0) },
                { "2014 Ford E-350 Box Truck [Extended]", new VehicleData("Truck", 0, 1, 0, 4, 1, 0, 0, 0, 0, 1, 4, 4, 0, 4, 1, 0, 1, 0, 0, 0, 1, 0, 0, 10, 0, 0, 0) },
                { "2018 Ford F-150 King Ranch Crew Cab", new VehicleData("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 2, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "2018 Ford F-150 Raptor", new VehicleData("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 2, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "2018 Ford F-150 Lariat Crew Cab", new VehicleData("Truck", 0, 0, 2, 6, 0, 1, 1, 0, 0, 2, 6, 0, 6, 6, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "2018 Ford F-150 Lariat Crew Cab Dually", new VehicleData("Truck", 0, 0, 2, 6, 0, 1, 1, 0, 0, 2, 6, 0, 6, 6, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0) },


                //Vehicle Type: Trailer
                { "Semi Boat Trailer", new VehicleData("Trailer", 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6) },
                { "Box Trailer", new VehicleData("Trailer", 0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Lowloader Trailer", new VehicleData("Trailer", 0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Tanker Trailer", new VehicleData("Trailer", 0, 0, 0, 4, 2, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Drill Trailer", new VehicleData("Trailer", 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Boat Trailer", new VehicleData("Trailer", 0, 0, 0, 2, 1, 0, 0, 1, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Car Trailer", new VehicleData("Trailer", 0, 0, 0, 4, 1, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },

                //Vehicle Type: Other
                { "Scooter", new VehicleData("Other", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Quad", new VehicleData("Other", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Mini Excavator", new VehicleData("Other", 0, 1, 1, 4, 0, 1, 1, 1, 1, 1, 1, 4, 0, 4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0) },
                { "Van Transport", new VehicleData("Other", 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 6, 0, 4, 4, 0, 0, 1, 4, 0, 0, 1, 0, 0, 0, 0, 0, 0) },
                { "2018 Harley Davidson Street 500", new VehicleData("Other", 0, 0, 1, 2, 1, 0, 1, 1, 0, 4, 0, 4, 0, 2, 1, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0) }
            };

            return allVehicles;
        }
    }
}
