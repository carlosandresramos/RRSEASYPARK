﻿using RRSEasyPark.Models;
using RRSEASYPARK.Models;

namespace RRSEASYPARK.Service
{
    public interface IParkingLotService
    {

        Task<ServiceResponse> AddParkingLot(string name, string adress, string nit, long telefhone, int price, int disabilityPrice, string info, int cantSpacesMoto, int cantSpacesCar, int cantSpacesDisability, string disabilityservices, string image, Guid cityId, Guid propietaryParkId);
        Task<ParkingLot?> GetParkingLot(Guid parkingLotId);
        Task<IEnumerable<ParkingLot>> GetParkingLots();
        Task<IEnumerable<ParkingLot>> GetParkingLotsPropietary(Guid user);
        Task<ServiceResponse> UpdateParkingLot(Guid parkingLotId, string name, string adress, string nit, long telefhone, int price, int disabilityPrice, string info, int cantSpacesMoto, int cantSpacesCar, int cantSpacesDisability, string disabilityservices, string image, Guid cityId);
        Task<ServiceResponse?> DeleteParkingLot(Guid parkingLotId);

    }
}
