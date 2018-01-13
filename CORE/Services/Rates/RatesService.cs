using CORE.Model;
using System;
using System.Collections.Generic;
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
    }
}
