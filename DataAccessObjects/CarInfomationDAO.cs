using BusinessObjects;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CarInfomationDAO:BaseDAO<CarInformation>
    {
        public Option<List<CarInformation>> SearchCarByName(string name)
        {
            var result = from car in _context.Entity
                         where car.CarName.Contains(name)
                         select car;
            return result != null ? Option<List<CarInformation>>.Some((List<CarInformation>)result) : Option<List<CarInformation>>.None;
        }
    }
}
