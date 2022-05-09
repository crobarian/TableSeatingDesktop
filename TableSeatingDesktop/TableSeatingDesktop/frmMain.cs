namespace TableSeatingDesktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            numTables.Value = 0;
            numSeats.Value = 0;
            CalculateSeats();
        }

        private void numTables_ValueChanged(object sender, EventArgs e)
        {
            CalculateSeats();
        }

        private void numSeats_ValueChanged(object sender, EventArgs e)
        {
            CalculateSeats();
        }


        private void CalculateSeats()
        {
            int locTotalSeats = (int)(numTables.Value * numSeats.Value);

            lblTotalSeats.Text = locTotalSeats.ToString();
        }

        private void btnAddAttendee_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveAttendee_Click(object sender, EventArgs e)
        {
            if (listAttendees.SelectedItems.Count > 0)
            {
                DialogResult diagResult = ShowMessage("Are you sure you wish to remove the Attendee(s)?", "Remove Attendees", false, true);

                if (diagResult == DialogResult.OK)
                {

                }
            } else
            {
                ShowMessage("Please select 1 or more Attendees to remove.", "Remove Attendees", true, false);
            }
        }


        private DialogResult ShowMessage(string caption, string message, bool isError = false, bool isQuery = false)
        {
            if (isError)
            {
                return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (isQuery)
            {
                return MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            } else
            {
                return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}