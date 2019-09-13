using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma3ProjectLife_Crafting.utilities
{
    public class VehicleManager
    {
        //Internal Usage
        Dictionary<string, VehicleRecipe> dict = new Dictionary<string, VehicleRecipe>();

        // Set Data for Vehicles
        public VehicleManager()
        {
            //Vehicle Type: Car
            dict.Add("Ford Mustang", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 16, 0, 0, 0));
            dict.Add("BMW M3 E92", new VehicleRecipe("Car", 1, 0, 1, 4, 0, 0, 0, 1, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0));
            dict.Add("Ford Crown Victoria [Rusted]", new VehicleRecipe("Car", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Ford Crown Victoria", new VehicleRecipe("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Dodge Charger", new VehicleRecipe("Car", 0, 0, 1, 4, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 0, 0, 1, 1, 1, 1, 1, 12, 0, 0, 0));
            dict.Add("Lamborghini Gallardo", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 0, 35, 0, 0));
            dict.Add("Chevrolet Camaro", new VehicleRecipe("Car", 1, 1, 1, 4, 1, 0, 1, 1, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Chevrolet Corvette ZR1", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 25, 0, 0));
            dict.Add("1969 Dodge Charger R/T", new VehicleRecipe("Car", 1, 1, 2, 4, 1, 0, 1, 1, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Honda CR-X", new VehicleRecipe("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Porsche 911 GT2", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 30, 0, 0));
            dict.Add("Challenger Hellcat", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 18, 0, 0, 0));
            dict.Add("Dodge Charger 2015", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 1, 2, 1, 1, 1, 1, 1, 16, 0, 0, 0));
            dict.Add("Ford Crown Victoria Taxi", new VehicleRecipe("Car", 1, 1, 0, 4, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("2018 Chevrolet Camaro SS", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 4, 2, 0, 30, 0, 0));
            dict.Add("2013 Ford Taurus", new VehicleRecipe("Car", 0, 0, 2, 2, 0, 1, 0, 1, 4, 2, 6, 4, 0, 4, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("2015 Dodge Charger Hellcat", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 2, 2, 0, 30, 0, 0));
            dict.Add("2014 Chevrolet Corvette", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 2, 1, 1, 4, 2, 2, 0, 30, 0, 0));
            dict.Add("2017 Lamborghini LP 640-4 Performant", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 50, 0, 0));
            dict.Add("2018 Dodge Demon SRT", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 30, 0, 0));
            dict.Add("2018 Dodge Demon Hellcat", new VehicleRecipe("Car", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 2, 3, 4, 1, 1, 4, 4, 2, 0, 30, 0, 0));

            //Vehicle Type: SUV
            dict.Add("Chevrolet Tahoe", new VehicleRecipe("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Jeep Wrangler", new VehicleRecipe("SUV", 1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 3, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("2011 BMW X5", new VehicleRecipe("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 2, 1, 0, 0, 0, 0, 15, 0, 0, 0));
            dict.Add("2012 Range Rover", new VehicleRecipe("SUV", 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 10, 0, 0, 0));
            dict.Add("2014 Ford E-350 Delivery", new VehicleRecipe("SUV", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("2014 Ford E-350 Passenger", new VehicleRecipe("SUV", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("2016 Ford Explorer", new VehicleRecipe("SUV", 0, 0, 2, 4, 1, 1, 1, 1, 0, 4, 6, 4, 0, 4, 1, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0));
            dict.Add("Chevrolet Suburban", new VehicleRecipe("SUV", 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0));

            //Vehicle Type: Truck
            dict.Add("Ford F150", new VehicleRecipe("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 2, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            dict.Add("Dodge Ram", new VehicleRecipe("Truck", 1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Chevrolet Silverado", new VehicleRecipe("Truck", 0, 0, 2, 0, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 1, 1, 0, 4, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            dict.Add("Fuel Truck", new VehicleRecipe("Truck", 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Peterbilt 362 Tow Truck", new VehicleRecipe("Truck", 1, 1, 2, 6, 2, 0, 0, 1, 1, 0, 2, 6, 0, 6, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Ford F-150 Marker Lights", new VehicleRecipe("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            dict.Add("Mail Truck", new VehicleRecipe("Truck", 1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Peterbilt 362", new VehicleRecipe("Truck", 0, 1, 2, 0, 2, 0, 0, 1, 1, 1, 3, 6, 0, 6, 1, 0, 0, 6, 2, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("2014 Ford E-350 Box Truck", new VehicleRecipe("Truck", 0, 1, 0, 4, 1, 0, 0, 0, 0, 1, 4, 4, 0, 4, 1, 0, 1, 0, 0, 0, 1, 0, 0, 5, 0, 0, 0));
            dict.Add("2014 Ford E-350 Box Truck [Extended]", new VehicleRecipe("Truck", 0, 1, 0, 4, 1, 0, 0, 0, 0, 1, 4, 4, 0, 4, 1, 0, 1, 0, 0, 0, 1, 0, 0, 10, 0, 0, 0));
            dict.Add("2018 Ford F-150 King Ranch Crew Cab", new VehicleRecipe("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 2, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            dict.Add("2018 Ford F-150 Raptor", new VehicleRecipe("Truck", 1, 0, 1, 4, 0, 1, 1, 0, 0, 2, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            dict.Add("2018 Ford F-150 Lariat Crew Cab", new VehicleRecipe("Truck", 0, 0, 2, 6, 0, 1, 1, 0, 0, 2, 6, 0, 6, 6, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));
            dict.Add("2018 Ford F-150 Lariat Crew Cab Dually", new VehicleRecipe("Truck", 0, 0, 2, 6, 0, 1, 1, 0, 0, 2, 6, 0, 6, 6, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0));


            //Vehicle Type: Trailer
            dict.Add("Semi Boat Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6));
            dict.Add("Box Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Lowloader Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Tanker Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 4, 2, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Drill Trailer", new VehicleRecipe("Trailer", 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Boat Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 2, 1, 0, 0, 1, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Car Trailer", new VehicleRecipe("Trailer", 0, 0, 0, 4, 1, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

            //Vehicle Type: Other
            dict.Add("Scooter", new VehicleRecipe("Other", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Quad", new VehicleRecipe("Other", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            dict.Add("Mini Excavator", new VehicleRecipe("Other", 0, 1, 1, 4, 0, 1, 1, 1, 1, 1, 1, 4, 0, 4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0));
            dict.Add("Van Transport", new VehicleRecipe("Other", 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 6, 0, 4, 4, 0, 0, 1, 4, 0, 0, 1, 0, 0, 0, 0, 0, 0));
            dict.Add("2018 Harley Davidson Street 500", new VehicleRecipe("Other", 0, 0, 1, 2, 1, 0, 1, 1, 0, 4, 0, 4, 0, 2, 1, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0));

        }
    }
}
