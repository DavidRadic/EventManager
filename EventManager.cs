using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EventManager
    {
        ParticipantManager participantManager;

        //Fields for Event data
        private double costPerPerson = 0.0;
        private double feePerPerson = 0.0;
        private string title = "";


        /// <summary>
        /// Method for creating a new Participant Manager
        /// </summary>
        public EventManager()
        {
            participantManager = new ParticipantManager();

        }

        /// <summary>
        /// Getter method for the Participant Manager
        /// </summary>
        public ParticipantManager Participants
        {
            get
            {
                return participantManager; // Rätt referens
            }
        }

        /// <summary>
        /// Getter and Setter method for the Cost per person
        /// Setter makes sure the value is not less or equal to 0
        /// </summary>
        public double CostPerPerson
        {
            get
            {
                return costPerPerson;
            }
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the Fee per person
        /// Setter makes sure the value is not less or equal to 0
        /// </summary>
        public double FeePerPerson
        {
            get
            {
                return feePerPerson;
            }
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the Event title
        /// Setter makes sure the value is not null or empty
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
            }
        }

        /// <summary>
        /// Method for returning the total cost for the participants
        /// </summary>
        /// <returns></returns>
        public double CalcTotalCost()
        {
            return Participants.Count * costPerPerson;
        }

        /// <summary>
        /// Method for returning the total fees for the participants
        /// </summary>
        /// <returns></returns>
        public double CalcTotalFees()
        {
            return Participants.Count * feePerPerson;
        }

        /// <summary>
        /// Method for returning the total surplus/deficit
        /// </summary>
        /// <returns></returns>
        public double CalcSurplusDeficit()
        {
            return CalcTotalFees() - CalcTotalCost();
        }



    }
}
