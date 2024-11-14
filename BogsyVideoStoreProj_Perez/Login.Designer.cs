namespace BogsyVideoStoreProj_Perez
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtpass = new TextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            signin = new LinkLabel();
            txtusername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 62, 119);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 0;
            label1.Text = "Bogsy Video Store";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 62, 119);
            label2.Location = new Point(48, 139);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 62, 119);
            label3.Location = new Point(48, 238);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(48, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(48, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtpass
            // 
            txtpass.BackColor = SystemColors.ControlLight;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(94, 269);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(200, 38);
            txtpass.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(4, 62, 119);
            label4.Location = new Point(132, 95);
            label4.Name = "label4";
            label4.Size = new Size(80, 29);
            label4.TabIndex = 7;
            label4.Text = "Login";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(12, 82, 128);
            linkLabel1.Location = new Point(175, 349);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(12, 82, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(118, 403);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // signin
            // 
            signin.AutoSize = true;
            signin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signin.LinkBehavior = LinkBehavior.NeverUnderline;
            signin.LinkColor = Color.FromArgb(12, 82, 128);
            signin.Location = new Point(132, 502);
            signin.Name = "signin";
            signin.Size = new Size(61, 20);
            signin.TabIndex = 10;
            signin.TabStop = true;
            signin.Text = "Sign Up";
            signin.LinkClicked += linkLabel2_LinkClicked;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.ControlLight;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(94, 167);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(200, 38);
            txtusername.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(336, 570);
            Controls.Add(txtusername);
            Controls.Add(signin);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(txtpass);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtpass;
        private Label label4;
        private LinkLabel linkLabel1;
        private Button button1;
        private LinkLabel signin;
        private TextBox txtusername;
    }
}