namespace BogsyVideoStoreProj_Perez
{
    partial class SignUp
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
            label4 = new Label();
            label1 = new Label();
            txtusername = new TextBox();
            label2 = new Label();
            txtemail = new TextBox();
            txtpass = new TextBox();
            label5 = new Label();
            backlogin = new LinkLabel();
            label3 = new Label();
            btnsignup = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(4, 62, 119);
            label4.Location = new Point(103, 106);
            label4.Name = "label4";
            label4.Size = new Size(98, 29);
            label4.TabIndex = 9;
            label4.Text = "SignUp";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 62, 119);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(48, 42);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 8;
            label1.Text = "Bogsy Video Store";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.ControlLight;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(39, 211);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(243, 28);
            txtusername.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 62, 119);
            label2.Location = new Point(39, 185);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 12;
            label2.Text = "USERNAME";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.ControlLight;
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(39, 284);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(243, 28);
            txtemail.TabIndex = 15;
            // 
            // txtpass
            // 
            txtpass.BackColor = SystemColors.ControlLight;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(39, 366);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(243, 28);
            txtpass.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(4, 62, 119);
            label5.Location = new Point(39, 340);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 16;
            label5.Text = "PASSWORD";
            // 
            // backlogin
            // 
            backlogin.AutoSize = true;
            backlogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backlogin.LinkBehavior = LinkBehavior.NeverUnderline;
            backlogin.LinkColor = Color.FromArgb(12, 82, 128);
            backlogin.Location = new Point(124, 547);
            backlogin.Name = "backlogin";
            backlogin.Size = new Size(54, 20);
            backlogin.TabIndex = 19;
            backlogin.TabStop = true;
            backlogin.Text = "Sign In";
            backlogin.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 62, 119);
            label3.Location = new Point(39, 258);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 14;
            label3.Text = "EMAIL";
            // 
            // btnsignup
            // 
            btnsignup.BackColor = Color.FromArgb(12, 82, 128);
            btnsignup.FlatStyle = FlatStyle.Flat;
            btnsignup.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsignup.ForeColor = Color.White;
            btnsignup.Location = new Point(103, 464);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(94, 49);
            btnsignup.TabIndex = 20;
            btnsignup.Text = "Sign Up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(319, 596);
            Controls.Add(btnsignup);
            Controls.Add(backlogin);
            Controls.Add(txtpass);
            Controls.Add(label5);
            Controls.Add(txtemail);
            Controls.Add(label3);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private TextBox txtusername;
        private Label label2;
        private TextBox txtemail;
        private TextBox txtpass;
        private Label label5;
        private LinkLabel backlogin;
        private Label label3;
        private Button btnsignup;
    }
}