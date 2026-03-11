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
using static System.Windows.Forms.CheckedListBox;


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

            chkListExtras.MultiColumn = true;
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
            double basePrice = 150;
            double totalPrice = 0;
            double sizePrice = 0;
            double extraPrice = 0;
            double extraUnitPrice = 20;
            double drinkPrice = 0;
            double drinkAdd = 30;

            //1 - Pizza Tipi seçimi
            string pizzaType = cmbPizzaType.Text;

            string pizzaSize = "";

            //2 - Pizza Boyutu Seçimi
            foreach (var item in gbSize.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)item;
                    bool isChecked = rb.Checked;
                    if (isChecked)
                    {
                        pizzaSize = rb.Text;
                    }
                }
            }

            switch (pizzaSize)
            {
                case "Küçük":
                    sizePrice = 0;
                    break;
                case "Orta":
                    sizePrice = 20;
                    break;
                case "Büyük":
                    sizePrice = 30;
                    break;
                default:
                    break;
            }


            //3 - Extra malzeme seçimi

            CheckedItemCollection list = chkListExtras.CheckedItems;

            int numberOfExtras = list.Count;

            extraPrice = extraUnitPrice * numberOfExtras;

            //4 - İçecek Seçimi

            string drink = cmbDrinks.Text;
            bool isDrinkSelected = false;

            if (drink != "İstemiyorum")
            {
                isDrinkSelected = true;
                drinkPrice = drinkAdd;
            }
            else
            {
                isDrinkSelected = false;
                drinkPrice = 0;
            }


                //5 - Ödeme Tipi Seçimi
                string paymentType = "";

            foreach (Control item in grpPaymentType.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)item;

                    if (rb.Checked)
                    {
                        paymentType = rb.Text;
                    }
                }
            }

            // 6 - Masa Seçimi 

            string selectedTable = "";

            foreach (Control item in grpTables.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)item;

                    if (rb.Checked)
                    {
                        selectedTable = rb.Text;
                    }
                }
            }

            if (selectedTable.Length == 0)
            {
                MessageBox.Show("Masa Seçilmemiş, Önce masa seçmelisiniz.");
                return;
            }

            totalPrice = basePrice + sizePrice + extraPrice + drinkPrice;

            string orderDetail = "";

            string strExtra = "";

            foreach (string item in list)
            {
                strExtra += item.ToString() + "/";
            }

            orderDetail += pizzaType + " - ";
            orderDetail += pizzaSize + " - ";
            orderDetail += strExtra + " - ";
            orderDetail += drink + " - ";
            orderDetail += paymentType + " - ";
            orderDetail += selectedTable + " - ";
            orderDetail += totalPrice + " - ";
            orderDetail += txtCustomerName.Text ;

            lbOrders.Items.Add(orderDetail);

            MessageBox.Show("Sipariş Kaydedildi.");
            //TODO:Formu temizleyen kodu yazın.

            // MessageBox.Show(pizzaSize.ToString());

        }
    }
}
