
namespace Midproject
{
    partial class Students
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Statusc = new System.Windows.Forms.ComboBox();
            this.Email = new System.Windows.Forms.Label();
            this.Emailt = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.Label();
            this.Contactt = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.Label();
            this.LastNamet = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.Label();
            this.FirstNamet = new System.Windows.Forms.TextBox();
            this.Regno = new System.Windows.Forms.Label();
            this.RegistrationNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.78603F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0393F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08734F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Delete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Insert, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Update, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Show, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(35, 586);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1373, 377);
            this.tableLayoutPanel2.TabIndex = 40;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.Location = new System.Drawing.Point(3, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1367, 307);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Location = new System.Drawing.Point(288, 13);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(255, 34);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(549, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(270, 34);
            this.Search.TabIndex = 35;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Insert
            // 
            this.Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Insert.Location = new System.Drawing.Point(3, 13);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(279, 34);
            this.Insert.TabIndex = 36;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.Location = new System.Drawing.Point(825, 13);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(268, 34);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show
            // 
            this.Show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Show.Location = new System.Drawing.Point(1099, 13);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(271, 34);
            this.Show.TabIndex = 39;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.96931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.03069F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Status, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Statusc, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Email, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Emailt, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Contact, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Contactt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Lastname, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LastNamet, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Firstname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FirstNamet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Regno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RegistrationNumber, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.40964F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.42169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.45894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 475);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 62);
            this.label1.TabIndex = 42;
            this.label1.Text = "Students\r\n";
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Status.Location = new System.Drawing.Point(3, 429);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(275, 32);
            this.Status.TabIndex = 40;
            this.Status.Text = "Status";
            // 
            // Statusc
            // 
            this.Statusc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Statusc.FormattingEnabled = true;
            this.Statusc.Location = new System.Drawing.Point(284, 428);
            this.Statusc.Name = "Statusc";
            this.Statusc.Size = new System.Drawing.Size(592, 33);
            this.Statusc.TabIndex = 41;
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Email.Location = new System.Drawing.Point(3, 364);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(275, 32);
            this.Email.TabIndex = 38;
            this.Email.Text = "Email";
            // 
            // Emailt
            // 
            this.Emailt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Emailt.Location = new System.Drawing.Point(284, 365);
            this.Emailt.Name = "Emailt";
            this.Emailt.Size = new System.Drawing.Size(592, 31);
            this.Emailt.TabIndex = 39;
            this.Emailt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Emailt_KeyPress);
            // 
            // Contact
            // 
            this.Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Contact.Location = new System.Drawing.Point(3, 295);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(275, 32);
            this.Contact.TabIndex = 36;
            this.Contact.Text = "Contact";
            // 
            // Contactt
            // 
            this.Contactt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Contactt.Location = new System.Drawing.Point(284, 296);
            this.Contactt.Name = "Contactt";
            this.Contactt.Size = new System.Drawing.Size(592, 31);
            this.Contactt.TabIndex = 37;
            this.Contactt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contactt_KeyPress);
            // 
            // Lastname
            // 
            this.Lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lastname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lastname.Location = new System.Drawing.Point(3, 229);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(275, 32);
            this.Lastname.TabIndex = 23;
            this.Lastname.Text = "Last Name";
            // 
            // LastNamet
            // 
            this.LastNamet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNamet.Location = new System.Drawing.Point(284, 229);
            this.LastNamet.Name = "LastNamet";
            this.LastNamet.Size = new System.Drawing.Size(592, 31);
            this.LastNamet.TabIndex = 26;
            this.LastNamet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNamet_KeyPress);
            // 
            // Firstname
            // 
            this.Firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Firstname.AutoSize = true;
            this.Firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Firstname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Firstname.Location = new System.Drawing.Point(3, 169);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(275, 32);
            this.Firstname.TabIndex = 21;
            this.Firstname.Text = "First Name";
            // 
            // FirstNamet
            // 
            this.FirstNamet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNamet.Location = new System.Drawing.Point(284, 169);
            this.FirstNamet.Name = "FirstNamet";
            this.FirstNamet.Size = new System.Drawing.Size(592, 31);
            this.FirstNamet.TabIndex = 24;
            this.FirstNamet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNamet_KeyPress);
            // 
            // Regno
            // 
            this.Regno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Regno.AutoSize = true;
            this.Regno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Regno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Regno.Location = new System.Drawing.Point(3, 109);
            this.Regno.Name = "Regno";
            this.Regno.Size = new System.Drawing.Size(275, 32);
            this.Regno.TabIndex = 19;
            this.Regno.Text = "RegistrationNumber";
            // 
            // RegistrationNumber
            // 
            this.RegistrationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationNumber.Location = new System.Drawing.Point(284, 109);
            this.RegistrationNumber.Name = "RegistrationNumber";
            this.RegistrationNumber.Size = new System.Drawing.Size(592, 31);
            this.RegistrationNumber.TabIndex = 25;
            this.RegistrationNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegistrationNumber_KeyPress);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1487, 970);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Regno;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.TextBox FirstNamet;
        private System.Windows.Forms.TextBox RegistrationNumber;
        private System.Windows.Forms.TextBox LastNamet;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.TextBox Contactt;
        private System.Windows.Forms.TextBox Emailt;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox Statusc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

