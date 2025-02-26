using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    internal class Participant
    {
        private Address address;

        //Fields for participants name data
        private string firstName = "";
        private string lastName = "";

        /// <summary>
        /// Getter and Setter method for the address
        /// </summary>
        public Address Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the City
        /// Setter makes sure the value is not null or empty
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    firstName = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the City
        /// Setter makes sure the value is not null or empty
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    lastName = value;
            }
        }

        /// <summary>
        /// Method for participant fields
        /// </summary>
        public Participant()
        {
            this.address = new Address();
            this.firstName = string.Empty;
            this.lastName = string.Empty;
        }

        /// <summary>
        /// Initializes the participant fields with the provided values
        /// </summary>
        /// <param name="address"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Participant(Address address, string firstName, string lastName)
        {
            this.address = address;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        /// <summary>
        /// Method returns formatted string of participants information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string textOut = $"{lastName.ToUpper()}, {firstName, -35} {address.GetAddressLabel()}";

            return textOut;
        }

        /// <summary>
        /// Method for validating that the firstName, lastName and city fields are not empty 
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool ok = string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || address.Validate();
            return ok;
        }
    }
}
