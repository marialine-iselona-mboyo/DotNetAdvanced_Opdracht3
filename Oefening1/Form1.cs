namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool isItDigit(String text)
        {
            foreach (char ch in text)
            {
                if (!(char.IsDigit(ch)))
                {
                    return false;
                }
            }
            return true;
        }




        Stapel<int> integers = new Stapel<int>();
        Stapel<string> strings = new Stapel<string>();




        private void btnAdd_Click(object sender, EventArgs e)
        {
            strings.Toevoegen(tbStrings.Text);
            labelStr.Text = strings.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (strings.ToString() != string.Empty)
            {
                strings.Verwijderen();
                MessageBox.Show(" Item has been deleted ");
            }
            else
            {
                MessageBox.Show(" It is already Empty ");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            strings.Leegmaken();
            MessageBox.Show(" List is being cleared ");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbStrings.Text))
            {
                MessageBox.Show("sorry maar " + tbStrings.Text + " bestaat niet op de stapel");
            }
            else
            {
                MessageBox.Show(tbStrings.Text + " " + "is aanwezig op de stapel van integers");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Stapel<string> copyStringList = new Stapel<string>();
            copyStringList = strings.listCopy();

            MessageBox.Show(" this is the old list: " + strings.ToString());
        }

        private void btnShowStr_Click(object sender, EventArgs e)
        {
            labelStr.Text = "Strings: " + strings.ToString();
        }








        private void btnAdd1_Click(object sender, EventArgs e)
        {
            integers.Toevoegen(int.Parse(tbIntegers.Text));
            labelInt.Text = integers.ToString();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (integers.ToString() != string.Empty)
            {
                integers.Verwijderen();
                MessageBox.Show(" Item has been deleted ");
            }
            else
            {
                MessageBox.Show(" It is already Empty ");
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            integers.Leegmaken();
            MessageBox.Show(" List is being cleared ");
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy1_Click(object sender, EventArgs e)
        {
            if (integers.isAanwezig(int.Parse(tbIntegers.Text)))
            {

                MessageBox.Show(tbIntegers.Text + " " + "is aanwezig op de stapel van integers");
            }
            else
            {
                MessageBox.Show("sorry maar " + tbIntegers.Text + " bestaat niet op de stapel");
            }

            tbIntegers.Text = null;
        }

        private void btnShowInt_Click(object sender, EventArgs e)
        {
            labelInt.Text = "Intergers: " + integers.ToString();
        }


    }
}