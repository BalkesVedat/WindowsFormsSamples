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
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(cmd);

            dt.Clear();
            adapter.Fill(dt);

            dataGridCustomer.DataSource = dt;
        }

        private string ClearContent(string text)
        {
            if (text == string.Empty)
            {
                return "";
            }

            text = text.Trim();
            text = text.ToUpper();
            text = text.Replace("\r", "");
            text = text.Replace("\n", "");
            text = text.Replace("\r\n", "");
            text = text.Replace("'", "");
            text = text.Replace("\t", "");
            text = text.Replace("DROP", "DROP_");
            text = text.Replace("EXECUTE", "EXECUTE_");
            text = text.Replace("SELECT", "SELECT_");
            text = text.Replace("=", "");
            text = text.Replace("INSERT", "INSERT_");
            text = text.Replace("UPDATE", "UPDATE_");
            text = text.Replace("CREATE", "CREATE_");
            text = text.Replace("ALTER", "ALTER_");
            text = text.Replace("GRANT", "GRANT_");
            text = text.Replace("DENY", "DENY_");
            text = text.Replace("\"", "");
            text = text.Replace(",", "");

            return text;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text == "" || txtCompany.Text == "")
                {
                    MessageBox.Show("Zorunlu alanlar boş geçilemez.");
                    return;
                }

                string CustomerID = ClearContent(txtCustomerID.Text);
                string CompanyName = ClearContent(txtCompany.Text);
                string ContactPerson = ClearContent(txtContact.Text);
                string Address = ClearContent(txtAddress.Text);
                string Country = ClearContent(cmbCountry.SelectedText);
                string Phone = ClearContent(txtPhone.Text);


                cmd.CommandText = "INSERT INTO Customers VALUES (@CustomerID, @CompanyName, @ContactPerson, NULL, @Address, NULL, NULL, NULL, @Country, @Phone, NULL)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                cmd.Parameters.AddWithValue("@ContactPerson", ContactPerson);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Country", Country);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Connection = conn;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int adet = cmd.ExecuteNonQuery();

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }

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
                MessageBox.Show("Bir sorun oluştu." + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridCustomer.Rows[e.RowIndex];

            selectedRow.Selected = true;
           // dataGridCustomer.Rows[e.RowIndex].Selected = true;

            txtCustomerID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
            txtCompany.Text = selectedRow.Cells["CompanyName"].Value.ToString();
            txtContact.Text = selectedRow.Cells["ContactName"].Value.ToString();
            txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
            cmbCountry.Text = selectedRow.Cells["Country"].Value.ToString();
            txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();


        }
    }
}
