using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 팀과제.UI;


namespace 팀과제
{
    public partial class Login_Form : MetroFramework.Forms.MetroForm
    {
        private 컨트롤.Control _control = 컨트롤.Control.Instance;

        public Login_Form()
        {
            InitializeComponent();
        }

        #region Button Event

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string pw = txt_pw.Text;

            _control.Login(id, pw);
        }//Login

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Join dlg = new Join();
            //부모->자식
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string id = dlg.Id;
                string pw = dlg.Password;
                string name = dlg.Member_Name;

                _control.MemberJoin(id, pw, name);
            }
            this.Show();
        }//Join

        #endregion

        #region  FormLoad & FormClose

        private void Login_Form_Load(object sender, EventArgs e)
        {
            if (_control.Load() == true)
            {
                _control.alldata();
                this.Text = "서버 연결";
            }
            else
            {
                MessageBox.Show("서버 연결 실패");
            }
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _control.Close();
        }

        #endregion


    }
}
