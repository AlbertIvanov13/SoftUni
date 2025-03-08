using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Calling(string phoneNumber)
        {
            if (!phoneNumber.Any(d => char.IsDigit(d)))
            {
                return "Invalid number!";
            }

            return $"Dialing... {phoneNumber}";
        }
    }
}