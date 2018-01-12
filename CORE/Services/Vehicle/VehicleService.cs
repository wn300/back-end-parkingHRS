using CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Services.Vehicle
{
    public class VehicleService
    {
        public static object GetVehiclesById(int id)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var usuarios = context.Vehicle
                                    .Where(vehicle => vehicle.Id.Equals(id))
                                    .Select(result => result)
                                    .ToList();

                    return usuarios;
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
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
