using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Address
    {
        //Fields for Address data
        private string city = "";
        private string street = "";
        private string zipCode = "";

        private Countries country = Countries.United_Kingdom;

        /// <summary>
        /// Getter and Setter method for the City
        /// Setter makes sure the value is not null or empty
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                    city = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the Street
        /// Setter makes sure the value is not null or empty
        /// </summary>
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    street = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the ZipCode
        /// Setter makes sure the value is not null or empty
        /// </summary>
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    zipCode = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the Country
        /// </summary>
        public Countries Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        /// <summary>
        /// Method for address fields
        /// </summary>
        public Address()
        {
            city = string.Empty;
            street = string.Empty;
            zipCode = string.Empty;
            country = Countries.United_Kingdom;
        }

        /// <summary>
        /// Initializes the adress fields with the provided values
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zip;
            this.city = city;
            this.country = country;
        }

        /// <summary>
        /// Method returns formatted string of address
        /// </summary>
        /// <returns></returns>
        public string GetAddressLabel()
        {
            string textOut =  $"{street, -35}  {city, -15} {zipCode, -15} {country, -15}";

            return textOut;
        }



        
        /// <summary>
        /// Method for validating that the city field is not empty 
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            // Ensure city is not null or empty
            bool ok = string.IsNullOrEmpty(city); 
            return ok;
        }
    }
}
