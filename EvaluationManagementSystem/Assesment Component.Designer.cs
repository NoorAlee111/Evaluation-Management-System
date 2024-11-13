
namespace Midproject
{
    partial class AssesmentComponent
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.Label();
            this.TotalMarks = new System.Windows.Forms.TextBox();
            this.Regno = new System.Windows.Forms.Label();
            this.AssesmentComponentName = new System.Windows.Forms.TextBox();
            this.RubricID = new System.Windows.Forms.ComboBox();
            this.AssesmentID = new System.Windows.Forms.ComboBox();
            this.DateCreated = new System.Windows.Forms.DateTimePicker();
            this.DateUpdated = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.Email, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Contact, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Lastname, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Firstname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TotalMarks, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Regno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AssesmentComponentName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RubricID, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.AssesmentID, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.DateCreated, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateUpdated, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.40964F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.42169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.45894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1041, 454);
            this.tableLayoutPanel1.TabIndex = 41;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Sylfaen", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1035, 62);
            this.label1.TabIndex = 42;
            this.label1.Text = "Assesments Components";
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Status.Location = new System.Drawing.Point(3, 387);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(326, 32);
            this.Status.TabIndex = 40;
            this.Status.Text = "AssesmentID";
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Email.Location = new System.Drawing.Point(3, 328);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(326, 32);
            this.Email.TabIndex = 38;
            this.Email.Text = "RubricID";
            // 
            // Contact
            // 
            this.Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Contact.Location = new System.Drawing.Point(3, 266);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(326, 32);
            this.Contact.TabIndex = 36;
            this.Contact.Text = "Date Updated";
            // 
            // Lastname
            // 
            this.Lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lastname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lastname.Location = new System.Drawing.Point(3, 206);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(326, 32);
            this.Lastname.TabIndex = 23;
            this.Lastname.Text = "Date Created";
            // 
            // Firstname
            // 
            this.Firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Firstname.AutoSize = true;
            this.Firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Firstname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Firstname.Location = new System.Drawing.Point(3, 151);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(326, 32);
            this.Firstname.TabIndex = 21;
            this.Firstname.Text = "Total Marks";
            // 
            // TotalMarks
            // 
            this.TotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalMarks.Location = new System.Drawing.Point(335, 152);
            this.TotalMarks.Name = "TotalMarks";
            this.TotalMarks.Size = new System.Drawing.Size(703, 31);
            this.TotalMarks.TabIndex = 24;
            this.TotalMarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalMarks_KeyPress);
            // 
            // Regno
            // 
            this.Regno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Regno.AutoSize = true;
            this.Regno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Regno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Regno.Location = new System.Drawing.Point(3, 97);
            this.Regno.Name = "Regno";
            this.Regno.Size = new System.Drawing.Size(326, 32);
            this.Regno.TabIndex = 19;
            this.Regno.Text = "Name";
            // 
            // AssesmentComponentName
            // 
            this.AssesmentComponentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AssesmentComponentName.Location = new System.Drawing.Point(335, 97);
            this.AssesmentComponentName.Name = "AssesmentComponentName";
            this.AssesmentComponentName.Size = new System.Drawing.Size(703, 31);
            this.AssesmentComponentName.TabIndex = 25;
            // 
            // RubricID
            // 
            this.RubricID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricID.FormattingEnabled = true;
            this.RubricID.Location = new System.Drawing.Point(335, 327);
            this.RubricID.Name = "RubricID";
            this.RubricID.Size = new System.Drawing.Size(703, 33);
            this.RubricID.TabIndex = 41;
            this.RubricID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RubricID_KeyPress);
            // 
            // AssesmentID
            // 
            this.AssesmentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AssesmentID.FormattingEnabled = true;
            this.AssesmentID.Location = new System.Drawing.Point(335, 386);
            this.AssesmentID.Name = "AssesmentID";
            this.AssesmentID.Size = new System.Drawing.Size(703, 33);
            this.AssesmentID.TabIndex = 43;
            this.AssesmentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssesmentID_KeyPress);
            // 
            // DateCreated
            // 
            this.DateCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateCreated.Location = new System.Drawing.Point(335, 206);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(703, 31);
            this.DateCreated.TabIndex = 49;
            // 
            // DateUpdated
            // 
            this.DateUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateUpdated.Location = new System.Drawing.Point(335, 266);
            this.DateUpdated.Name = "DateUpdated";
            this.DateUpdated.Size = new System.Drawing.Size(703, 31);
            this.DateUpdated.TabIndex = 50;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1236F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.45506F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.474719F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.61517F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Update, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Show, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Search, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Insert, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 524);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1424, 389);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1418, 326);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContextMenuStripChanged);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(374, 11);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(327, 34);
            this.Search.TabIndex = 35;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Insert
            // 
            this.Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Insert.Location = new System.Drawing.Point(3, 11);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(365, 34);
            this.Insert.TabIndex = 36;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.Location = new System.Drawing.Point(727, 11);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(314, 34);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Show
            // 
            this.Show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Show.Location = new System.Drawing.Point(1047, 11);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(374, 34);
            this.Show.TabIndex = 39;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // AssesmentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1544, 925);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AssesmentComponent";
            this.Text = "Assesment Component";
            this.Load += new System.EventHandler(this.AssesmentComponent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox RubricID;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.TextBox TotalMarks;
        private System.Windows.Forms.Label Regno;
        private System.Windows.Forms.TextBox AssesmentComponentName;
        private System.Windows.Forms.ComboBox AssesmentID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.DateTimePicker DateCreated;
        private System.Windows.Forms.DateTimePicker DateUpdated;
    }
}