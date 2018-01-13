using CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CORE.Services.ParkingServices
{
    public class ParkingServicesService
    {
        public static object GetAllParkingService()
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var parkingResult = (from parking in context.ParkingService
                                        select new
                                        {
                                            parking.Id,
                                            parking.IdRate,
                                            Rate = new {
                                                parking.Rates.Id,
                                                parking.Rates.Rate,
                                                parking.Rates.Description,
                                            },
                                            parking.IdVehicle,
                                            Vehicle = new
                                            {
                                                parking.Vehicle.Id,
                                                parking.Vehicle.VehicularPlate,
                                                parking.Vehicle.Brand,
                                                parking.Vehicle.Color,
                                                parking.Vehicle.Driver,
                                                parking.Vehicle.DriverIdentification,
                                                parking.Vehicle.Phone,
                                            },
                                            parking.DateTimeEntry,
                                            parking.DateTimeExit,
                                            parking.ServicePrice,
                                            parking.Estate,
                                        }).ToList();

                    return parkingResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object GetLastParkingServiceByVehicularPlate(string vehicularPlate)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var parkingResult = (from parking in context.ParkingService
                                         where parking.Vehicle.VehicularPlate.Equals(vehicularPlate)
                                         where parking.Estate.Equals(0)
                                         select new
                                         {
                                             parking.Id,
                                             parking.IdRate,
                                             Rate = new
                                             {
                                                 parking.Rates.Id,
                                                 parking.Rates.Rate,
                                                 parking.Rates.Description,
                                             },
                                             parking.IdVehicle,
                                             Vehicle = new
                                             {
                                                 parking.Vehicle.Id,
                                                 parking.Vehicle.VehicularPlate,
                                                 parking.Vehicle.Brand,
                                                 parking.Vehicle.Color,
                                                 parking.Vehicle.Driver,
                                                 parking.Vehicle.DriverIdentification,
                                                 parking.Vehicle.Phone,
                                             },
                                             parking.DateTimeEntry,
                                             parking.DateTimeExit,
                                             parking.ServicePrice,
                                             parking.Estate,
                                         }).ToList();

                    return parkingResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object GetPreviousParkingServiceByVehicularPlate(string vehicularPlate)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var parkingResult = (from parking in context.ParkingService
                                         where parking.Vehicle.VehicularPlate.Equals(vehicularPlate)
                                         where parking.Estate.Equals(1)
                                         select new
                                         {
                                             parking.Id,
                                             parking.IdRate,
                                             Rate = new
                                             {
                                                 parking.Rates.Id,
                                                 parking.Rates.Rate,
                                                 parking.Rates.Description,
                                             },
                                             parking.IdVehicle,
                                             Vehicle = new
                                             {
                                                 parking.Vehicle.Id,
                                                 parking.Vehicle.VehicularPlate,
                                                 parking.Vehicle.Brand,
                                                 parking.Vehicle.Color,
                                                 parking.Vehicle.Driver,
                                                 parking.Vehicle.DriverIdentification,
                                                 parking.Vehicle.Phone,
                                             },
                                             parking.DateTimeEntry,
                                             parking.DateTimeExit,
                                             parking.ServicePrice,
                                             parking.Estate,
                                         }).ToList();

                    return parkingResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object GetAllParkingServiceByVehicularPlate(string vehicularPlate)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var parkingResult = (from parking in context.ParkingService
                                         where parking.Vehicle.VehicularPlate.Equals(vehicularPlate)
                                         select new
                                         {
                                             parking.Id,
                                             parking.IdRate,
                                             Rate = new
                                             {
                                                 parking.Rates.Id,
                                                 parking.Rates.Rate,
                                                 parking.Rates.Description,
                                             },
                                             parking.IdVehicle,
                                             Vehicle = new
                                             {
                                                 parking.Vehicle.Id,
                                                 parking.Vehicle.VehicularPlate,
                                                 parking.Vehicle.Brand,
                                                 parking.Vehicle.Color,
                                                 parking.Vehicle.Driver,
                                                 parking.Vehicle.DriverIdentification,
                                                 parking.Vehicle.Phone,
                                             },
                                             parking.DateTimeEntry,
                                             parking.DateTimeExit,
                                             parking.ServicePrice,
                                             parking.Estate,
                                         }).ToList();

                    return parkingResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object GetAllTheCurrentServicesAndTheirVehicles()
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var parkingResult = (from parking in context.ParkingService
                                         where parking.Estate.Equals(0)
                                         select new
                                         {
                                             parking.Id,
                                             parking.IdRate,
                                             Rate = new
                                             {
                                                 parking.Rates.Id,
                                                 parking.Rates.Rate,
                                                 parking.Rates.Description,
                                             },
                                             parking.IdVehicle,
                                             Vehicle = new
                                             {
                                                 parking.Vehicle.Id,
                                                 parking.Vehicle.VehicularPlate,
                                                 parking.Vehicle.Brand,
                                                 parking.Vehicle.Color,
                                                 parking.Vehicle.Driver,
                                                 parking.Vehicle.DriverIdentification,
                                                 parking.Vehicle.Phone,
                                             },
                                             parking.DateTimeEntry,
                                             parking.DateTimeExit,
                                             parking.ServicePrice,
                                             parking.Estate,
                                         }).ToList();

                    return parkingResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void PostParkingService(Model.ParkingService parkingServices)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    context.ParkingService.Add(parkingServices);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void PutParkingService(Model.ParkingService parkingServices)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    context.Entry(parkingServices).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteParkingService(int id)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var itemToRemove = context.ParkingService.SingleOrDefault(x => x.Id == id);
                    if (itemToRemove != null)
                    {
                        context.ParkingService.Remove(itemToRemove);
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
