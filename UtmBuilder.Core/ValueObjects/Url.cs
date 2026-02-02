using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        private const string UrlRegexPattern = @"^(http/https):(\/\/)?([a-z0-9]+[.])+[a-z]{2,}(:[0-9]{1,5})?(\/.*)?$";
        // <summary>
        // Create a new Url
        // </summary>
        // <param name="address">
        // Address of Url (Website link)
        // </param>
        public Url(string address)
        {
            Address = address;
            if (Regex.IsMatch(address, UrlRegexPattern))
                throw new Exception("Invalid Url");
        }
        // <summary>
        // Address of Url (Website link)
        // </summary>
        public string Address { get; }
    }
}