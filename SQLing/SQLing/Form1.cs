using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLing
{
    public partial class frmPeopleDatabase : Form
    {
        public frmPeopleDatabase()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Go to properties of db and copy and paste connectionString value
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"PATH_TO_DB";Integrated Security=True;Connect Timeout=30";


            SqlConnection sqlConnection = new SqlConnection(connectionString);



            //Use stored procedure

            SqlCommand command = new SqlCommand("CreateNewPersonRecord", sqlConnection);


            command.CommandType = CommandType.StoredProcedure;


            //Input name and age from form

            string name = txtName.Text;

            int age = int.Parse(txtAge.Text);


            //Call stored procedure passing name and age as parameters

            command.Parameters.AddWithValue("@Name", name);

            command.Parameters.AddWithValue("@Age", age);



            //Open connection to database, execute stored procedure and close the connection

            sqlConnection.Open();



            command.ExecuteNonQuery();


            sqlConnection.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Read a person record

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\m2404024\\OneDrive - Middlesbrough College\\YR2\\Trevor\\Programing\\SQLing\\SQLing\\PeopleDB.mdf\";Integrated Security=True;Connect Timeout=30";



            SqlConnection sqlConnection = new SqlConnection(connectionString);


            SqlCommand cmd = new SqlCommand("GetPersonDetails", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();


            sqlConnection.Open();

            sd.Fill(dt);

            sqlConnection.Close();


            //Read rows of database and extract fields

            txtPeople.Text = string.Empty;

            foreach (DataRow dr in dt.Rows)

            {

                int personId = (int)(dr["Id"]);

                string personName = (string)(dr["Name"]);

                int personAge = (int)(dr["Age"]);


                txtPeople.AppendText(personId.ToString() + "\t" + personName + "\t" + personAge.ToString() + Environment.NewLine);



            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Use stored procedure to delete record(s) containing a given name


            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\m2404024\\OneDrive - Middlesbrough College\\YR2\\Trevor\\Programing\\SQLing\\SQLing\\PeopleDB.mdf\";Integrated Security=True;Connect Timeout=30";


            SqlConnection sqlConnection = new SqlConnection(connectionString);



            //USE STORED PROCEDURE

            SqlCommand command = new SqlCommand("DeletePerson", sqlConnection);


            command.CommandType = CommandType.StoredProcedure;


            string name = txtName.Text;
            string id = txtID.Text;

            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Id", id);


            sqlConnection.Open();



            command.ExecuteNonQuery();


            sqlConnection.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\m2404024\\OneDrive - Middlesbrough College\\YR2\\Trevor\\Programing\\SQLing\\SQLing\\PeopleDB.mdf\";Integrated Security=True;Connect Timeout=30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);



            //USE STORED PROCEDURE

            SqlCommand command = new SqlCommand("UpdatePerson", sqlConnection);


            command.CommandType = CommandType.StoredProcedure;


            string name = txtName.Text;

            int age = int.Parse(txtAge.Text);

            string Id = txtID.Text;

            command.Parameters.AddWithValue("@Id", Id);

            command.Parameters.AddWithValue("@Name", name);

            command.Parameters.AddWithValue("@Age", age);


            sqlConnection.Open();



            command.ExecuteNonQuery();


            sqlConnection.Close();
        }
    }
}

