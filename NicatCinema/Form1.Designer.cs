namespace CinemaFormApp
{
    partial class Main
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
            this.Posters = new System.Windows.Forms.Panel();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.btsAddSeans = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Posters
            // 
            this.Posters.AutoScroll = true;
            this.Posters.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Posters.Location = new System.Drawing.Point(12, 72);
            this.Posters.Name = "Posters";
            this.Posters.Size = new System.Drawing.Size(1120, 684);
            this.Posters.TabIndex = 0;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(847, 12);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(140, 49);
            this.btnAddFilm.TabIndex = 1;
            this.btnAddFilm.Text = "Add Film";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // btsAddSeans
            // 
            this.btsAddSeans.Location = new System.Drawing.Point(993, 12);
            this.btsAddSeans.Name = "btsAddSeans";
            this.btsAddSeans.Size = new System.Drawing.Size(139, 49);
            this.btsAddSeans.TabIndex = 2;
            this.btsAddSeans.Text = "Add Seans";
            this.btsAddSeans.UseVisualStyleBackColor = true;
            this.btsAddSeans.Click += new System.EventHandler(this.btsAddSeans_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(12, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(190, 32);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "lblUserName";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1150, 768);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btsAddSeans);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.Posters);
            this.Name = "Main";
            this.Text = "Cinema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Posters;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.Button btsAddSeans;
        private System.Windows.Forms.Label lblUserName;
    }
}

