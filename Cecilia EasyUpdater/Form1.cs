using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cecilia_EasyUpdater.Forms;
using Sunny.UI;

namespace Cecilia_EasyUpdater
{
    public partial class Form1 : UIForm
    {
        public string status = "welcome";
        public static CheckMachine.CheckMachineStatus cms;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (status == "welcome")
            {
                Welcome wc = new Welcome();
                wc.TopMost = false;
                wc.TopLevel = false;
                wc.Parent = this.mainDesignPanel;
                wc.Dock = DockStyle.Fill;
                wc.Show();
            }
        }
        public void ClearDesignPanel()
        {
            this.mainDesignPanel.Controls.Clear();
        }
        public void FlashDesignPanel()
        {
            if (status == "check_machine")
            {
                CheckMachine wc = new CheckMachine();
                wc.TopMost = false;
                wc.TopLevel = false;
                wc.Parent = this.mainDesignPanel;
                wc.Dock = DockStyle.Fill;
                wc.Show();
            }
        }
        private void mainpanel_Click(object sender, EventArgs e)
        {

        }
    }
}
