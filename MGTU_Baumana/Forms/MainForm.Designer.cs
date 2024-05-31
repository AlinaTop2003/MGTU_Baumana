namespace MGTU_Baumana
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnPayReport = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserRole = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnPayReport);
            this.panel1.Controls.Add(this.btnReceipt);
            this.panel1.Controls.Add(this.btnContract);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 530);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Gold;
            this.pnlNav.Location = new System.Drawing.Point(1, 224);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 3;
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStudent.Image = global::MGTU_Baumana.Properties.Resources.студенты;
            this.btnStudent.Location = new System.Drawing.Point(0, 349);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(246, 42);
            this.btnStudent.TabIndex = 4;
            this.btnStudent.Text = "Студенты";
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnPayReport
            // 
            this.btnPayReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayReport.FlatAppearance.BorderSize = 0;
            this.btnPayReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPayReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPayReport.Image = global::MGTU_Baumana.Properties.Resources.отчет;
            this.btnPayReport.Location = new System.Drawing.Point(0, 307);
            this.btnPayReport.Name = "btnPayReport";
            this.btnPayReport.Size = new System.Drawing.Size(246, 42);
            this.btnPayReport.TabIndex = 3;
            this.btnPayReport.Text = "Отчеты";
            this.btnPayReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPayReport.UseVisualStyleBackColor = true;
            this.btnPayReport.Click += new System.EventHandler(this.btnPayReport_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReceipt.Image = global::MGTU_Baumana.Properties.Resources.квитанции;
            this.btnReceipt.Location = new System.Drawing.Point(0, 265);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(246, 42);
            this.btnReceipt.TabIndex = 2;
            this.btnReceipt.Text = "Квитанции";
            this.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnContract
            // 
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContract.FlatAppearance.BorderSize = 0;
            this.btnContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnContract.Image = global::MGTU_Baumana.Properties.Resources.договор__2_;
            this.btnContract.Location = new System.Drawing.Point(0, 223);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(246, 42);
            this.btnContract.TabIndex = 1;
            this.btnContract.Text = "Договора";
            this.btnContract.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UserRole);
            this.panel2.Controls.Add(this.UserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 223);
            this.panel2.TabIndex = 0;
            // 
            // UserRole
            // 
            this.UserRole.AutoSize = true;
            this.UserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserRole.ForeColor = System.Drawing.Color.Gold;
            this.UserRole.Location = new System.Drawing.Point(78, 192);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(71, 16);
            this.UserRole.TabIndex = 2;
            this.UserRole.Text = "User role";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UserName.Location = new System.Drawing.Point(63, 172);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(103, 20);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MGTU_Baumana.Properties.Resources.Gerb_MGTU_imeni_Baumana;
            this.pictureBox1.Location = new System.Drawing.Point(37, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(246, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 530);
            this.panel3.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Location = new System.Drawing.Point(20, 17);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UserRole;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnPayReport;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel3;
    }
}

