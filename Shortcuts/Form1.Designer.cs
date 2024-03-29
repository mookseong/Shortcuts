﻿namespace Shortcuts
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.mainDockPanel = new System.Windows.Forms.Panel();
            this.listUC = new Shortcuts.UI_UserContorol.ListUC();
            this.addUC = new Shortcuts.UI_UserContorol.AddUc();
            this.homeUC = new Shortcuts.UI_UserContorol.HomeUC();
            this.buttonPanel.SuspendLayout();
            this.mainDockPanel.SuspendLayout();
            this.SuspendLayout();
            this.buttonPanel.Controls.Add(this.startButton);
            this.buttonPanel.Controls.Add(this.listButton);
            this.buttonPanel.Controls.Add(this.addButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 490);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(424, 61);
            this.buttonPanel.TabIndex = 1;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(280, 0);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 61);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "작동";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button4_Click);
            this.listButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.listButton.FlatAppearance.BorderSize = 0;
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.Location = new System.Drawing.Point(140, 0);
            this.listButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(140, 61);
            this.listButton.TabIndex = 2;
            this.listButton.Text = "단축어 목록";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.button3_Click);
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 61);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "단축어 추가";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            this.mainDockPanel.Controls.Add(this.listUC);
            this.mainDockPanel.Controls.Add(this.addUC);
            this.mainDockPanel.Controls.Add(this.homeUC);
            this.mainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDockPanel.Location = new System.Drawing.Point(0, 0);
            this.mainDockPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainDockPanel.Name = "mainDockPanel";
            this.mainDockPanel.Size = new System.Drawing.Size(424, 490);
            this.mainDockPanel.TabIndex = 2;
            this.listUC.BackColor = System.Drawing.Color.White;
            this.listUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUC.Location = new System.Drawing.Point(0, 0);
            this.listUC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listUC.Name = "listUC";
            this.listUC.Size = new System.Drawing.Size(424, 490);
            this.listUC.TabIndex = 2;
            this.addUC.BackColor = System.Drawing.Color.White;
            this.addUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUC.Location = new System.Drawing.Point(0, 0);
            this.addUC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addUC.Name = "addUC";
            this.addUC.Size = new System.Drawing.Size(424, 490);
            this.addUC.TabIndex = 1;
            this.homeUC.BackColor = System.Drawing.Color.White;
            this.homeUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUC.Location = new System.Drawing.Point(0, 0);
            this.homeUC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeUC.Name = "homeUC";
            this.homeUC.Size = new System.Drawing.Size(424, 490);
            this.homeUC.TabIndex = 0;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 551);
            this.Controls.Add(this.mainDockPanel);
            this.Controls.Add(this.buttonPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.buttonPanel.ResumeLayout(false);
            this.mainDockPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel mainDockPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button startButton;
        private Shortcuts.UI_UserContorol.HomeUC homeUC;
        private Shortcuts.UI_UserContorol.AddUc addUC;
        private Shortcuts.UI_UserContorol.ListUC listUC;
    }
}

