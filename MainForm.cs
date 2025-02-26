using System;

namespace EventManager
{
    public partial class MainForm : Form
    {
        private EventManager eventManager;
        
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Activating creating new event box
            grpBoxNewEvent.Enabled = true;

            // Deactivating adding new participant box
            grpBoxAddParticipant.Enabled = false;

            txtEventTitle.Text = string.Empty;
            txtCostPerParticipant.Text = "0.0";
            txtFeePerParticipant.Text = "0.0";

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            txtCity.Text = string.Empty;
            cmbCountry.DataSource = Enum.GetNames(typeof(Countries));


            lstAllParticipants.Items.Clear();
        }

        /// <summary>
        /// Button click handler for creating a new event list, informs the user if it is created successfully.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            bool ok = CreateEvent();
            if (ok)
            {
                MessageBox.Show("Event created successfully!", "Success");
            }
        }

        /// <summary>
        /// Method for creating a new Event
        /// When the user creates a new event the Event box is automatically disabled and Participant information is enabled.
        /// </summary>
        /// <returns></returns>
        public bool CreateEvent()
        {
            if (!ReadEventInput())
            {
                return false;
            }

            eventManager = new EventManager
            {
                Title = txtEventTitle.Text,
                CostPerPerson = Convert.ToDouble(txtCostPerParticipant.Text),
                FeePerPerson = Convert.ToDouble(txtFeePerParticipant.Text)
            };

            grpBoxAddParticipant.Enabled = true;
            grpBoxNewEvent.Enabled = false;

            return true;
        }

        /// <summary>
        /// Method reads and validates the event inputs
        /// </summary>
        /// <returns></returns>
        public bool ReadEventInput()
        {
            bool ok = ReadTitleInput();
            ok = ok && ReadCostPerPerson();
            ok = ok && ReadFeePerPerson();

            return ok; 
        }

        /// <summary>
        /// Method reads the input of Event title and validates if the input is correct
        /// </summary>
        public bool ReadTitleInput()
        {
            //Changes the name of the MainForm after the Event input
            string title = txtEventTitle.Text;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Event title cannot be empty!", "Error");
                return false;
            }

            // Renames the MainForm name with the created events name + by programmers name
            this.Text = title + " By <David Radic>";
            return true;
        }

        /// <summary>
        /// Method reads the input of Cost Per Person and validates if the input is correct
        /// </summary>
        public bool ReadCostPerPerson()
        {
            if (double.TryParse(txtCostPerParticipant.Text, out double costPerPerson) && costPerPerson >= 0)
            {
                if (eventManager != null)
                    eventManager.CostPerPerson = costPerPerson;

                return true;
            }
            else
            {
                MessageBox.Show("Invalid cost per participant!", "Error");
                return false;
            }
        }

        /// <summary>
        /// Method reads the input of Fee Per Person and validates if the input is correct
        /// </summary>
        public bool ReadFeePerPerson()
        {
            if (double.TryParse(txtFeePerParticipant.Text, out double feePerPerson) && feePerPerson >= 0)
            {
                if (eventManager != null)
                    eventManager.FeePerPerson = feePerPerson;

                return true;
            }
            else
            {
                MessageBox.Show("Invalid fee!", "Error");
                return false;
            }
        }

        /// <summary>
        /// Button click handler for adding participants, clearing textboxes after adding and updating the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool ok = ReadParticipantData(out Participant participant);
            if (ok)
            {
                eventManager.Participants.AddParticipant(participant);
                ClearParticipantFields();
                UpdateGUI();


                participant = new Participant();
            }
            else
            {
                MessageBox.Show("Failed to add participant!", "Error");
            }


        }

        /// <summary>
        /// Method for reading participant data and a MessageBox to inform the user if they have not entered the required fields.
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        private bool ReadParticipantData(out Participant participant)
        {
            participant = null;

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string street = txtStreet.Text.Trim();
            string zipCode = txtZipCode.Text.Trim();
            string city = txtCity.Text.Trim();
            Countries country = Countries.United_Kingdom;

            bool isValidCountry = Enum.TryParse(cmbCountry.SelectedItem?.ToString(), out country);

            //Prevents the program from crashing if the user has written something else in the Country field.
            if (!isValidCountry)
            {
                MessageBox.Show("Select a valid country.", "Error");
                return false;
            }

            Address address = new Address(street, zipCode, city, country);

            participant = new Participant(address, firstName, lastName);

            // Validate the participant with the required fields 
            if (participant.Validate())
            {
                MessageBox.Show("First Name, Last Name, and City are required fields!", "Error");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Method for clearing the textboxes related to the participants information.
        /// </summary>
        private void ClearParticipantFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            txtCity.Text = string.Empty;
            cmbCountry.SelectedIndex = 0;
        }

        /// <summary>
        /// Method for updating the GUI to get the current participant list
        /// </summary>
        private void UpdateGUI()
        {
            lstAllParticipants.Items.Clear();

            string[] infoStrings = eventManager.Participants.GetParticipantListInfoString();

            if (infoStrings != null)
            {
                lstAllParticipants.Items.AddRange(infoStrings);
            }

            UpdateSummary();

        }

        /// <summary>
        /// Method for updating the Summary with:
        /// 1. The total number of participants added.
        /// 2. The total cost.
        /// 3. The total fees.
        /// 4. The Surplus/Deficit 
        /// </summary>
        private void UpdateSummary()
        {
            if (eventManager != null)
            {
                lblNumOfParticipants.Text = eventManager.Participants.Count.ToString();
                lblTotalCost.Text = eventManager.CalcTotalCost().ToString("F2");
                lblTotalFees.Text = eventManager.CalcTotalFees().ToString("F2");
                lblSurplusDeficit.Text = (eventManager.CalcSurplusDeficit()).ToString("F2");
            }
            else
            {
                lblNumOfParticipants.Text = "0";
                lblTotalCost.Text = "0.00";
                lblTotalFees.Text = "0.00";
                lblSurplusDeficit.Text = "0.00";
            }
        }

        /// <summary>
        /// Method for editing participants that are in the list, if a slot is not selected it notifies the user to pick a slot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lstAllParticipants.SelectedIndex;

            if (index >= 0)
            {
                bool ok = ReadParticipantData(out Participant participant);

                if (ok)
                {
                    eventManager.Participants.ChangeParticipantAt(index, participant);

                    ClearParticipantFields();
                    UpdateGUI();
                    participant = new Participant();
                }
            }
            else
            {
                MessageBox.Show("Select a participant first!", "Error");
            }
        }

        /// <summary>
        /// Updates the GUI with the curent participant list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAllParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstAllParticipants.SelectedIndex;
            if (index >= 0)
            {
                Participant participant = eventManager.Participants.GetParticipantAt(index);
                if (participant != null)
                {
                    txtFirstName.Text = participant.FirstName;
                    txtLastName.Text = participant.LastName;
                    txtStreet.Text = participant.Address.Street;
                    txtZipCode.Text = participant.Address.ZipCode;
                    txtCity.Text = participant.Address.City;
                    cmbCountry.SelectedItem = participant.Address.Country.ToString();
                }
            }
            else
            {
                MessageBox.Show("Select a participant first!", "Error");
            }
        }

        /// <summary>
        /// Method for deleting a participant that is in the list, if a slot is not selected it notifies the user to pick a slot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstAllParticipants.SelectedIndex;

            if (index >= 0)
            {
                eventManager.Participants.DeleteParticipantAt(index);
                ClearParticipantFields();
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Select a participant first!", "Error");
            }
        }
    }
}
