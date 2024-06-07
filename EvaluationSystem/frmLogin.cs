using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class frmLogin : Form
    {
        Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc;

        private void OK_Click(object sender, EventArgs e)
        {
            maxrow = SC.maxrow("SELECT * FROM `tbluseraccount` WHERE User_name= '" + UsernameTextBox.Text 
                + "' and Pass = sha1('" + PasswordTextBox.Text  + "')");
            if(maxrow > 0)
            {
                frm.enabled_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click_1(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
