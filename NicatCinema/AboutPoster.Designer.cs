namespace CinemaFormApp
{
    partial class AboutPoster
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
            this.FilmBigPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.random = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FilmTitle = new System.Windows.Forms.Label();
            this.FilmDuration = new System.Windows.Forms.Label();
            this.FilmDate = new System.Windows.Forms.Label();
            this.FilmLanguage = new System.Windows.Forms.Label();
            this.FilmRestriction = new System.Windows.Forms.Label();
            this.SeansOfFilm = new System.Windows.Forms.DataGridView();
            this.FilmDescription = new System.Windows.Forms.RichTextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyTicket = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FilmBigPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeansOfFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmBigPhoto
            // 
            this.FilmBigPhoto.Location = new System.Drawing.Point(15, 23);
            this.FilmBigPhoto.Margin = new System.Windows.Forms.Padding(6);
            this.FilmBigPhoto.Name = "FilmBigPhoto";
            this.FilmBigPhoto.Size = new System.Drawing.Size(252, 287);
            this.FilmBigPhoto.TabIndex = 0;
            this.FilmBigPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Restriction";
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random.Location = new System.Drawing.Point(307, 139);
            this.random.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(113, 26);
            this.random.TabIndex = 4;
            this.random.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Duration";
            // 
            // FilmTitle
            // 
            this.FilmTitle.AutoSize = true;
            this.FilmTitle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmTitle.Location = new System.Drawing.Point(478, 25);
            this.FilmTitle.Name = "FilmTitle";
            this.FilmTitle.Size = new System.Drawing.Size(51, 19);
            this.FilmTitle.TabIndex = 7;
            this.FilmTitle.Text = "label7";
            // 
            // FilmDuration
            // 
            this.FilmDuration.AutoSize = true;
            this.FilmDuration.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmDuration.Location = new System.Drawing.Point(478, 64);
            this.FilmDuration.Name = "FilmDuration";
            this.FilmDuration.Size = new System.Drawing.Size(51, 19);
            this.FilmDuration.TabIndex = 8;
            this.FilmDuration.Text = "label8";
            // 
            // FilmDate
            // 
            this.FilmDate.AutoSize = true;
            this.FilmDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmDate.Location = new System.Drawing.Point(478, 102);
            this.FilmDate.Name = "FilmDate";
            this.FilmDate.Size = new System.Drawing.Size(51, 19);
            this.FilmDate.TabIndex = 9;
            this.FilmDate.Text = "label9";
            // 
            // FilmLanguage
            // 
            this.FilmLanguage.AutoSize = true;
            this.FilmLanguage.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmLanguage.Location = new System.Drawing.Point(478, 144);
            this.FilmLanguage.Name = "FilmLanguage";
            this.FilmLanguage.Size = new System.Drawing.Size(60, 19);
            this.FilmLanguage.TabIndex = 10;
            this.FilmLanguage.Text = "label10";
            // 
            // FilmRestriction
            // 
            this.FilmRestriction.AutoSize = true;
            this.FilmRestriction.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmRestriction.Location = new System.Drawing.Point(478, 179);
            this.FilmRestriction.Name = "FilmRestriction";
            this.FilmRestriction.Size = new System.Drawing.Size(59, 19);
            this.FilmRestriction.TabIndex = 11;
            this.FilmRestriction.Text = "label11";
            // 
            // SeansOfFilm
            // 
            this.SeansOfFilm.AllowUserToAddRows = false;
            this.SeansOfFilm.AllowUserToDeleteRows = false;
            this.SeansOfFilm.AllowUserToResizeColumns = false;
            this.SeansOfFilm.AllowUserToResizeRows = false;
            this.SeansOfFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeansOfFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeansOfFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.HallId,
            this.Order,
            this.HallName,
            this.Date,
            this.Time,
            this.BuyTicket});
            this.SeansOfFilm.Location = new System.Drawing.Point(15, 332);
            this.SeansOfFilm.Name = "SeansOfFilm";
            this.SeansOfFilm.ReadOnly = true;
            this.SeansOfFilm.RowTemplate.Height = 24;
            this.SeansOfFilm.Size = new System.Drawing.Size(715, 287);
            this.SeansOfFilm.TabIndex = 13;
            this.SeansOfFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeansOfFilm_CellClick);
            // 
            // FilmDescription
            // 
            this.FilmDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmDescription.Location = new System.Drawing.Point(482, 214);
            this.FilmDescription.Name = "FilmDescription";
            this.FilmDescription.Size = new System.Drawing.Size(248, 96);
            this.FilmDescription.TabIndex = 14;
            this.FilmDescription.Text = "";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // HallId
            // 
            this.HallId.HeaderText = "HallId";
            this.HallId.Name = "HallId";
            this.HallId.ReadOnly = true;
            this.HallId.Visible = false;
            // 
            // Order
            // 
            this.Order.HeaderText = "No";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // HallName
            // 
            this.HallName.HeaderText = "Hall";
            this.HallName.Name = "HallName";
            this.HallName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // BuyTicket
            // 
            this.BuyTicket.HeaderText = "Buy";
            this.BuyTicket.Name = "BuyTicket";
            this.BuyTicket.ReadOnly = true;
            // 
            // AboutPoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 631);
            this.Controls.Add(this.FilmDescription);
            this.Controls.Add(this.SeansOfFilm);
            this.Controls.Add(this.FilmRestriction);
            this.Controls.Add(this.FilmLanguage);
            this.Controls.Add(this.FilmDate);
            this.Controls.Add(this.FilmDuration);
            this.Controls.Add(this.FilmTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.random);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilmBigPhoto);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AboutPoster";
            this.Text = "AboutPoster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutPoster_FormClosing);
            this.Load += new System.EventHandler(this.AboutPoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmBigPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeansOfFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FilmBigPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label random;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FilmTitle;
        private System.Windows.Forms.Label FilmDuration;
        private System.Windows.Forms.Label FilmDate;
        private System.Windows.Forms.Label FilmLanguage;
        private System.Windows.Forms.Label FilmRestriction;
        private System.Windows.Forms.DataGridView SeansOfFilm;
        private System.Windows.Forms.RichTextBox FilmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewButtonColumn BuyTicket;
    }
}