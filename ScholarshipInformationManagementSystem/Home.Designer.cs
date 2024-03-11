
namespace ScholarshipInformationManagementSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Button();
            this.ScholarshipForm1 = new System.Windows.Forms.Label();
            this.ScholarshipCategory = new System.Windows.Forms.Label();
            this.ScholarshipType = new System.Windows.Forms.Label();
            this.ViewScholars = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Administrator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.ScholarshipForm1);
            this.panel1.Controls.Add(this.ScholarshipCategory);
            this.panel1.Controls.Add(this.ScholarshipType);
            this.panel1.Controls.Add(this.ViewScholars);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Administrator);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 432);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(47, 394);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(66, 23);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            // 
            // ScholarshipForm1
            // 
            this.ScholarshipForm1.AutoSize = true;
            this.ScholarshipForm1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScholarshipForm1.ForeColor = System.Drawing.Color.White;
            this.ScholarshipForm1.Location = new System.Drawing.Point(28, 266);
            this.ScholarshipForm1.Name = "ScholarshipForm1";
            this.ScholarshipForm1.Size = new System.Drawing.Size(111, 20);
            this.ScholarshipForm1.TabIndex = 5;
            this.ScholarshipForm1.Text = "Scholarship Form ";
            this.ScholarshipForm1.Click += new System.EventHandler(this.ScholarshipForm1_Click);
            // 
            // ScholarshipCategory
            // 
            this.ScholarshipCategory.AutoSize = true;
            this.ScholarshipCategory.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScholarshipCategory.ForeColor = System.Drawing.Color.White;
            this.ScholarshipCategory.Location = new System.Drawing.Point(28, 206);
            this.ScholarshipCategory.Name = "ScholarshipCategory";
            this.ScholarshipCategory.Size = new System.Drawing.Size(127, 20);
            this.ScholarshipCategory.TabIndex = 4;
            this.ScholarshipCategory.Text = "Scholarship Category";
            this.ScholarshipCategory.Click += new System.EventHandler(this.ScholarshipCategory_Click);
            // 
            // ScholarshipType
            // 
            this.ScholarshipType.AutoSize = true;
            this.ScholarshipType.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScholarshipType.ForeColor = System.Drawing.Color.White;
            this.ScholarshipType.Location = new System.Drawing.Point(28, 236);
            this.ScholarshipType.Name = "ScholarshipType";
            this.ScholarshipType.Size = new System.Drawing.Size(106, 20);
            this.ScholarshipType.TabIndex = 3;
            this.ScholarshipType.Text = "Scholarship Type";
            this.ScholarshipType.Click += new System.EventHandler(this.ScholarshipType_Click);
            // 
            // ViewScholars
            // 
            this.ViewScholars.AutoSize = true;
            this.ViewScholars.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewScholars.ForeColor = System.Drawing.Color.White;
            this.ViewScholars.Location = new System.Drawing.Point(28, 297);
            this.ViewScholars.Name = "ViewScholars";
            this.ViewScholars.Size = new System.Drawing.Size(101, 20);
            this.ViewScholars.TabIndex = 2;
            this.ViewScholars.Text = "Search Scholars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCHOLARSHIP";
            // 
            // Administrator
            // 
            this.Administrator.AutoSize = true;
            this.Administrator.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrator.ForeColor = System.Drawing.Color.White;
            this.Administrator.Location = new System.Drawing.Point(43, 123);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(81, 20);
            this.Administrator.TabIndex = 0;
            this.Administrator.Text = "Administrator";
            this.Administrator.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(251, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "CENTER FOR SCHOLARSHIPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(257, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "AND FINANCIAL ASSISTANCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "MAPUA UNIVERSITY";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(809, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label ScholarshipForm1;
        private System.Windows.Forms.Label ScholarshipCategory;
        private System.Windows.Forms.Label ScholarshipType;
        private System.Windows.Forms.Label ViewScholars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Administrator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

