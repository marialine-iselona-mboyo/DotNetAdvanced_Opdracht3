namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stapel<int> integers = new Stapel<int>();
        Stapel<string> strings = new Stapel<string>();


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (integers.ToString() != string.Empty)
            {
                integers.Verwijderen();
            } else
            {
                MessageBox.Show(" It is already Empty ");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            integers.Leegmaken();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}