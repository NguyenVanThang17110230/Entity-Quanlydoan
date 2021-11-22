﻿namespace DoanWindow.Views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giangvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoidongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemdiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.chamdiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.xemdiemToolStripMenuItem,
            this.dangxuatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhvienToolStripMenuItem,
            this.giangvienToolStripMenuItem,
            this.detaiToolStripMenuItem,
            this.tiendoToolStripMenuItem,
            this.hoidongToolStripMenuItem,
            this.chamdiemToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // sinhvienToolStripMenuItem
            // 
            this.sinhvienToolStripMenuItem.Name = "sinhvienToolStripMenuItem";
            this.sinhvienToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sinhvienToolStripMenuItem.Text = "Thông tin sinh viên";
            this.sinhvienToolStripMenuItem.Click += new System.EventHandler(this.sinhvienToolStripMenuItem_Click);
            // 
            // giangvienToolStripMenuItem
            // 
            this.giangvienToolStripMenuItem.Name = "giangvienToolStripMenuItem";
            this.giangvienToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.giangvienToolStripMenuItem.Text = "Thông tin giảng viên";
            this.giangvienToolStripMenuItem.Click += new System.EventHandler(this.giangvienToolStripMenuItem_Click);
            // 
            // detaiToolStripMenuItem
            // 
            this.detaiToolStripMenuItem.Name = "detaiToolStripMenuItem";
            this.detaiToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.detaiToolStripMenuItem.Text = "Thông tin đề tài";
            this.detaiToolStripMenuItem.Click += new System.EventHandler(this.detaiToolStripMenuItem_Click);
            // 
            // tiendoToolStripMenuItem
            // 
            this.tiendoToolStripMenuItem.Name = "tiendoToolStripMenuItem";
            this.tiendoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tiendoToolStripMenuItem.Text = "Tiến độ báo cáo";
            this.tiendoToolStripMenuItem.Click += new System.EventHandler(this.tiendoToolStripMenuItem_Click);
            // 
            // hoidongToolStripMenuItem
            // 
            this.hoidongToolStripMenuItem.Name = "hoidongToolStripMenuItem";
            this.hoidongToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.hoidongToolStripMenuItem.Text = "Hội đồng báo cáo";
            this.hoidongToolStripMenuItem.Click += new System.EventHandler(this.hoidongToolStripMenuItem_Click);
            // 
            // xemdiemToolStripMenuItem
            // 
            this.xemdiemToolStripMenuItem.Name = "xemdiemToolStripMenuItem";
            this.xemdiemToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.xemdiemToolStripMenuItem.Text = "Xem điểm";
            this.xemdiemToolStripMenuItem.Click += new System.EventHandler(this.xemdiemToolStripMenuItem_Click);
            // 
            // dangxuatToolStripMenuItem
            // 
            this.dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            this.dangxuatToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.dangxuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangxuatToolStripMenuItem.Click += new System.EventHandler(this.dangxuatToolStripMenuItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(632, 24);
            this.tabMain.TabIndex = 5;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // chamdiemToolStripMenuItem
            // 
            this.chamdiemToolStripMenuItem.Name = "chamdiemToolStripMenuItem";
            this.chamdiemToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.chamdiemToolStripMenuItem.Text = "Chấm điểm báo cáo";
            this.chamdiemToolStripMenuItem.Click += new System.EventHandler(this.chamdiemToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giangvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ToolStripMenuItem xemdiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoidongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamdiemToolStripMenuItem;
    }
}



