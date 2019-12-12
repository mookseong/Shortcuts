using System.ComponentModel;

namespace Shortcuts
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        private void InitializeComponent()
{
    this.panel1 = new System.Windows.Forms.Panel();
    this.저장 = new System.Windows.Forms.Button();
    this.SuspendLayout();
    // 
    // panel1
    // 
    this.panel1.Location = new System.Drawing.Point(12, 11);
    this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(330, 50);
    this.panel1.TabIndex = 0;
    // 
    // 저장
    // 
    this.저장.Location = new System.Drawing.Point(359, 5);
    this.저장.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
    this.저장.Name = "저장";
    this.저장.Size = new System.Drawing.Size(86, 62);
    this.저장.TabIndex = 1;
    this.저장.Text = "저장";
    this.저장.UseVisualStyleBackColor = true;
    this.저장.Click += new System.EventHandler(this.저장_Click);
    // 
    // AddForm
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.White;
    this.ClientSize = new System.Drawing.Size(455, 78);
    this.Controls.Add(this.저장);
    this.Controls.Add(this.panel1);
    this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    this.Name = "AddForm";
    this.Text = "AddForm";
    this.ResumeLayout(false);
}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button 저장;
    }
}