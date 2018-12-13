namespace WerewolfClient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.TBServer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.server = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbLogin
            // 
            this.TbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLogin.Location = new System.Drawing.Point(59, 377);
            this.TbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(455, 41);
            this.TbLogin.TabIndex = 2;
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(59, 465);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(455, 41);
            this.TbPassword.TabIndex = 3;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSignIn.BackgroundImage")));
            this.BtnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Location = new System.Drawing.Point(387, 528);
            this.BtnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(133, 72);
            this.BtnSignIn.TabIndex = 4;
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSignUp.BackgroundImage")));
            this.BtnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.Location = new System.Drawing.Point(225, 528);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(130, 72);
            this.BtnSignUp.TabIndex = 5;
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // TBServer
            // 
            this.TBServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBServer.Location = new System.Drawing.Point(3, 2);
            this.TBServer.Margin = new System.Windows.Forms.Padding(4);
            this.TBServer.Name = "TBServer";
            this.TBServer.Size = new System.Drawing.Size(22, 34);
            this.TBServer.TabIndex = 8;
            this.TBServer.Text = "http://localhost:2343/werewolf/";
            this.TBServer.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(55, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 72);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // server
            // 
            this.server.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.server.Items.AddRange(new object[] {
            "16 Player",
            "2 Player",
            "4 Player",
            "User server"});
            this.server.Location = new System.Drawing.Point(204, 228);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(173, 37);
            this.server.TabIndex = 11;
            this.server.Text = "Select server";
            this.server.SelectedIndexChanged += new System.EventHandler(this.server_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(528, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.server);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBServer);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.TextBox TBServer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox server;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}