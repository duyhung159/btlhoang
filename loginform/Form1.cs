using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            pn1.BackColor = Color.FromArgb(0, 255, 255);
            txtUser.ForeColor = Color.FromArgb(0, 255, 255);
            pn2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtPass.PasswordChar = '*';
            pn2.BackColor = Color.FromArgb(0, 255, 255);
            txtPass.ForeColor = Color.FromArgb(0, 255, 255);

            pn1.BackColor = Color.WhiteSmoke;
            txtUser.ForeColor = Color.WhiteSmoke;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You Surely Escape ", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUser.Text;
            string pw = txtPass.Text;
            if (id == "admin" && pw == "admin")
            {
              
                MessageBox.Show("LOGIN SUCCESSFULLY!");
                DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                MessageBox.Show("Incorrect Account Or Password!");
            }
            
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
          
        }

        private void btnPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs ());
                this.Hide();
            }    
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
