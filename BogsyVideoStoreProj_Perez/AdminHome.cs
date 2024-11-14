using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogsyVideoStoreProj_Perez
{
    public partial class AdminHome : Form
    {
        public Label idnum;
        public Label usern;
        public AdminHome()
        {
            InitializeComponent();
            idnum = id;
            usern = username;
            WaitSomeTime();
        }

        public async void WaitSomeTime()
        {
            await Task.Delay(2000);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
            //show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
