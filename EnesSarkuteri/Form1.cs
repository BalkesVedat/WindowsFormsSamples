using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnesSarkuteri
{
    public partial class frmCustomer : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;User ID=sa;Password=1;");

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter;

        DataTable dt = new DataTable();

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindCountryDataSet.GetCountryList' table. You can move, or remove it, as needed.
            this.getCountryListTableAdapter.Fill(this.northwindCountryDataSet.GetCountryList);

            //cmbCountry.SelectedIndex = -1;
            cmbCountry.SelectedValue = "Türkiye";

            MusteriListesiniYukle();

        }

        private void MusteriListesiniYukle()
        {
           // cmd.CommandText = "Select * FROM Customers";
            cmd.CommandText = "SP_GetCustomerList";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(cmd);


            adapter.Fill(dt);

            dataGridCustomer.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Customers VALUES ('XYZ','XYZ Restoran','Ayşe Hanım', NULL, 'Bakırköy', 'İstanbul', NULL, NULL, 'Türkiye', '55555555', NULL)";

                cmd.Connection = conn;

                conn.Open();

                int adet = cmd.ExecuteNonQuery();

                conn.Close();

                if (adet > 0)
                {
                    MessageBox.Show("Kayıt Eklendi.");
                }
                else
                {
                    MessageBox.Show("Kayıt Eklenemedi.");
                }

                MusteriListesiniYukle();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir sorun oluştu."+ ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
