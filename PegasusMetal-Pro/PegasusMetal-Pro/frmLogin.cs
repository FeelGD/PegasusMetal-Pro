using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace PegasusMetal_Pro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter' a basıldığında buraya girer.
                //login check 
                button1.Enabled = false;
                this.Close();
                
                //this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //login check 
            button1.Enabled = false;
            List<string> packetData = new List<string>();
            packetData.Add(OPCodes.LOGIN);
            packetData.Add(JsonConvert.SerializeObject(new User() { Username = textEdit1.Text, Password = textEdit2.Text }));
            WebSocketService.getInstance().Send(packetData);
            //this.Close();
        }
        public void LoginSuccess(string Name, string Surname)
        {
            MessageBox.Show(Name + " " + Surname + " Pegasus Metal Yazılımına Hoşgeldiniz.", "Giriş Başarılı!");
            this.Close();
        }

        public void LoginFail(string message)
        {
            MessageBox.Show(message, "Hata!");
            button1.Enabled = true;
        }
    }
}
