// See https://aka.ms/new-console-template for more information
using DealershipLibrary.Vehicle.Cars;
using DealershipLibrary;
using DealershipLibrary.Vehicle;

// var shoppingCart = new List<IVehicle>();

    IVehicle vehicle = null;
    IVehicleFactory vehicleFactory = null;

    Extensions.PrintEnum(typeof(VehicleTypes));

    var choice = (int)(Extensions.GetSelectedOptions<VehicleTypes>());
    var type = (VehicleTypes)choice;

    //Apply SOLID   learn(SO) in solid
    switch (type)
    {
        case VehicleTypes.Car:
            vehicleFactory = new CarFactory();
            break;
        case VehicleTypes.Motorcycle:
            vehicleFactory = new MCFactory();
        break;
        case VehicleTypes.Truck:
            vehicleFactory = new TruckFactory();
        break;
        default:
            break;
    }

    vehicle = vehicleFactory.CreateVehicle();