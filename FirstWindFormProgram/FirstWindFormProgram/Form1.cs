using FirstWindFormProgram.Frms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindFormProgram
{
    public partial class NewForm : Form
    {
        private static bool Flag = false;
        Frms.FrmUser frmUser = null;
        public NewForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textUser.Text);
            frmUser = new Frms.FrmUser();
            if (Flag == false) { 
                frmUser.Show();
                //frmUser.ShowDialog();使用该方法，打开新的窗口，原窗口不可选择
                //frmUser.Activate();//激活窗口
                Flag = true;
            }
            

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.frmUser.Close();
            Flag = false;
        }
    }
}
