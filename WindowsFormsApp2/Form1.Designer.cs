namespace WindowsFormsApp2
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
            this.LVGolf = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suburb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Handicap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LVGolf
            // 
            this.LVGolf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Firstname,
            this.Surname,
            this.Gender,
            this.Dob,
            this.Street,
            this.City,
            this.Suburb,
            this.Available,
            this.Handicap});
            this.LVGolf.Location = new System.Drawing.Point(2, 0);
            this.LVGolf.Name = "LVGolf";
            this.LVGolf.Size = new System.Drawing.Size(833, 261);
            this.LVGolf.TabIndex = 0;
            this.LVGolf.UseCompatibleStateImageBehavior = false;
            this.LVGolf.View = System.Windows.Forms.View.Details;
            this.LVGolf.SelectedIndexChanged += new System.EventHandler(this.LVGolf_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // Firstname
            // 
            this.Firstname.Text = "First Name";
            this.Firstname.Width = 79;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // Dob
            // 
            this.Dob.Text = "DOB";
            // 
            // Street
            // 
            this.Street.Text = "Street";
            // 
            // City
            // 
            this.City.Text = "City";
            // 
            // Suburb
            // 
            this.Suburb.Text = "Suburb";
            // 
            // Available
            // 
            this.Available.Text = "Available";
            // 
            // Handicap
            // 
            this.Handicap.Text = "Handicap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.LVGolf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVGolf;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Firstname;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Dob;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Suburb;
        private System.Windows.Forms.ColumnHeader Available;
        private System.Windows.Forms.ColumnHeader Handicap;
    }
}

