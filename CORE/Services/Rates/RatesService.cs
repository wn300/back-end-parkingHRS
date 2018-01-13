using CORE.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Services.Rates
{
    public class RatesService
    {
        public static object GetAllRates()
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var vehicleResult = context.Rates.ToList();

                    return vehicleResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void PostRates(Model.Rates rate)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    context.Rates.Add(rate);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void PutRates(Model.Rates rate)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    context.Entry(rate).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteRate(int id)
        {
            try
            {
                using (var context = DBParkingHRSEntities.Instance)
                {
                    var itemToRemove = context.Rates.SingleOrDefault(x => x.Id == id);
                    if (itemToRemove != null)
                    {
                        context.Rates.Remove(itemToRemove);
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
