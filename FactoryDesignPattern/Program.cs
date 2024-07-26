using FactoryDesignPattern;

Client client = new Client();
client.BuildVehicleInfo(VehicleType.Scooter);
client.BuildVehicleInfo(VehicleType.Bike);
client.BuildVehicleInfo(VehicleType.Car);

