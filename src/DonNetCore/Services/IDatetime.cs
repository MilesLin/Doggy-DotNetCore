using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonNetCore.Services
{
    public interface IDatetime
    {
        DateTime Now();
    }

    public class SystemDatetime : IDatetime
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
