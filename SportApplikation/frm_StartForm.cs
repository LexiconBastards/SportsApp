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

        //private void Label1_Click(object sender, EventArgs e)
        //{

        //}

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            // Closing the application
            Application.Exit();
        }

        private void btn_AddNewTeam_Click(object sender, EventArgs e)
        {
            // Let the user add a new team to the database in the SQL-server by the form "frm_Team"
            //AddNewTeam();

        }
    }
}
