using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cecilia_EasyUpdater.Forms
{
    public partial class CheckMachine : Sunny.UI.UIForm
    {
        public enum CheckMachineStatus
        {
            OK = 0,
            ERR = 1,
            WARN = 2,
            FATAL = 3
        }
        public CheckMachine()
        {
            InitializeComponent();
            Check();
        }
        public string getCpuInfo() //读取CPU信息
        {
            ManagementClass mobj = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mobj.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                return mo.Properties["ProcessorId"].Value.ToString();
            }
            return "";
        }
        private void Welcome_Load(object sender, EventArgs e)
        {

        }
        private void Check()
        {
            string cpu = getCpuInfo();
            if (Regex.Split(cpu," ")[0] != "Intel(R)")
            {
                textInfop.ForeColor = Color.Red;
                uiProgressIndicator1.Visible = false;
                textInfop.Text = "很抱歉，易升无法安装在使用 AMD 处理器的计算机上。";
                Form1.cms = CheckMachineStatus.FATAL;
            }
        }
    }
}
