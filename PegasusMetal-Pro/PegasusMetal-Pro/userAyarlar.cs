using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegasusMetal_Pro
{
    public partial class userAyarlar : UserControl
    {
        public userAyarlar()
        {
            InitializeComponent();
        }

        private void ARollerBtn_Click(object sender, EventArgs e)
        {
            frmRoller roles = new frmRoller();
            roles.ShowDialog();
        }
    }
}
