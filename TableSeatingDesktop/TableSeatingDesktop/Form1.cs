namespace TableSeatingDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
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

        
    }
}