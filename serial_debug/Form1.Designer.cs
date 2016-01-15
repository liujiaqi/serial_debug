namespace serial_debug
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.stopls = new System.Windows.Forms.ComboBox();
            this.parityls = new System.Windows.Forms.ComboBox();
            this.databits_ls = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataName = new System.Windows.Forms.TextBox();
            this.dataPattern = new System.Windows.Forms.TextBox();
            this.rm_bt = new System.Windows.Forms.Button();
            this.add_bt = new System.Windows.Forms.Button();
            this.dataFieldsBox = new System.Windows.Forms.CheckedListBox();
            this.rxbox2 = new System.Windows.Forms.TextBox();
            this.sw_gh_bt = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // send_bt
            // 
            this.send_bt.Location = new System.Drawing.Point(202, 451);
            this.send_bt.Name = "send_bt";
            this.send_bt.Size = new System.Drawing.Size(75, 23);
            this.send_bt.TabIndex = 30;
            this.send_bt.Text = "Send";
            this.send_bt.UseVisualStyleBackColor = true;
            this.send_bt.Click += new System.EventHandler(this.send_bt_Click);
            // 
            // txbox
            // 
            this.txbox.Location = new System.Drawing.Point(32, 78);
            this.txbox.Multiline = true;
            this.txbox.Name = "txbox";
            this.txbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbox.Size = new System.Drawing.Size(438, 367);
            this.txbox.TabIndex = 31;
            // 
            // rxbox
            // 
            this.rxbox.Location = new System.Drawing.Point(485, 78);
            this.rxbox.Multiline = true;
            this.rxbox.Name = "rxbox";
            this.rxbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rxbox.Size = new System.Drawing.Size(440, 367);
            this.rxbox.TabIndex = 32;
            // 
            // txishex
            // 
            this.txishex.AutoSize = true;
            this.txishex.Location = new System.Drawing.Point(42, 451);
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
            this.rxishex.Location = new System.Drawing.Point(853, 451);
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
            this.portst.Location = new System.Drawing.Point(636, 15);
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
            this.baudls.Location = new System.Drawing.Point(299, 12);
            this.baudls.Name = "baudls";
            this.baudls.Size = new System.Drawing.Size(63, 20);
            this.baudls.TabIndex = 38;
            this.baudls.Text = "115200";
            this.baudls.SelectedIndexChanged += new System.EventHandler(this.baudls_SelectedIndexChanged);
            // 
            // portsls
            // 
            this.portsls.FormattingEnabled = true;
            this.portsls.Location = new System.Drawing.Point(160, 12);
            this.portsls.Name = "portsls";
            this.portsls.Size = new System.Drawing.Size(69, 20);
            this.portsls.TabIndex = 37;
            this.portsls.SelectedIndexChanged += new System.EventHandler(this.portsls_SelectedIndexChanged);
            // 
            // switchbt
            // 
            this.switchbt.Location = new System.Drawing.Point(582, 10);
            this.switchbt.Name = "switchbt";
            this.switchbt.Size = new System.Drawing.Size(48, 23);
            this.switchbt.TabIndex = 36;
            this.switchbt.Text = "Open";
            this.switchbt.UseVisualStyleBackColor = true;
            this.switchbt.Click += new System.EventHandler(this.switchbt_Click);
            // 
            // refreshbt
            // 
            this.refreshbt.Location = new System.Drawing.Point(235, 10);
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
            this.label6.Location = new System.Drawing.Point(53, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "Sended";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "Received";
            // 
            // rxcounter
            // 
            this.rxcounter.AutoSize = true;
            this.rxcounter.Location = new System.Drawing.Point(851, 63);
            this.rxcounter.Name = "rxcounter";
            this.rxcounter.Size = new System.Drawing.Size(11, 12);
            this.rxcounter.TabIndex = 47;
            this.rxcounter.Text = "0";
            // 
            // txcounter
            // 
            this.txcounter.AutoSize = true;
            this.txcounter.Location = new System.Drawing.Point(399, 63);
            this.txcounter.Name = "txcounter";
            this.txcounter.Size = new System.Drawing.Size(11, 12);
            this.txcounter.TabIndex = 46;
            this.txcounter.Text = "0";
            // 
            // clrbt
            // 
            this.clrbt.Location = new System.Drawing.Point(667, 451);
            this.clrbt.Name = "clrbt";
            this.clrbt.Size = new System.Drawing.Size(75, 23);
            this.clrbt.TabIndex = 50;
            this.clrbt.Text = "Clear";
            this.clrbt.UseVisualStyleBackColor = true;
            this.clrbt.Click += new System.EventHandler(this.clrbt_Click);
            // 
            // stopls
            // 
            this.stopls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stopls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stopls.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.stopls.Location = new System.Drawing.Point(478, 12);
            this.stopls.Name = "stopls";
            this.stopls.Size = new System.Drawing.Size(98, 20);
            this.stopls.TabIndex = 55;
            this.stopls.Text = "One";
            this.stopls.SelectedIndexChanged += new System.EventHandler(this.stopls_SelectedIndexChanged);
            // 
            // parityls
            // 
            this.parityls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.parityls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.parityls.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityls.Location = new System.Drawing.Point(417, 12);
            this.parityls.Name = "parityls";
            this.parityls.Size = new System.Drawing.Size(55, 20);
            this.parityls.TabIndex = 54;
            this.parityls.Text = "None";
            this.parityls.SelectedIndexChanged += new System.EventHandler(this.parityls_SelectedIndexChanged);
            // 
            // databits_ls
            // 
            this.databits_ls.FormattingEnabled = true;
            this.databits_ls.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databits_ls.Location = new System.Drawing.Point(368, 12);
            this.databits_ls.Name = "databits_ls";
            this.databits_ls.Size = new System.Drawing.Size(43, 20);
            this.databits_ls.TabIndex = 56;
            this.databits_ls.Text = "8";
            this.databits_ls.SelectedIndexChanged += new System.EventHandler(this.databits_ls_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 536);
            this.tabControl1.TabIndex = 57;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbox);
            this.tabPage1.Controls.Add(this.send_bt);
            this.tabPage1.Controls.Add(this.rxbox);
            this.tabPage1.Controls.Add(this.txishex);
            this.tabPage1.Controls.Add(this.clrbt);
            this.tabPage1.Controls.Add(this.rxishex);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txcounter);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rxcounter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataName);
            this.tabPage2.Controls.Add(this.dataPattern);
            this.tabPage2.Controls.Add(this.rm_bt);
            this.tabPage2.Controls.Add(this.add_bt);
            this.tabPage2.Controls.Add(this.dataFieldsBox);
            this.tabPage2.Controls.Add(this.rxbox2);
            this.tabPage2.Controls.Add(this.sw_gh_bt);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "Pattern:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name:";
            // 
            // dataName
            // 
            this.dataName.Location = new System.Drawing.Point(750, 167);
            this.dataName.Name = "dataName";
            this.dataName.Size = new System.Drawing.Size(89, 21);
            this.dataName.TabIndex = 38;
            // 
            // dataPattern
            // 
            this.dataPattern.Location = new System.Drawing.Point(750, 194);
            this.dataPattern.Name = "dataPattern";
            this.dataPattern.Size = new System.Drawing.Size(170, 21);
            this.dataPattern.TabIndex = 37;
            // 
            // rm_bt
            // 
            this.rm_bt.Location = new System.Drawing.Point(845, 327);
            this.rm_bt.Name = "rm_bt";
            this.rm_bt.Size = new System.Drawing.Size(75, 23);
            this.rm_bt.TabIndex = 36;
            this.rm_bt.Text = "Remove";
            this.rm_bt.UseVisualStyleBackColor = true;
            this.rm_bt.Click += new System.EventHandler(this.rm_bt_Click);
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(845, 165);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(75, 23);
            this.add_bt.TabIndex = 35;
            this.add_bt.Text = "Add";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // dataFieldsBox
            // 
            this.dataFieldsBox.FormattingEnabled = true;
            this.dataFieldsBox.Location = new System.Drawing.Point(693, 221);
            this.dataFieldsBox.Name = "dataFieldsBox";
            this.dataFieldsBox.Size = new System.Drawing.Size(227, 100);
            this.dataFieldsBox.TabIndex = 34;
            // 
            // rxbox2
            // 
            this.rxbox2.Location = new System.Drawing.Point(46, 6);
            this.rxbox2.Multiline = true;
            this.rxbox2.Name = "rxbox2";
            this.rxbox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rxbox2.Size = new System.Drawing.Size(874, 126);
            this.rxbox2.TabIndex = 33;
            this.rxbox2.WordWrap = false;
            // 
            // sw_gh_bt
            // 
            this.sw_gh_bt.Location = new System.Drawing.Point(778, 418);
            this.sw_gh_bt.Name = "sw_gh_bt";
            this.sw_gh_bt.Size = new System.Drawing.Size(75, 23);
            this.sw_gh_bt.TabIndex = 1;
            this.sw_gh_bt.Text = "Begin";
            this.sw_gh_bt.UseVisualStyleBackColor = true;
            this.sw_gh_bt.Click += new System.EventHandler(this.sw_gh_bt_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(46, 138);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(641, 320);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.databits_ls);
            this.Controls.Add(this.stopls);
            this.Controls.Add(this.parityls);
            this.Controls.Add(this.portst);
            this.Controls.Add(this.baudls);
            this.Controls.Add(this.portsls);
            this.Controls.Add(this.switchbt);
            this.Controls.Add(this.refreshbt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Serial_debug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.ComboBox stopls;
        private System.Windows.Forms.ComboBox parityls;
        private System.Windows.Forms.ComboBox databits_ls;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button sw_gh_bt;
        private System.Windows.Forms.TextBox rxbox2;
        private System.Windows.Forms.CheckedListBox dataFieldsBox;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button rm_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataName;
        private System.Windows.Forms.TextBox dataPattern;
    }
}

