namespace Hospital_management_system
{
    partial class Patientform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatAdd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatCon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.BloodCb = new System.Windows.Forms.ComboBox();
            this.MajorDis = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 134);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(657, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(406, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // PatId
            // 
            this.PatId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatId.HintForeColor = System.Drawing.Color.Empty;
            this.PatId.HintText = "";
            this.PatId.isPassword = false;
            this.PatId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatId.LineIdleColor = System.Drawing.Color.Gray;
            this.PatId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatId.LineThickness = 3;
            this.PatId.Location = new System.Drawing.Point(115, 157);
            this.PatId.Margin = new System.Windows.Forms.Padding(4);
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(169, 44);
            this.PatId.TabIndex = 2;
            this.PatId.Text = "PatientId";
            this.PatId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatName
            // 
            this.PatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatName.HintForeColor = System.Drawing.Color.Empty;
            this.PatName.HintText = "";
            this.PatName.isPassword = false;
            this.PatName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatName.LineIdleColor = System.Drawing.Color.Gray;
            this.PatName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatName.LineThickness = 3;
            this.PatName.Location = new System.Drawing.Point(115, 224);
            this.PatName.Margin = new System.Windows.Forms.Padding(4);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(169, 44);
            this.PatName.TabIndex = 3;
            this.PatName.Text = "PatientName";
            this.PatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PatName.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatAdd
            // 
            this.PatAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatAdd.HintForeColor = System.Drawing.Color.Empty;
            this.PatAdd.HintText = "";
            this.PatAdd.isPassword = false;
            this.PatAdd.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatAdd.LineIdleColor = System.Drawing.Color.Gray;
            this.PatAdd.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatAdd.LineThickness = 3;
            this.PatAdd.Location = new System.Drawing.Point(115, 288);
            this.PatAdd.Margin = new System.Windows.Forms.Padding(4);
            this.PatAdd.Name = "PatAdd";
            this.PatAdd.Size = new System.Drawing.Size(169, 42);
            this.PatAdd.TabIndex = 4;
            this.PatAdd.Text = "PatientAddress";
            this.PatAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PatAdd.OnValueChanged += new System.EventHandler(this.PatAdd_OnValueChanged);
            this.PatAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatCon
            // 
            this.PatCon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatCon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatCon.HintForeColor = System.Drawing.Color.Empty;
            this.PatCon.HintText = "";
            this.PatCon.isPassword = false;
            this.PatCon.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatCon.LineIdleColor = System.Drawing.Color.Gray;
            this.PatCon.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatCon.LineThickness = 3;
            this.PatCon.Location = new System.Drawing.Point(115, 347);
            this.PatCon.Margin = new System.Windows.Forms.Padding(4);
            this.PatCon.Name = "PatCon";
            this.PatCon.Size = new System.Drawing.Size(169, 42);
            this.PatCon.TabIndex = 5;
            this.PatCon.Text = "PatientContactno.";
            this.PatCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatAge
            // 
            this.PatAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatAge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatAge.HintForeColor = System.Drawing.Color.Empty;
            this.PatAge.HintText = "";
            this.PatAge.isPassword = false;
            this.PatAge.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatAge.LineIdleColor = System.Drawing.Color.Gray;
            this.PatAge.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatAge.LineThickness = 3;
            this.PatAge.Location = new System.Drawing.Point(115, 419);
            this.PatAge.Margin = new System.Windows.Forms.Padding(4);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(169, 42);
            this.PatAge.TabIndex = 6;
            this.PatAge.Text = "PatientAge";
            this.PatAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // GenderCb
            // 
            this.GenderCb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.GenderCb.Location = new System.Drawing.Point(115, 486);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(169, 29);
            this.GenderCb.TabIndex = 7;
            this.GenderCb.Text = "Gender";
            // 
            // BloodCb
            // 
            this.BloodCb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BloodCb.FormattingEnabled = true;
            this.BloodCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.BloodCb.Location = new System.Drawing.Point(115, 539);
            this.BloodCb.Name = "BloodCb";
            this.BloodCb.Size = new System.Drawing.Size(169, 29);
            this.BloodCb.TabIndex = 8;
            this.BloodCb.Text = "BloodGroup";
            // 
            // MajorDis
            // 
            this.MajorDis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MajorDis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MajorDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MajorDis.HintForeColor = System.Drawing.Color.Empty;
            this.MajorDis.HintText = "";
            this.MajorDis.isPassword = false;
            this.MajorDis.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.MajorDis.LineIdleColor = System.Drawing.Color.Gray;
            this.MajorDis.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.MajorDis.LineThickness = 3;
            this.MajorDis.Location = new System.Drawing.Point(115, 587);
            this.MajorDis.Margin = new System.Windows.Forms.Padding(4);
            this.MajorDis.Name = "MajorDis";
            this.MajorDis.Size = new System.Drawing.Size(169, 42);
            this.MajorDis.TabIndex = 9;
            this.MajorDis.Text = "MajorDis";
            this.MajorDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MajorDis.OnValueChanged += new System.EventHandler(this.MajorDis_OnValueChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(127, 746);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 51);
            this.button4.TabIndex = 14;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(115, 663);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 51);
            this.button3.TabIndex = 13;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(262, 663);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 51);
            this.button2.TabIndex = 12;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(29, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(763, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 50);
            this.label3.TabIndex = 15;
            this.label3.Text = "PATIENTS LIST      ";
            // 
            // PatientGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.PatientGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PatientGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PatientGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.PatientGV.EnableHeadersVisualStyles = false;
            this.PatientGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.Location = new System.Drawing.Point(387, 166);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.RowHeadersVisible = false;
            this.PatientGV.RowHeadersWidth = 40;
            this.PatientGV.RowTemplate.Height = 30;
            this.PatientGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientGV.Size = new System.Drawing.Size(1077, 701);
            this.PatientGV.TabIndex = 16;
            this.PatientGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.BlueViolet;
            this.PatientGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientGV.ThemeStyle.HeaderStyle.Height = 30;
            this.PatientGV.ThemeStyle.ReadOnly = false;
            this.PatientGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PatientGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientGV.ThemeStyle.RowsStyle.Height = 30;
            this.PatientGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18.2F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1428, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 42);
            this.label5.TabIndex = 17;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Patientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1476, 923);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MajorDis);
            this.Controls.Add(this.BloodCb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PatCon);
            this.Controls.Add(this.PatAdd);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patientform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patientform";
            this.Load += new System.EventHandler(this.Patientform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatCon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatAge;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.ComboBox BloodCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MajorDis;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView PatientGV;
        private System.Windows.Forms.Label label5;
    }
}