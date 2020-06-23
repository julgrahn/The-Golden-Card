namespace The_Golden_Card
{
    partial class Guldkortet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guldkortet));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartServer = new System.Windows.Forms.Button();
            this.UpdateUsers = new System.Windows.Forms.Button();
            this.UpdateCard = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DataReceived = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(55, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartServer
            // 
            this.StartServer.Location = new System.Drawing.Point(55, 190);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(183, 23);
            this.StartServer.TabIndex = 1;
            this.StartServer.Text = "Start the Server";
            this.StartServer.UseVisualStyleBackColor = true;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // UpdateUsers
            // 
            this.UpdateUsers.Location = new System.Drawing.Point(55, 220);
            this.UpdateUsers.Name = "UpdateUsers";
            this.UpdateUsers.Size = new System.Drawing.Size(183, 23);
            this.UpdateUsers.TabIndex = 2;
            this.UpdateUsers.Text = "Update Userlist";
            this.UpdateUsers.UseVisualStyleBackColor = true;
            // 
            // UpdateCard
            // 
            this.UpdateCard.Location = new System.Drawing.Point(55, 250);
            this.UpdateCard.Name = "UpdateCard";
            this.UpdateCard.Size = new System.Drawing.Size(183, 23);
            this.UpdateCard.TabIndex = 3;
            this.UpdateCard.Text = "Update Cardlist";
            this.UpdateCard.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(55, 279);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(183, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // DataReceived
            // 
            this.DataReceived.FormattingEnabled = true;
            this.DataReceived.Location = new System.Drawing.Point(245, 13);
            this.DataReceived.Name = "DataReceived";
            this.DataReceived.Size = new System.Drawing.Size(302, 290);
            this.DataReceived.TabIndex = 5;
            // 
            // Guldkortet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 327);
            this.Controls.Add(this.DataReceived);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.UpdateCard);
            this.Controls.Add(this.UpdateUsers);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Guldkortet";
            this.Text = "Guldkortet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.Button UpdateUsers;
        private System.Windows.Forms.Button UpdateCard;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox DataReceived;
    }
}

