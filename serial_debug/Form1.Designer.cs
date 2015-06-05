﻿namespace serial_debug
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.send_bt = new System.Windows.Forms.Button();
            this.txbox = new System.Windows.Forms.TextBox();
            this.rxbox = new System.Windows.Forms.TextBox();
            this.txishex = new System.Windows.Forms.CheckBox();
            this.rxishex = new System.Windows.Forms.CheckBox();
            this.portst = new System.Windows.Forms.Label();
            this.baudls = new System.Windows.Forms.ComboBox();
            this.portsls = new System.Windows.Forms.ComboBox();
            this.switchbt = new System.Windows.Forms.Button();
            this.refreshbt = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rxcounter = new System.Windows.Forms.Label();
            this.txcounter = new System.Windows.Forms.Label();
            this.clrbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send_bt
            // 
            this.send_bt.Location = new System.Drawing.Point(101, 242);
            this.send_bt.Name = "send_bt";
            this.send_bt.Size = new System.Drawing.Size(75, 23);
            this.send_bt.TabIndex = 30;
            this.send_bt.Text = "Send";
            this.send_bt.UseVisualStyleBackColor = true;
            this.send_bt.Click += new System.EventHandler(this.send_bt_Click);
            // 
            // txbox
            // 
            this.txbox.Location = new System.Drawing.Point(25, 92);
            this.txbox.Multiline = true;
            this.txbox.Name = "txbox";
            this.txbox.Size = new System.Drawing.Size(223, 144);
            this.txbox.TabIndex = 31;
            // 
            // rxbox
            // 
            this.rxbox.Location = new System.Drawing.Point(254, 92);
            this.rxbox.Multiline = true;
            this.rxbox.Name = "rxbox";
            this.rxbox.Size = new System.Drawing.Size(223, 144);
            this.rxbox.TabIndex = 32;
            // 
            // txishex
            // 
            this.txishex.AutoSize = true;
            this.txishex.Location = new System.Drawing.Point(28, 242);
            this.txishex.Name = "txishex";
            this.txishex.Size = new System.Drawing.Size(72, 16);
            this.txishex.TabIndex = 33;
            this.txishex.Text = "十六进制";
            this.txishex.UseVisualStyleBackColor = true;
            this.txishex.CheckedChanged += new System.EventHandler(this.txishex_CheckedChanged);
            // 
            // rxishex
            // 
            this.rxishex.AutoSize = true;
            this.rxishex.Location = new System.Drawing.Point(405, 242);
            this.rxishex.Name = "rxishex";
            this.rxishex.Size = new System.Drawing.Size(72, 16);
            this.rxishex.TabIndex = 34;
            this.rxishex.Text = "十六进制";
            this.rxishex.UseVisualStyleBackColor = true;
            this.rxishex.CheckedChanged += new System.EventHandler(this.rxishex_CheckedChanged);
            // 
            // portst
            // 
            this.portst.AutoSize = true;
            this.portst.Location = new System.Drawing.Point(363, 15);
            this.portst.Name = "portst";
            this.portst.Size = new System.Drawing.Size(41, 12);
            this.portst.TabIndex = 39;
            this.portst.Text = "Status";
            // 
            // baudls
            // 
            this.baudls.FormattingEnabled = true;
            this.baudls.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.baudls.Location = new System.Drawing.Point(240, 12);
            this.baudls.Name = "baudls";
            this.baudls.Size = new System.Drawing.Size(63, 20);
            this.baudls.TabIndex = 38;
            this.baudls.Text = "9600";
            // 
            // portsls
            // 
            this.portsls.FormattingEnabled = true;
            this.portsls.Location = new System.Drawing.Point(101, 12);
            this.portsls.Name = "portsls";
            this.portsls.Size = new System.Drawing.Size(69, 20);
            this.portsls.TabIndex = 37;
            // 
            // switchbt
            // 
            this.switchbt.Location = new System.Drawing.Point(309, 10);
            this.switchbt.Name = "switchbt";
            this.switchbt.Size = new System.Drawing.Size(48, 23);
            this.switchbt.TabIndex = 36;
            this.switchbt.Text = "Open";
            this.switchbt.UseVisualStyleBackColor = true;
            this.switchbt.Click += new System.EventHandler(this.switchbt_Click);
            // 
            // refreshbt
            // 
            this.refreshbt.Location = new System.Drawing.Point(176, 10);
            this.refreshbt.Name = "refreshbt";
            this.refreshbt.Size = new System.Drawing.Size(58, 23);
            this.refreshbt.TabIndex = 35;
            this.refreshbt.Text = "Refresh";
            this.refreshbt.UseVisualStyleBackColor = true;
            this.refreshbt.Click += new System.EventHandler(this.refreshbt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "Sended";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "Received";
            // 
            // rxcounter
            // 
            this.rxcounter.AutoSize = true;
            this.rxcounter.Location = new System.Drawing.Point(437, 77);
            this.rxcounter.Name = "rxcounter";
            this.rxcounter.Size = new System.Drawing.Size(11, 12);
            this.rxcounter.TabIndex = 47;
            this.rxcounter.Text = "0";
            // 
            // txcounter
            // 
            this.txcounter.AutoSize = true;
            this.txcounter.Location = new System.Drawing.Point(211, 77);
            this.txcounter.Name = "txcounter";
            this.txcounter.Size = new System.Drawing.Size(11, 12);
            this.txcounter.TabIndex = 46;
            this.txcounter.Text = "0";
            // 
            // clrbt
            // 
            this.clrbt.Location = new System.Drawing.Point(324, 242);
            this.clrbt.Name = "clrbt";
            this.clrbt.Size = new System.Drawing.Size(75, 23);
            this.clrbt.TabIndex = 50;
            this.clrbt.Text = "Clear";
            this.clrbt.UseVisualStyleBackColor = true;
            this.clrbt.Click += new System.EventHandler(this.clrbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 286);
            this.Controls.Add(this.clrbt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rxcounter);
            this.Controls.Add(this.txcounter);
            this.Controls.Add(this.portst);
            this.Controls.Add(this.baudls);
            this.Controls.Add(this.portsls);
            this.Controls.Add(this.switchbt);
            this.Controls.Add(this.refreshbt);
            this.Controls.Add(this.rxishex);
            this.Controls.Add(this.txishex);
            this.Controls.Add(this.rxbox);
            this.Controls.Add(this.txbox);
            this.Controls.Add(this.send_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Serial_debug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_bt;
        private System.Windows.Forms.TextBox txbox;
        private System.Windows.Forms.TextBox rxbox;
        private System.Windows.Forms.CheckBox txishex;
        private System.Windows.Forms.CheckBox rxishex;
        private System.Windows.Forms.Label portst;
        private System.Windows.Forms.ComboBox baudls;
        private System.Windows.Forms.ComboBox portsls;
        private System.Windows.Forms.Button switchbt;
        private System.Windows.Forms.Button refreshbt;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rxcounter;
        private System.Windows.Forms.Label txcounter;
        private System.Windows.Forms.Button clrbt;
    }
}

