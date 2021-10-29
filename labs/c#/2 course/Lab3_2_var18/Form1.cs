using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab3_2_var18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c#\git\labs\c#\2 course\Lab3_2_var18\MyBD.mdf;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM Persons",
                con
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM Persons",
                con
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getList = new SqlCommand(
                "SELECT * FROM Persons WHERE Gender = @Gender",
                con
                );
            getList.Parameters.AddWithValue("Gender", "male");
            SqlDataAdapter adapt = new SqlDataAdapter(getList);
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getList = new SqlCommand(
                "SELECT TOP(1) * FROM Persons ORDER BY YearBirth",
                con
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getList);
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getList = new SqlCommand(
                "SELECT Gender, COUNT(Gender) FROM Persons GROUP BY Gender",
                con
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getList);
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand ChangeList = new SqlCommand(
                "UPDATE Persons SET YearBirth = YearBirth + 18",
                con
                );
            SqlCommand getList = new SqlCommand(
              "SELECT * FROM Persons ",
              con
              );
            SqlDataAdapter adaptGet = new SqlDataAdapter(getList);
            ChangeList.ExecuteNonQuery();
            adaptGet.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand ChangeList = new SqlCommand(
                "WITH MyBD AS (" +
                "SELECT TOP(1) * FROM Persons ORDER BY YearBirth)" +
                "DELETE FROM MyBD",
                con
                );
            SqlCommand getList = new SqlCommand(
              "SELECT * FROM Persons ",
              con
              );
            SqlDataAdapter adaptGet = new SqlDataAdapter(getList);
            ChangeList.ExecuteNonQuery();
            adaptGet.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getFilter = new SqlCommand(
                "SELECT Gender FROM Persons WHERE Gender = @Gender",
                con
                );
            getFilter.Parameters.AddWithValue("Gender", "female");
            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM Persons",
                con
                );
            SqlDataAdapter adaptFilter = new SqlDataAdapter(getFilter);
            SqlDataAdapter adaptAll = new SqlDataAdapter(getAll);

            con.Open();
            adaptFilter.Fill(dt);
            adaptAll.Fill(dt1);
            MessageBox.Show($"All female: {dt.Rows.Count == dt1.Rows.Count}");
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getFilter = new SqlCommand(
                "SELECT Gender FROM Persons WHERE Gender = @Gender",
                con
                );
            getFilter.Parameters.AddWithValue("Gender", "female");
            SqlDataAdapter adaptFilter = new SqlDataAdapter(getFilter);

            con.Open();
            adaptFilter.Fill(dt);
            MessageBox.Show($"Any female: {dt.Rows.Count > 0}");
            con.Close();

        }
    }
}
