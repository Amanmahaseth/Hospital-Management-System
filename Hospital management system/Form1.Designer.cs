namespace Hospital_management_system
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PassTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.DocNameTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.PassTb);
            this.panel1.Controls.Add(this.DocNameTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 539);
            this.panel1.TabIndex = 0;
            // 
            // PassTb
            // 
            this.PassTb.BorderColorFocused = System.Drawing.Color.Blue;
            this.PassTb.BorderColorIdle = System.Drawing.Color.Purple;
            this.PassTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.PassTb.BorderThickness = 3;
            this.PassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassTb.ForeColor = System.Drawing.Color.Purple;
            this.PassTb.isPassword = true;
            this.PassTb.Location = new System.Drawing.Point(68, 271);
            this.PassTb.Margin = new System.Windows.Forms.Padding(4);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(281, 44);
            this.PassTb.TabIndex = 2;
            this.PassTb.Text = "DocPassword";
            this.PassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassTb.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged_1);
            // 
            // DocNameTb
            // 
            this.DocNameTb.BorderColorFocused = System.Drawing.Color.Blue;
            this.DocNameTb.BorderColorIdle = System.Drawing.Color.Purple;
            this.DocNameTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.DocNameTb.BorderThickness = 3;
            this.DocNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocNameTb.ForeColor = System.Drawing.Color.Purple;
            this.DocNameTb.isPassword = false;
            this.DocNameTb.Location = new System.Drawing.Point(68, 191);
            this.DocNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.DocNameTb.Name = "DocNameTb";
            this.DocNameTb.Size = new System.Drawing.Size(281, 44);
            this.DocNameTb.TabIndex = 2;
            this.DocNameTb.Text = "DocName";
            this.DocNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DocNameTb.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(133, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clear";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(97, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 123);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(107, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "HMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 507);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox DocNameTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox PassTb;
    }
}

