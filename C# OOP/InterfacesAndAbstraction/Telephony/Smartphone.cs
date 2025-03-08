using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Calling(string phoneNumber)
        {
            if (!phoneNumber.All(d => char.IsDigit(d)))
            {
                return "Invalid number!";
            }

            return $"Calling... {phoneNumber}";
        }
        public string Browsing(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }
    }
}