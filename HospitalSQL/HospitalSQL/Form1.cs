using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HospitalSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadList()
        {

            // Connection string to refer to database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"PATH_TO_DB\";Integrated Security=True;Connect Timeout=30";

            // Establishes a connection
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Gets the procedure we will be using
            // GetPatientDetail --> Returns everything in the Patients table
            SqlCommand cmd = new SqlCommand("GetPatientDetails", sqlConnection);

            // Tells what type of command we will be using
            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // Creates a table 
            DataTable dt = new DataTable();

            // Opens the connection 
            sqlConnection.Open();

            adapter.Fill(dt);

            // Closes a connection important when another function wants to open a connection
            sqlConnection.Close();

            // Empty the list so the text doesn't pile ontop of old data
            txtList.Text = string.Empty;

            // go through each element in table 
            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr["ID"];

                string firstName = ((string)dr["First_Name"]).Trim();

                string lastName = ((string)dr["Last_Name"]).Trim();


                txtList.AppendText($"{id.ToString()}: {firstName} {lastName}{Environment.NewLine}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
        }


        // Reads the ID and output details
        private void btnRead_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"PATH_TO_DB\";Integrated Security=True;Connect Timeout=30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // FindAndGetPatient --> Searches the patient by id and return all information about them
            SqlCommand cmd = new SqlCommand("FindAndGetPatient", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            string id = txtId.Text;

            // Assigns the variables with a value
            cmd.Parameters.AddWithValue("Id", id);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            adapter.Fill(dt);

            sqlConnection.Close();

            // Asign information to variables
            // As IDs are unique, no need for looping

            DataRow dr = dt.Rows[0];

            string firstName = ((string)dr["First_Name"]).Trim();
            string lastName = ((string)dr["Last_Name"]).Trim();

            string DOB = dr["DOB"].ToString().Split(' ')[0];
            string address = ((string)dr["Address"]).Trim();

            string tel = ((string)dr["Tel"]).Trim();
            string email = ((string)dr["Email"]).Trim();


            // Assign to textboxes

            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;

            txtDOB.Text = DOB;
            txtAddress.Text = address;

            txtPhone.Text = tel;
            txtEmail.Text = email;

        }

        // Updates the ID entered
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"PATH_TO_DB\";Integrated Security=True;Connect Timeout=30";

            // Get the Input from boxes
            string id = txtId.Text;

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            string DOB = txtDOB.Text;
            string address = txtAddress.Text;

            string tel = txtPhone.Text;
            string email = txtEmail.Text;


            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // UpdatePaitient --> Gets paitient ID and updates the values in the DB
            SqlCommand cmd = new SqlCommand("UpdatePaitient", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;


            // Assigns the variables with a value
            cmd.Parameters.AddWithValue("Id", id);

            cmd.Parameters.AddWithValue("FirstName", firstName);
            cmd.Parameters.AddWithValue("LastName", lastName);

            cmd.Parameters.AddWithValue("DOB", DOB);
            cmd.Parameters.AddWithValue("Address", address);

            cmd.Parameters.AddWithValue("Tel", tel);
            cmd.Parameters.AddWithValue("Email", email);


            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"PATH_TO_DB\";Integrated Security=True;Connect Timeout=30";

            // Get the Input from boxes
            string id = txtId.Text;


            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //  --> Gets paitient ID and updates the values in the DB
            SqlCommand cmd = new SqlCommand("DeletePaitient", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("Id", id);


            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            LoadList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
