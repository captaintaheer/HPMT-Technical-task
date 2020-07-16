namespace HPMT_Technical_task
{
    partial class TechnicalTask
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.settings_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Menu2 = new System.Windows.Forms.Label();
            this.panelMenu1 = new System.Windows.Forms.Panel();
            this.Record1 = new System.Windows.Forms.Label();
            this.Record2 = new System.Windows.Forms.Label();
            this.Record4 = new System.Windows.Forms.Label();
            this.Job1_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.checkConnection = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu3.SuspendLayout();
            this.panelMenu2.SuspendLayout();
            this.panelMenu1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(376, 445);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(60, 23);
            this.settings_btn.TabIndex = 1;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.Settings_btn);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(452, 445);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(43, 23);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Edit_btn);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 474);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Records";
            this.groupBox1.Enter += new System.EventHandler(this.Records_Box);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMenu3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelMenu2);
            this.panel1.Controls.Add(this.Menu2);
            this.panel1.Controls.Add(this.panelMenu1);
            this.panel1.Controls.Add(this.Job1_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 430);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMenu3
            // 
            this.panelMenu3.Controls.Add(this.label10);
            this.panelMenu3.Controls.Add(this.label11);
            this.panelMenu3.Controls.Add(this.label12);
            this.panelMenu3.Location = new System.Drawing.Point(36, 198);
            this.panelMenu3.Name = "panelMenu3";
            this.panelMenu3.Size = new System.Drawing.Size(73, 0);
            this.panelMenu3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Record 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Record 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Record 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(10, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Job C";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelMenu2
            // 
            this.panelMenu2.Controls.Add(this.label6);
            this.panelMenu2.Controls.Add(this.label7);
            this.panelMenu2.Controls.Add(this.label8);
            this.panelMenu2.Location = new System.Drawing.Point(36, 97);
            this.panelMenu2.Name = "panelMenu2";
            this.panelMenu2.Size = new System.Drawing.Size(72, 0);
            this.panelMenu2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Record A-1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Record B-2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Record C-3";
            // 
            // Menu2
            // 
            this.Menu2.AutoSize = true;
            this.Menu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu2.Location = new System.Drawing.Point(7, 80);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(34, 13);
            this.Menu2.TabIndex = 19;
            this.Menu2.Text = "Job B";
            this.Menu2.Click += new System.EventHandler(this.Menu2_Click);
            // 
            // panelMenu1
            // 
            this.panelMenu1.Controls.Add(this.Record1);
            this.panelMenu1.Controls.Add(this.Record2);
            this.panelMenu1.Controls.Add(this.Record4);
            this.panelMenu1.Location = new System.Drawing.Point(30, 20);
            this.panelMenu1.Name = "panelMenu1";
            this.panelMenu1.Size = new System.Drawing.Size(79, 0);
            this.panelMenu1.TabIndex = 18;
            // 
            // Record1
            // 
            this.Record1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Record1.AutoSize = true;
            this.Record1.Location = new System.Drawing.Point(3, 9);
            this.Record1.Name = "Record1";
            this.Record1.Size = new System.Drawing.Size(51, 13);
            this.Record1.TabIndex = 0;
            this.Record1.Text = "Record 1";
            this.Record1.Click += new System.EventHandler(this.Record1_Click);
            // 
            // Record2
            // 
            this.Record2.AutoSize = true;
            this.Record2.Location = new System.Drawing.Point(3, 22);
            this.Record2.Name = "Record2";
            this.Record2.Size = new System.Drawing.Size(51, 13);
            this.Record2.TabIndex = 2;
            this.Record2.Text = "Record 2";
            this.Record2.Click += new System.EventHandler(this.Record2_Click);
            // 
            // Record4
            // 
            this.Record4.AutoSize = true;
            this.Record4.Location = new System.Drawing.Point(3, 35);
            this.Record4.Name = "Record4";
            this.Record4.Size = new System.Drawing.Size(51, 13);
            this.Record4.TabIndex = 3;
            this.Record4.Text = "Record 3";
            this.Record4.Click += new System.EventHandler(this.Record3_Click);
            // 
            // Job1_lbl
            // 
            this.Job1_lbl.AutoSize = true;
            this.Job1_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Job1_lbl.Location = new System.Drawing.Point(7, 4);
            this.Job1_lbl.Name = "Job1_lbl";
            this.Job1_lbl.Size = new System.Drawing.Size(34, 13);
            this.Job1_lbl.TabIndex = 17;
            this.Job1_lbl.Text = "Job A";
            this.Job1_lbl.Click += new System.EventHandler(this.Job1_lbl_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExportBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Location = new System.Drawing.Point(3, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 65);
            this.panel2.TabIndex = 16;
            // 
            // ExportBtn
            // 
            this.ExportBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.ExportBtn.Location = new System.Drawing.Point(3, 3);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(129, 24);
            this.ExportBtn.TabIndex = 1;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(3, 33);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(132, 29);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.Location = new System.Drawing.Point(245, 236);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 13);
            this.checkConnection.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // TechnicalTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 511);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TechnicalTask";
            this.Text = "HPMT Technical task";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu3.ResumeLayout(false);
            this.panelMenu3.PerformLayout();
            this.panelMenu2.ResumeLayout(false);
            this.panelMenu2.PerformLayout();
            this.panelMenu1.ResumeLayout(false);
            this.panelMenu1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Record1;
        private System.Windows.Forms.Label Record4;
        private System.Windows.Forms.Label Record2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Panel panelMenu1;
        private System.Windows.Forms.Label Job1_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelMenu3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu2;
        private System.Windows.Forms.Label Menu2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

