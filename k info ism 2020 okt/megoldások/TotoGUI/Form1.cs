//9. feladat: K�sz�tsen grafikus alkalmaz�st, amelynek a projektj�t TotoGUI n�ven mentse el!
namespace TotoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
            int size = resultTextBox.Text.Length;
            if (size != 14) 
            {
                lengthCheckBox.Checked = true;
            }
            else
            {
                lengthCheckBox.Checked = false;
                
            }
            lengthCheckBox.Text = "Nem megfelelo a karakterek sz�ma (" + size.ToString() + ")";

            string wrong = "";
            string result = resultTextBox.Text;
            int faulty = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '1' || result[i] == '2' || result[i] == 'X')
                {
                    wrong += " ;";
                }
                else
                {
                    wrong += result[i] + ";";
                    faulty++;
                }
            }
            if (faulty > 0)
            {
                incorrectCheckBox.Text = "Helytelen karakter az eredm�nyekben (" + wrong + ")";
                incorrectCheckBox.Checked = true;
            }
            else
            {
                incorrectCheckBox.Text = "Helytelen karakter az eredm�nyekben ()";
                incorrectCheckBox.Checked = false;
            }
            if (!lengthCheckBox.Checked && !incorrectCheckBox.Checked)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
    }
}
