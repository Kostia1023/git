using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_var18_lab_3_Async
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (PersonContext db = new PersonContext())
            {
                persons = db.Persons.AsParallel().ToList<Person>();
            }
            dataGridView1.DataSource = persons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (PersonContext db = new PersonContext())
            {
                persons = db.Persons.AsParallel().ToList<Person>();
            }
            dataGridView1.DataSource = persons;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (PersonContext db = new PersonContext())
            {
                persons = db.Persons.AsParallel()
                    .Where((person) => person.Gender == "male")
                    .ToList<Person>();
            }
            dataGridView1.DataSource = persons;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (PersonContext db = new PersonContext())
            {
                persons = db.Persons.AsParallel().Where((person) => person.Gender == "male")
               .OrderBy((person) => person.YearBirth)
               .Take(1)
               .ToList<Person>();
            }
            dataGridView1.DataSource = persons;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (PersonContext db = new PersonContext())
            {
                var listGroup = db.Persons.AsParallel().GroupBy(person => person.Gender);

                dataGridView1.DataSource = null;

                dataGridView1.Columns.Add("column1", null);
                dataGridView1.Columns.Add("column2", null);
                foreach (var group in listGroup)
                {
                    dataGridView1.Rows.Add(group.Key, group.Count());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (PersonContext db = new PersonContext())
            {
                persons = db.Persons.AsParallel().ToList<Person>();
                persons.ForEach(person => person.YearBirth += 18);
            }
            dataGridView1.DataSource = persons;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (PersonContext db = new PersonContext())
            {
                persons = db.Persons.AsParallel().OrderBy(person => person.YearBirth)
                .Skip(1)
                .ToList<Person>();
            }
            dataGridView1.DataSource = persons;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (PersonContext db = new PersonContext())
            {
                MessageBox.Show($"All female: {db.Persons.AsParallel().All(person => person.Gender == "female")}");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (PersonContext db = new PersonContext())
            {
                MessageBox.Show($"Any male: {db.Persons.AsParallel().Any(person => person.Gender == "male")}");
            }

        }
    }
}
