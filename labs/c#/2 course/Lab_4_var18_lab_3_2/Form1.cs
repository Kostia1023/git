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

namespace Lab_4_var18_lab_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c#\test_entity_fram\FirstDB.mdf;Integrated Security=True;Connect Timeout=30";

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

        private void Button1_Click(object sender, EventArgs e)
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

        private async void Button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getList = new SqlCommand(
                "SELECT * FROM Persons WHERE Gender = @Gender",
                con
                );
            getList.Parameters.AddWithValue("Gender", "male");
            SqlDataAdapter adapt = await Task.Run(() => new SqlDataAdapter(getList));
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;

        }

        private async void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getList = new SqlCommand(
                "SELECT TOP(1) * FROM Persons ORDER BY YearBirth",
                con
                );
            SqlDataAdapter adapt = await Task.Run(() => new SqlDataAdapter(getList));
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getList = new SqlCommand(
                "SELECT Gender, COUNT(Gender) FROM Persons GROUP BY Gender",
                con
                );
            SqlDataAdapter adapt = await Task.Run(() => new SqlDataAdapter(getList));
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private async void button5_Click(object sender, EventArgs e)
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
            SqlDataAdapter adaptGet = await Task.Run(() => new SqlDataAdapter(getList));
            ChangeList.ExecuteNonQuery();
            adaptGet.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private async void button6_Click(object sender, EventArgs e)
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
            SqlDataAdapter adaptGet = await Task.Run(() => new SqlDataAdapter(getList));
            ChangeList.ExecuteNonQuery();
            adaptGet.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private async void button7_Click(object sender, EventArgs e)
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
            SqlDataAdapter adaptFilter = await Task.Run(() => new SqlDataAdapter(getFilter));
            SqlDataAdapter adaptAll = await Task.Run(() => new SqlDataAdapter(getAll));

            con.Open();
            adaptFilter.Fill(dt);
            adaptAll.Fill(dt1);
            MessageBox.Show($"All female: {dt.Rows.Count == dt1.Rows.Count}");
            con.Close();
        }

        private async void button9_Click(object sender, EventArgs e)
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
            SqlDataAdapter adaptFilter = await Task.Run(() => new SqlDataAdapter(getFilter));
            con.Open();
            adaptFilter.Fill(dt);
            MessageBox.Show($"Any female: {dt.Rows.Count > 0}");
            con.Close();

        }
    }
}
