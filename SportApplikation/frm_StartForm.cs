using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportApplikation
{
    public partial class frm_StartForm : Form
    {
        public frm_StartForm()
        {
            InitializeComponent();
        }

        // Initializing the connectionstring to the Apache servers database

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            // Closing the application
            Application.Exit();
        }

        private void btn_AddNewTeam_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // Let the user add a new team to the database in the SQL-server by the form "frm_Team"
            // Load the form "frm_Team" to add a new team
            frm_AddTeam frm_Team = new frm_AddTeam();
            frm_Team.ShowDialog();
            // After adding a new team, refresh the team list in the combobox
            this.tbl_LagTableAdapter.Fill(this.lagsportDBDataSet.tbl_Lag);
            // Optionally, you can also refresh the sport list if needed
            this.tbl_SportTableAdapter.Fill(this.lagsportDBDataSet.tbl_Sport);
        }         

        private void frm_StartForm_Load(object sender, EventArgs e)
        {
            // Load team data into the 'lagsportDBDataSet.tbl_Lag' table
            this.tbl_LagTableAdapter.Fill(this.lagsportDBDataSet.tbl_Lag);
            this.tbl_SportTableAdapter.Fill(this.lagsportDBDataSet.tbl_Sport);

        }

        private void btn_CreateSchemeResultTable_Click(object sender, EventArgs e)
        {
            // Create game plan with random results and a table that displays the 
            // placing in the rank depending on the results
            // Load the data from the dataGridView elements by shoosen teams and sports
            // to create a game plan with results
            if (dataGridView_ShooseTeam.SelectedRows.Count < 4)
            {
                MessageBox.Show("Välj minst fyra lag för att skapa en spelschema.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a new instance of the game plan form

        }

        private void cmb_ShooseSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Let the user choose a sport from the combobox and display the teams that play that sport
            string selectedSport = cmb_ShooseSport.SelectedItem.ToString();
            if (selectedSport == "All")
            {
                // Show all teams
                this.tbl_LagTableAdapter.Fill(this.lagsportDBDataSet.tbl_Lag);
            }
            else
            {
                // Filter teams by selected sport
                this.tbl_LagTableAdapter.FillBySport(this.lagsportDBDataSet.tbl_Lag, selectedSport);
            }

        }

        private void dataGridView_ShooseTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Let the user shoose 4 teams to found the gameplan on
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected team from the DataGridView
                DataGridViewRow selectedRow = dataGridView_ShooseTeam.Rows[e.RowIndex];
                string teamName = selectedRow.Cells["TeamName"].Value.ToString();
                // Display the selected team name or perform any action needed
                MessageBox.Show($"Du valde: {teamName}", "Valt lag", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Handle the case where no valid cell was clicked
                MessageBox.Show("Välj ett giltigt lag.", "Ogiltigt val", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_GameSchemeAndResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Diplay a gameplan with results based on the selected teams and randomized results
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row from the DataGridView
                DataGridViewRow selectedRow = dataGridView_GameSchemeAndResults.Rows[e.RowIndex];
                string gameDetails = selectedRow.Cells["GameDetails"].Value.ToString();
                // Display the game details or perform any action needed
                MessageBox.Show($"Spelinformation: {gameDetails}", "Spelinformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Handle the case where no valid cell was clicked
                MessageBox.Show("Välj en giltig match.", "Ogiltigt val", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display a table with the ranking based on the results of the game plan
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row from the DataGridView
                DataGridViewRow selectedRow = dataGridView_Table.Rows[e.RowIndex];
                string teamRank = selectedRow.Cells["TeamRank"].Value.ToString();
                // Display the team rank or perform any action needed
                MessageBox.Show($"Lagets placering: {teamRank}", "Lagplacering", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Handle the case where no valid cell was clicked
                MessageBox.Show("Välj en giltig rad.", "Ogiltigt val", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtOneShoosedTeams_TextChanged(object sender, EventArgs e)
        {
            // Display the first selected team in the textbox
            if (dataGridView_ShooseTeam.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = dataGridView_ShooseTeam.SelectedRows[0];
                // Get the team name from the selected row
                string teamName = selectedRow.Cells["TeamName"].Value.ToString();
                // Display the team name in the textbox
                txtOneShoosedTeams.Text = teamName;
            }
            else
            {
                // Clear the textbox if no team is selected
                txtOneShoosedTeams.Text = string.Empty;
            }

        }

        private void txtTwoShoosedTeams_TextChanged(object sender, EventArgs e)
        {
            // Display the second selected team in the textbox
            if (dataGridView_ShooseTeam.SelectedRows.Count > 1)
            {
                // Get the second selected row
                DataGridViewRow selectedRow = dataGridView_ShooseTeam.SelectedRows[1];
                // Get the team name from the selected row
                string teamName = selectedRow.Cells["TeamName"].Value.ToString();
                // Display the team name in the textbox
                txtTwoShoosedTeams.Text = teamName;
            }
            else
            {
                // Clear the textbox if less than two teams are selected
                txtTwoShoosedTeams.Text = string.Empty;
            }
        }

        private void txtThreeShoosedTeams_TextChanged(object sender, EventArgs e)
        {
            // Display the third selected team in the textbox
            if (dataGridView_ShooseTeam.SelectedRows.Count > 2)
            {
                // Get the third selected row
                DataGridViewRow selectedRow = dataGridView_ShooseTeam.SelectedRows[2];
                // Get the team name from the selected row
                string teamName = selectedRow.Cells["TeamName"].Value.ToString();
                // Display the team name in the textbox
                txtThreeShoosedTeams.Text = teamName;
            }
            else
            {
                // Clear the textbox if less than three teams are selected
                txtThreeShoosedTeams.Text = string.Empty;
            }
        }

        private void txtFourShoosedTeams_TextChanged(object sender, EventArgs e)
        {
            // Display the fourth selected team in the textbox
            if (dataGridView_ShooseTeam.SelectedRows.Count > 3)
            {
                // Get the fourth selected row
                DataGridViewRow selectedRow = dataGridView_ShooseTeam.SelectedRows[3];
                // Get the team name from the selected row
                string teamName = selectedRow.Cells["TeamName"].Value.ToString();
                // Display the team name in the textbox
                txtFourShoosedTeams.Text = teamName;
            }
            else
            {
                // Clear the textbox if less than four teams are selected
                txtFourShoosedTeams.Text = string.Empty;
            }
=======
>>>>>>> 6938e24d5d9c9b8807209673c8488c9637a78e4c
            // Let the user add a new team to the database in the SQL-server by the form "frm_AddTeam"
            frm_AddTeam addteam = new frm_AddTeam();
            addteam.Show();
            this.Hide();
        }
    }
}
