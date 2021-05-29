using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cecilia_EasyUpdater.Forms
{
    public partial class Welcome : Sunny.UI.UIForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ClearDesignPanel();
            f.status = "check_machine";
            f.FlashDesignPanel();this.Close();
        }
    }
}
