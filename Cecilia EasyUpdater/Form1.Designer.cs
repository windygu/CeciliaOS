
namespace Cecilia_EasyUpdater
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainDesignPanel = new Sunny.UI.UIPanel();
            this.SuspendLayout();
            // 
            // mainDesignPanel
            // 
            this.mainDesignPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.mainDesignPanel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mainDesignPanel.Location = new System.Drawing.Point(4, 35);
            this.mainDesignPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainDesignPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainDesignPanel.Name = "mainDesignPanel";
            this.mainDesignPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.mainDesignPanel.Size = new System.Drawing.Size(957, 469);
            this.mainDesignPanel.Style = Sunny.UI.UIStyle.Green;
            this.mainDesignPanel.TabIndex = 0;
            this.mainDesignPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainDesignPanel.Click += new System.EventHandler(this.mainpanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 509);
            this.Controls.Add(this.mainDesignPanel);
            this.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(2112, 1288);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 43, 0, 0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Green;
            this.Text = "Cecilia EasyUpdater 易升";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel mainDesignPanel;
    }
}

