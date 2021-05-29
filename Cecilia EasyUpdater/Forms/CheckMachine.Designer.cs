
namespace Cecilia_EasyUpdater.Forms
{
    partial class CheckMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiProgressIndicator1 = new Sunny.UI.UIProgressIndicator();
            this.textInfop = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(13, 13);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(367, 42);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "正在检查您的计算机...";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(18, 59);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(362, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "易升需要检查您的计算机来确认是否符合安装需求";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiProgressIndicator1
            // 
            this.uiProgressIndicator1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiProgressIndicator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiProgressIndicator1.Location = new System.Drawing.Point(426, 273);
            this.uiProgressIndicator1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiProgressIndicator1.Name = "uiProgressIndicator1";
            this.uiProgressIndicator1.Size = new System.Drawing.Size(100, 100);
            this.uiProgressIndicator1.Style = Sunny.UI.UIStyle.Green;
            this.uiProgressIndicator1.TabIndex = 2;
            this.uiProgressIndicator1.Text = "uiProgressIndicator1";
            // 
            // textInfop
            // 
            this.textInfop.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textInfop.Location = new System.Drawing.Point(281, 210);
            this.textInfop.Name = "textInfop";
            this.textInfop.Size = new System.Drawing.Size(387, 60);
            this.textInfop.Style = Sunny.UI.UIStyle.Custom;
            this.textInfop.TabIndex = 3;
            this.textInfop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckMachine
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 469);
            this.ControlBox = false;
            this.Controls.Add(this.textInfop);
            this.Controls.Add(this.uiProgressIndicator1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckMachine";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ShowInTaskbar = false;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIProgressIndicator uiProgressIndicator1;
        private Sunny.UI.UILabel textInfop;
    }
}