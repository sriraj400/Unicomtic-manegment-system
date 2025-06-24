using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicomtic_manegment_system.view
{
    public partial class second : Form
    {
        public second()
        {
            InitializeComponent();
        }

        private void second_Load(object sender, EventArgs e)
        {

        }

        private void btnuersview_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void btnadminview_Click(object sender, EventArgs e)
        {
            loginaddmin loginaddmin = new loginaddmin();
            loginaddmin.Show();
            this.Hide();
        }
    }
}
