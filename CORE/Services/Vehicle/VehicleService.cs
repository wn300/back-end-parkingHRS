using CORE.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Services.Vehicle
{
    public class VehicleService
    {
        public static object GetVehiclesByPlate(string plate)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var vehicleResult = context.Vehicle
                                    .Include("ParkingService")
                                    .Where(vehicle => vehicle.VehicularPlate.Equals(plate))
                                    .ToList();

                    return vehicleResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void PostVehicle(Model.Vehicle vehicle)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    context.Vehicle.Add(vehicle);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void PutVehicle(Model.Vehicle vehicle)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    context.Entry(vehicle).State = EntityState.Modified;
                    context.SaveChanges();                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteVehicle(int id)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var itemToRemove = context.Vehicle.SingleOrDefault(x => x.Id == id);
                    if (itemToRemove != null)
                    {
                        context.Vehicle.Remove(itemToRemove);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
