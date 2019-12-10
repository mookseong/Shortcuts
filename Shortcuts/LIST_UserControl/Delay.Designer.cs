using System.ComponentModel;

namespace Shortcuts.LIST_UserControl
{
    partial class Deleay
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TEXT = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TEXT
            // 
            this.TEXT.Location = new System.Drawing.Point(73, 12);
            this.TEXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TEXT.Name = "TEXT";
            this.TEXT.Size = new System.Drawing.Size(73, 23);
            this.TEXT.TabIndex = 3;
            this.TEXT.TextChanged += new System.EventHandler(this.TEXT_TextChanged);
            // 
            // Text1
            // 
            this.Text1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (129)));
            this.Text1.Location = new System.Drawing.Point(148, 12);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(117, 24);
            this.Text1.TabIndex = 2;
            this.Text1.Text = "초 기달리기";
            // 
            // Deleay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TEXT);
            this.Controls.Add(this.Text1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Deleay";
            this.Size = new System.Drawing.Size(330, 50);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.TextBox TEXT;
    }
}