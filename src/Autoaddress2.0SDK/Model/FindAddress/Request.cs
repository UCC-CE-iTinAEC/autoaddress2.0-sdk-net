﻿namespace Autoaddress.Autoaddress2_0.Model.FindAddress
{
    /// <summary>
    /// Container for parameters of FindAddress
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Request"/> class.
        /// </summary>
        /// <param name="address">Address or postcode to find.</param>
        /// <param name="language">Language for returned address.</param>
        /// <param name="country">Country the address should be searched in.</param>
        /// <param name="limit">An upper limit on the number of options that may be returned.</param>
        /// <param name="isVanityMode">Return vanity address format, if it exists.</param>
        /// <param name="addressProfileName">If supplied, a reformatted address (according to profile rules) is returned in the ReformattedAddress field.</param>
        public Request(string address, Language language, Country country,
                       int limit, bool isVanityMode, string addressProfileName)
        {
            Address = address;
            Language = language;
            Country = country;
            Limit = limit;
            IsVanityMode = isVanityMode;
            AddressProfileName = addressProfileName;
        }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public string Address { get; private set; }
        
        /// <summary>
        /// Gets the language.
        /// </summary>
        public Language Language { get; private set; }
        
        /// <summary>
        /// Gets the country.
        /// </summary>
        public Country Country { get; private set; }
        
        /// <summary>
        /// Gets the limit.
        /// </summary>
        public int Limit { get; private set; }
        
        /// <summary>
        /// Gets IsVanityMode.
        /// </summary>
        
        public bool IsVanityMode { get; private set; }
        
        /// <summary>
        /// Gets the address profile name.
        /// </summary>
        public string AddressProfileName { get; private set; }
    }
}