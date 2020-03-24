namespace RankingAppProject
{
    partial class MainForm
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
            this.btLessionPoints = new System.Windows.Forms.Button();
            this.btRaitingInfo = new System.Windows.Forms.Button();
            this.btCodeExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLessionPoints
            // 
            this.btLessionPoints.Location = new System.Drawing.Point(318, 220);
            this.btLessionPoints.Name = "btLessionPoints";
            this.btLessionPoints.Size = new System.Drawing.Size(173, 23);
            this.btLessionPoints.TabIndex = 0;
            this.btLessionPoints.Text = "Узнать результаты";
            this.btLessionPoints.UseVisualStyleBackColor = true;
            // 
            // btRaitingInfo
            // 
            this.btRaitingInfo.Location = new System.Drawing.Point(318, 249);
            this.btRaitingInfo.Name = "btRaitingInfo";
            this.btRaitingInfo.Size = new System.Drawing.Size(173, 23);
            this.btRaitingInfo.TabIndex = 1;
            this.btRaitingInfo.Text = "Узнать рейтинг";
            this.btRaitingInfo.UseVisualStyleBackColor = true;
            // 
            // btCodeExample
            // 
            this.btCodeExample.Location = new System.Drawing.Point(318, 278);
            this.btCodeExample.Name = "btCodeExample";
            this.btCodeExample.Size = new System.Drawing.Size(173, 23);
            this.btCodeExample.TabIndex = 2;
            this.btCodeExample.Text = "Примеры кода";
            this.btCodeExample.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCodeExample);
            this.Controls.Add(this.btRaitingInfo);
            this.Controls.Add(this.btLessionPoints);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLessionPoints;
        private System.Windows.Forms.Button btRaitingInfo;
        private System.Windows.Forms.Button btCodeExample;
    }
}

