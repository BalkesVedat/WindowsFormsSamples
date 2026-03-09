using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class frmSiparis : Form
    {
        List<string> customerList = new List<string>();

        List<string> phoneList = new List<string>();

        List<string> addresList = new List<string>();

        List<string> pizzaTypeList = new List<string>();

        List<string> drinkList = new List<string>();

        List<string> listExtras = new List<string>();

        public frmSiparis()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }

        private void pnlMusteri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            customerList.Add("Muhammed Enes");
            customerList.Add("Esma");
            customerList.Add("Aleyna");

            phoneList.Add("12334");
            phoneList.Add("33333333");
            phoneList.Add("55555555");

            addresList.Add("Ataköy");
            addresList.Add("Bakırköy");
            addresList.Add("Soğanlı");

            pizzaTypeList.Add("Margarita");
            pizzaTypeList.Add("Milaneze");
            pizzaTypeList.Add("Eros");
            pizzaTypeList.Add("Vegan");

            drinkList.Add("İstemiyorum");
            drinkList.Add("Kola");
            drinkList.Add("Meyve Suyu");
            drinkList.Add("Ayran");
            drinkList.Add("Soğuk Çay");

            listExtras.Add("Sosis");
            listExtras.Add("Sucuk");
            listExtras.Add("Mısır");
            listExtras.Add("Cheddar");
            listExtras.Add("Çikolata");
            listExtras.Add("Ananas");
            listExtras.Add("Çilek");
            listExtras.Add("Mozarella");
            listExtras.Add("Ezine");
            listExtras.Add("Otlu Peynir");


            for (int i = 0; i < pizzaTypeList.Count; i++)
            {
                cmbPizzaType.Items.Add(pizzaTypeList[i]);
            }

            foreach (string item in customerList)
            {
                cmbSelectCustomer.Items.Add(item);
            }

            foreach (string item in drinkList)
            { 
                cmbDrinks.Items.Add(item);
            }

            cmbDrinks.SelectedIndex = 0;

            //chkListExtras.Items.Add();

            foreach (string item in listExtras)
            {
                chkListExtras.Items.Add(item);
            }

            chkListExtras.MultiColumn=true;
            chkListExtras.ColumnWidth = 75;




        }

        private void chkListExtras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {



        }

        private void cmbSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbSelectCustomer.SelectedIndex;

            //ComboBox cmb = (ComboBox)sender;
            //index = cmb.SelectedIndex;

            txtCustomerName.Text = customerList[index].ToString();
            txtPhone.Text = phoneList[index].ToString();
            txtAddress.Text = addresList[index].ToString();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pizzaType = cmbPizzaType.Text;

            string pizzaSize="";

            foreach (var item in gbSize.Controls)
            {
                if (item.GetType()==typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)item;
                    bool isChecked = rb.Checked;
                    if (isChecked)
                    {
                        pizzaSize = rb.Text;
                    }
                }

            }

           // MessageBox.Show(pizzaSize.ToString());

        }
    }
}
