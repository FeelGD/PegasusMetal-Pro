using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegasusMetal_Pro
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            new Thread(new ThreadStart(() =>
            {
                while(!Constants.AllDataIsReceived)
                {

                }
                CloseForm();
            }));
        }

        public void CloseForm()
        {
            this.Close();
        }
    }
}
