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

namespace SportApplikation
{
    public partial class frm_AddTeam : Form
    {
        public frm_AddTeam()
        {
            InitializeComponent();
        }

        // Method to store the data of "Lag" and "SportID" by dataGridView1_CellContentClick
        // in the database when the "Spara" button is clicked.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Assuming you have a method to save the data to your database
            // This is where you would implement the logic to save the data
            // from the DataGridView to your database.
            {
                string connectionString = "Connection_String";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Add data of "Lag" to the database
                        if (!row.IsNewRow) // Skip the new row placeholder
                        {
                            string query = "INSERT INTO tbl_Lag (Lag, SportID) VALUES (@lag, @sportid)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@lag", row.Cells["Lag"].Value ?? DBNull.Value);
                                command.Parameters.AddWithValue("@sportid", row.Cells["SportID"].Value ?? DBNull.Value);
                                command.ExecuteNonQuery();
                            }
                        }

                        
                    }

                    MessageBox.Show("Data saved successfully!");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // dataGridView to display "Lag" and "SportID" that will be stored
            // in the database when the "Spara" button is clicked.
            // Let the user add teams ("Lag") and sport encoded by "SportID" to the database.
            // "SportID" for "Basket" is "1", for soccer ("Fotboll") is "2", and
            // for hockey ("Ishockey") is "3".
            // start by cleaning the DataGridView
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Rows.Clear();
            }
            // Add a new row to the DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Assuming the first column is for "Lag"
            {
                string lag = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                string sportId = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(lag) && !string.IsNullOrEmpty(sportId))
                {
                    // Ssave the team and sport ID to the database
                    // Call of method to save the data to your database.
                    MessageBox.Show($"Team: {lag}, SportID: {sportId} saved successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter both Team and SportID.");
                }
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
            // Display the text in the label:
            // "Skriv värdet 1 för Basket i fältet SportID"
            // "Skriv värdet 2 för Fotboll i fältet SportID"
            // "Skriv värdet 3 för Ishockey i fältet SportID"
            lbl_addNewTeam.Text = "Skriv värdet 1 för Basket i fältet SportID\n" +
                "Skriv värdet 2 för Fotboll i fältet SportID\n" +
                "Skriv värdet 3 för Ishockey i fältet SportID\n";
        }

        private void frm_AddTeam_Load(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {
            // Display the test in the label:
            // "Skriv värdet 1 för Basket i fältet SportID"
            lbl_addNewTeam.Text = "Skriv värdet 1 för Basket i fältet SportID\n" +
                "Skriv värdet 2 för Fotboll i fältet SportID\n" +
                "Skriv värdet 3 för Ishockey i fältet SportID\n";


        }
    }
}
