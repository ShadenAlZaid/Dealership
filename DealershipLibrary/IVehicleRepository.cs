﻿using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public interface IVehicleRepository
    {
        string SubmitToDB(List<VehicleDTO> ShoppingCart);
        List<LookupDTO> GetColors();
        List<LookupDTO> GetModels();
        List<LookupDTO> GetTypes();
    }
}