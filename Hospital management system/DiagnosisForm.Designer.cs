namespace Hospital_management_system
{
    partial class DiagnosisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.PatientTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SymptomsTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DiagnosisTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MedicineTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Medicineslbl = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.Patientlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1376, 134);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(601, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "DIAGNOSIS";
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
            // DiagId
            // 
            this.DiagId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiagId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DiagId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiagId.HintForeColor = System.Drawing.Color.Empty;
            this.DiagId.HintText = "";
            this.DiagId.isPassword = false;
            this.DiagId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DiagId.LineIdleColor = System.Drawing.Color.Gray;
            this.DiagId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DiagId.LineThickness = 3;
            this.DiagId.Location = new System.Drawing.Point(47, 157);
            this.DiagId.Margin = new System.Windows.Forms.Padding(4);
            this.DiagId.Name = "DiagId";
            this.DiagId.Size = new System.Drawing.Size(169, 44);
            this.DiagId.TabIndex = 3;
            this.DiagId.Text = "DiagnosisId";
            this.DiagId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Location = new System.Drawing.Point(47, 226);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(169, 29);
            this.PatientIdCb.TabIndex = 8;
            this.PatientIdCb.Text = "PatientId";
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // PatientTb
            // 
            this.PatientTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientTb.Enabled = false;
            this.PatientTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatientTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatientTb.HintForeColor = System.Drawing.Color.Empty;
            this.PatientTb.HintText = "";
            this.PatientTb.isPassword = false;
            this.PatientTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatientTb.LineIdleColor = System.Drawing.Color.Gray;
            this.PatientTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatientTb.LineThickness = 3;
            this.PatientTb.Location = new System.Drawing.Point(47, 272);
            this.PatientTb.Margin = new System.Windows.Forms.Padding(4);
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.Size = new System.Drawing.Size(169, 44);
            this.PatientTb.TabIndex = 9;
            this.PatientTb.Text = "PatientName";
            this.PatientTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PatientTb.OnValueChanged += new System.EventHandler(this.PatientTb_OnValueChanged);
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SymptomsTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SymptomsTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SymptomsTb.HintForeColor = System.Drawing.Color.Empty;
            this.SymptomsTb.HintText = "";
            this.SymptomsTb.isPassword = false;
            this.SymptomsTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.SymptomsTb.LineIdleColor = System.Drawing.Color.Gray;
            this.SymptomsTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.SymptomsTb.LineThickness = 3;
            this.SymptomsTb.Location = new System.Drawing.Point(332, 159);
            this.SymptomsTb.Margin = new System.Windows.Forms.Padding(4);
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.Size = new System.Drawing.Size(169, 44);
            this.SymptomsTb.TabIndex = 10;
            this.SymptomsTb.Text = "Symptoms";
            this.SymptomsTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiagnosisTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DiagnosisTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiagnosisTb.HintForeColor = System.Drawing.Color.Empty;
            this.DiagnosisTb.HintText = "";
            this.DiagnosisTb.isPassword = false;
            this.DiagnosisTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DiagnosisTb.LineIdleColor = System.Drawing.Color.Gray;
            this.DiagnosisTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DiagnosisTb.LineThickness = 3;
            this.DiagnosisTb.Location = new System.Drawing.Point(332, 211);
            this.DiagnosisTb.Margin = new System.Windows.Forms.Padding(4);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(169, 44);
            this.DiagnosisTb.TabIndex = 11;
            this.DiagnosisTb.Text = "Diagnosis";
            this.DiagnosisTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MedicineTb
            // 
            this.MedicineTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicineTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MedicineTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedicineTb.HintForeColor = System.Drawing.Color.Empty;
            this.MedicineTb.HintText = "";
            this.MedicineTb.isPassword = false;
            this.MedicineTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.MedicineTb.LineIdleColor = System.Drawing.Color.Gray;
            this.MedicineTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.MedicineTb.LineThickness = 3;
            this.MedicineTb.Location = new System.Drawing.Point(332, 272);
            this.MedicineTb.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineTb.Name = "MedicineTb";
            this.MedicineTb.Size = new System.Drawing.Size(169, 44);
            this.MedicineTb.TabIndex = 12;
            this.MedicineTb.Text = "Medicines";
            this.MedicineTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Purple;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(47, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 51);
            this.button5.TabIndex = 15;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Purple;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(332, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 51);
            this.button6.TabIndex = 16;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Purple;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(157, 360);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 51);
            this.button7.TabIndex = 17;
            this.button7.Text = "UPDATE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Purple;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(172, 443);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 51);
            this.button8.TabIndex = 18;
            this.button8.Text = "HOME";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(514, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 41);
            this.label3.TabIndex = 20;
            this.label3.Text = "DIAGNOSIS LIST      ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Medicineslbl);
            this.panel2.Controls.Add(this.Diagnosislbl);
            this.panel2.Controls.Add(this.Symptomslbl);
            this.panel2.Controls.Add(this.Patientlbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(542, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 387);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18.2F);
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(52, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(488, 42);
            this.label10.TabIndex = 9;
            this.label10.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Medicineslbl
            // 
            this.Medicineslbl.AutoSize = true;
            this.Medicineslbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medicineslbl.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Medicineslbl.ForeColor = System.Drawing.Color.Purple;
            this.Medicineslbl.Location = new System.Drawing.Point(404, 174);
            this.Medicineslbl.Name = "Medicineslbl";
            this.Medicineslbl.Size = new System.Drawing.Size(153, 41);
            this.Medicineslbl.TabIndex = 7;
            this.Medicineslbl.Text = "Medicines";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diagnosislbl.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Diagnosislbl.ForeColor = System.Drawing.Color.Purple;
            this.Diagnosislbl.Location = new System.Drawing.Point(404, 92);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(147, 41);
            this.Diagnosislbl.TabIndex = 6;
            this.Diagnosislbl.Text = "Diagnosis";
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Symptomslbl.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Symptomslbl.ForeColor = System.Drawing.Color.Purple;
            this.Symptomslbl.Location = new System.Drawing.Point(31, 174);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(159, 41);
            this.Symptomslbl.TabIndex = 5;
            this.Symptomslbl.Text = "Symptoms";
            this.Symptomslbl.Click += new System.EventHandler(this.Symptomslbl_Click);
            // 
            // Patientlbl
            // 
            this.Patientlbl.AutoSize = true;
            this.Patientlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patientlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientlbl.ForeColor = System.Drawing.Color.Purple;
            this.Patientlbl.Location = new System.Drawing.Point(31, 92);
            this.Patientlbl.Name = "Patientlbl";
            this.Patientlbl.Size = new System.Drawing.Size(188, 41);
            this.Patientlbl.TabIndex = 4;
            this.Patientlbl.Text = "PatientName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(126, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // DiagnosisGV
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.DiagnosisGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiagnosisGV.BackgroundColor = System.Drawing.Color.White;
            this.DiagnosisGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.DiagnosisGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisGV.DefaultCellStyle = dataGridViewCellStyle24;
            this.DiagnosisGV.EnableHeadersVisualStyles = false;
            this.DiagnosisGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.Location = new System.Drawing.Point(80, 636);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowHeadersVisible = false;
            this.DiagnosisGV.RowHeadersWidth = 40;
            this.DiagnosisGV.RowTemplate.Height = 30;
            this.DiagnosisGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiagnosisGV.Size = new System.Drawing.Size(1226, 210);
            this.DiagnosisGV.TabIndex = 22;
            this.DiagnosisGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.BlueViolet;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.Height = 30;
            this.DiagnosisGV.ThemeStyle.ReadOnly = false;
            this.DiagnosisGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DiagnosisGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGV.ThemeStyle.RowsStyle.Height = 30;
            this.DiagnosisGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(889, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18.2F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1328, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 858);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.MedicineTb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.DiagId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DiagId;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatientTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SymptomsTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DiagnosisTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MedicineTb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Symptomslbl;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Medicineslbl;
        private System.Windows.Forms.Label Diagnosislbl;
        private Guna.UI.WinForms.GunaDataGridView DiagnosisGV;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
    }
}