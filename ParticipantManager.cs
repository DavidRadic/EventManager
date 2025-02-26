using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ParticipantManager
    {
        private List<Participant> participantList;

        /// <summary>
        /// Method for creating a participant list
        /// </summary>
        public ParticipantManager()
        {
            participantList = new List<Participant>();

        }

        /// <summary>
        /// Getter method for counting the number of participants in the list
        /// </summary>
        public int Count
        {
            get
            {
                return participantList.Count;
            }
        }

        /// <summary>
        /// Method for adding a participant to the list
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        public bool AddParticipant(Participant participant)
        {
            bool ok = true;

            if (participant != null)
            {
                participantList.Add(participant);
            }
            else
            {
                ok = false;
            }
            return ok;

        }

        /// <summary>
        /// Method for changing a partcipants information in the list 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="participant"></param>
        /// <returns></returns>
        public bool ChangeParticipantAt(int index, Participant participant)
        {
            bool ok = true;
            if ((participant != null) && CheckIndex(index))
            {
                participantList[index] = participant;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Method for deleting a participant from the list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteParticipantAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                participantList.RemoveAt(index);
                return true;
            }
            return ok;
        }

        /// <summary>
        /// Method for getting a participant from the list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Participant GetParticipantAt(int index)
        {
            if (CheckIndex(index))
            {
                return participantList[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method for checking index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>

        private bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < participantList.Count);
            return ok;
        }

        /// <summary>
        /// Method for getting the participant information in a string
        /// </summary>
        /// <returns></returns>

        public string[] GetParticipantListInfoString()
        {
            string[] infoStrings = new string[participantList.Count];

            for (int i = 0; i < participantList.Count; i++)
            {
                infoStrings[i] = participantList[i].ToString();
            }
            return infoStrings;
        }

    }
}
