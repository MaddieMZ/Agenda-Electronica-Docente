using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Electronica_Docente
{
    public partial class LoginNRegister : Form
    {
        public LoginNRegister()
        {
            InitializeComponent();
        }

        Login lgfrm = new Login();
        Register rgfrm = new Register();
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetChildForm(lgfrm);
            rgfrm.Hide();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetChildForm(rgfrm);
            lgfrm.Hide();
        }

        private void SetChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.ControlBox = false;

            int menuHeight = menuStrip1.Height; // Replace menuStrip1 with the name of your MenuStrip

            childForm.Size = new Size(560, 422);
            childForm.Location = new Point(0,0) ;

            childForm.Show();
        }
    }
}
