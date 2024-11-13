
namespace Midproject
{
    partial class StudentResult
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.Label();
            this.Regno = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.ComboBox();
            this.AssesmentComponentID = new System.Windows.Forms.ComboBox();
            this.RubricMeasurmentId = new System.Windows.Forms.ComboBox();
            this.AssesmentIdl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EvaluationDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.78603F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.8209F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28358F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Show, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.Update, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.Insert, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 442);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1340, 422);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.dataGridView2, 5);
            this.dataGridView2.Location = new System.Drawing.Point(3, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1334, 367);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Insert
            // 
            this.Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Insert.Location = new System.Drawing.Point(560, 7);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(239, 34);
            this.Insert.TabIndex = 36;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.Location = new System.Drawing.Point(805, 7);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(262, 34);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Show
            // 
            this.Show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Show.Location = new System.Drawing.Point(1073, 7);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(264, 34);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.70234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.29765F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Regno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StudentID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lastname, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.RubricMeasurmentId, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Firstname, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AssesmentIdl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AssesmentComponentID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EvaluationDate, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.40964F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.11221F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.10231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.34324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 414);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Sylfaen", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(975, 62);
            this.label1.TabIndex = 42;
            this.label1.Text = "Student Result";
            // 
            // Lastname
            // 
            this.Lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lastname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lastname.Location = new System.Drawing.Point(3, 300);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(305, 32);
            this.Lastname.TabIndex = 23;
            this.Lastname.Text = "Rubric Measurment Level";
            // 
            // Firstname
            // 
            this.Firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Firstname.AutoSize = true;
            this.Firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Firstname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Firstname.Location = new System.Drawing.Point(3, 219);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(305, 32);
            this.Firstname.TabIndex = 21;
            this.Firstname.Text = "Assesment Component ID";
            // 
            // Regno
            // 
            this.Regno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Regno.AutoSize = true;
            this.Regno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Regno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Regno.Location = new System.Drawing.Point(3, 78);
            this.Regno.Name = "Regno";
            this.Regno.Size = new System.Drawing.Size(305, 32);
            this.Regno.TabIndex = 19;
            this.Regno.Text = "Student ID";
            // 
            // StudentID
            // 
            this.StudentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentID.FormattingEnabled = true;
            this.StudentID.Location = new System.Drawing.Point(314, 77);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(664, 33);
            this.StudentID.TabIndex = 45;
            // 
            // AssesmentComponentID
            // 
            this.AssesmentComponentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AssesmentComponentID.FormattingEnabled = true;
            this.AssesmentComponentID.Location = new System.Drawing.Point(314, 219);
            this.AssesmentComponentID.Name = "AssesmentComponentID";
            this.AssesmentComponentID.Size = new System.Drawing.Size(664, 33);
            this.AssesmentComponentID.TabIndex = 46;
            // 
            // RubricMeasurmentId
            // 
            this.RubricMeasurmentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricMeasurmentId.FormattingEnabled = true;
            this.RubricMeasurmentId.Location = new System.Drawing.Point(314, 299);
            this.RubricMeasurmentId.Name = "RubricMeasurmentId";
            this.RubricMeasurmentId.Size = new System.Drawing.Size(664, 33);
            this.RubricMeasurmentId.TabIndex = 48;
            // 
            // AssesmentIdl
            // 
            this.AssesmentIdl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AssesmentIdl.FormattingEnabled = true;
            this.AssesmentIdl.Location = new System.Drawing.Point(314, 141);
            this.AssesmentIdl.Name = "AssesmentIdl";
            this.AssesmentIdl.Size = new System.Drawing.Size(664, 33);
            this.AssesmentIdl.TabIndex = 49;
            this.AssesmentIdl.SelectedIndexChanged += new System.EventHandler(this.AssesmentIdl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Assesment ID\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Evaluation Date";
            // 
            // EvaluationDate
            // 
            this.EvaluationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluationDate.Location = new System.Drawing.Point(314, 359);
            this.EvaluationDate.Name = "EvaluationDate";
            this.EvaluationDate.Size = new System.Drawing.Size(664, 31);
            this.EvaluationDate.TabIndex = 51;
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1364, 891);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "StudentResult";
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.StudentResult_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label Regno;
        private System.Windows.Forms.ComboBox StudentID;
        private System.Windows.Forms.ComboBox AssesmentComponentID;
        private System.Windows.Forms.ComboBox RubricMeasurmentId;
        private System.Windows.Forms.ComboBox AssesmentIdl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EvaluationDate;
    }
}