using System.Collections.Generic;

namespace Arma3ProjectLife_Crafting.utilities
{
    public class VehicleData
    {
        public string VehicleName { get; set; }
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

        public VehicleData(string vehicleName, string vehicleType, int qtyEngine, int qtyTransmission, int qtyRadiator, int qtyBrakeRotors, int qtyDifferential, int qty4WDDifferential, int qtyFuelTank, int qtyChassisRails, int qtyDriveShaft, int qtyExhaustPipes, int qtyWindows, int qtySteelRims, int qtyAlloyRims, int qtyTyres, int qtyHighEndEngine, int qtyHighEndTransmission, int qtyHighEndRadiator, int qtyHighEndBrakeRotors, int qtyHighEndFuelTank, int qtyHighEndChassisRails, int qtyHighEndDriveShaft, int qtyHighEndExhaustPipes, int qtyHighEndDifferential, int qtyPalletsAluminum, int qtyPalletsTitanium, int qtyPalletsSteel, int qtySheetsSteel)
        {
            VehicleName = vehicleName;
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
            var allVehicles = new Dictionary<string, List<VehicleData>>
            {

                //Vehicle Type: Car
                { "Car", new List<VehicleData>(){
                    new VehicleData("Ford Mustang", "Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 16, 0, 0, 0)
                    new VehicleData("BMW M3 E92","Car", 1, 0, 1, 4, 0, 0, 0, 1, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0),
                    new VehicleData("Ford Crown Victoria [Rusted]","Car", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Ford Crown Victoria","Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Dodge Charger","Car", 0, 0, 1, 4, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 0, 0, 1, 1, 1, 1, 1, 12, 0, 0, 0),
                    new VehicleData("Lamborghini Gallardo","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 0, 35, 0, 0),
                    new VehicleData("Chevrolet Camaro","Car", 1, 1, 1, 4, 1, 0, 1, 1, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Chevrolet Corvette ZR1","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 25, 0, 0),
                    new VehicleData("1969 Dodge Charger R/T","Car", 1, 1, 2, 4, 1, 0, 1, 1, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Honda CR-X","Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Porsche 911 GT2","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 30, 0, 0),
                    new VehicleData("Challenger Hellcat","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 18, 0, 0, 0),
                    new VehicleData("Dodge Charger 2015","Car", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 1, 2, 1, 1, 1, 1, 1, 16, 0, 0, 0),
                    new VehicleData("Ford Crown Victoria Taxi","Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2018 Chevrolet Camaro SS","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 4, 2, 0, 30, 0, 0),
                    new VehicleData("2013 Ford Taurus","Car", 0, 0, 2, 2, 0, 1, 0, 1, 4, 2, 6, 4, 0, 4, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2015 Dodge Charger Hellcat","Car", 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 2, 2, 0, 30, 0, 0),
                    new VehicleData("2014 Chevrolet Corvette","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 2, 2, 0, 30, 0, 0),
                    new VehicleData("2017 Lamborghini LP 640-4 Performant","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 50, 0, 0),
                    new VehicleData("2018 Dodge Demon SRT","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 30, 0, 0),
                    new VehicleData("2018 Dodge Demon Hellcat","Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 30, 0, 0)
                }


                //Vehicle Type: SUV
                { "SUV", new List<VehicleData>(){
                    new VehicleData("Chevrolet Tahoe","SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Jeep Wrangler","SUV", 1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 3, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2011 BMW X5","SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 2, 1, 0, 0, 0, 0, 15, 0, 0, 0),
                    new VehicleData("2012 Range Rover","SUV", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 10, 0, 0, 0),
                    new VehicleData("2014 Ford E-350 Delivery","SUV", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2014 Ford E-350 Passenger","SUV", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2016 Ford Explorer","SUV", 0, 0, 2, 4, 1, 1, 1, 1, 0, 4, 6, 4, 0, 4, 1, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Chevrolet Suburban","SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0)
                }


                //Vehicle Type: Truck
                { "Truck", new List<VehicleData>(){
                    new VehicleData("Ford F150","Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 2, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Dodge Ram","Truck", 1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Chevrolet Silverado","Truck", 0, 0, 2, 0, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 1, 1, 0, 4, 0, 1, 1, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Fuel Truck","Truck", 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Peterbilt 362 Tow Truck","Truck", 1, 1, 2, 6, 2, 0, 0, 1, 1, 0, 2, 6, 0, 6, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Ford F-150 Marker Lights","Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Mail Truck","Truck", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Peterbilt 362","Truck", 0, 1, 2, 0, 2, 0, 0, 1, 1, 1, 3, 6, 0, 6, 1, 0, 0, 6, 2, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2014 Ford E-350 Box Truck","Truck", 0, 1, 0, 4, 1, 0, 0, 0, 0, 1, 4, 4, 0, 4, 1, 0, 1, 0, 0, 0, 1, 0, 0, 5, 0, 0, 0),
                    new VehicleData("2014 Ford E-350 Box Truck [Extended]","Truck", 0, 1, 0, 4, 1, 0, 0, 0, 0, 1, 4, 4, 0, 4, 1, 0, 1, 0, 0, 0, 1, 0, 0, 10, 0, 0, 0),
                    new VehicleData("2018 Ford F-150 King Ranch Crew Cab","Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 2, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2018 Ford F-150 Raptor","Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 2, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2018 Ford F-150 Lariat Crew Cab","Truck", 0, 0, 2, 6, 0, 1, 1, 0, 0, 2, 6, 0, 6, 6, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2018 Ford F-150 Lariat Crew Cab Dually","Truck", 0, 0, 2, 6, 0, 1, 1, 0, 0, 2, 6, 0, 6, 6, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0)
                }


                //Vehicle Type: Trailer
                { "Trailer", new List<VehicleData>(){
                    new VehicleData("Semi Boat Trailer","Trailer", 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6),
                    new VehicleData("Box Trailer","Trailer", 0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Lowloader Trailer","Trailer", 0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Tanker Trailer","Trailer", 0, 0, 0, 4, 2, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Drill Trailer","Trailer", 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Boat Trailer","Trailer", 0, 0, 0, 2, 1, 0, 0, 1, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Car Trailer","Trailer", 0, 0, 0, 4, 1, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                }


                //Vehicle Type: Other
                { "Other", new List<VehicleData>(){
                    new VehicleData("Scooter","Other", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Quad","Other", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                    new VehicleData("Mini Excavator","Other", 0, 1, 1, 4, 0, 1, 1, 1, 1, 1, 1, 4, 0, 4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0),
                    new VehicleData("Van Transport","Other", 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 6, 0, 4, 4, 0, 0, 1, 4, 0, 0, 1, 0, 0, 0, 0, 0, 0),
                    new VehicleData("2018 Harley Davidson Street 500","Other", 0, 0, 1, 2, 1, 0, 1, 1, 0, 4, 0, 4, 0, 2, 1, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0}
                }

            return allVehicles;
        }
    }
}
