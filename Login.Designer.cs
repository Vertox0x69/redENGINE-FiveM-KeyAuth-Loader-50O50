namespace KeyAuth
{
    // Token: 0x02000002 RID: 2
    public partial class Login : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation1 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.password = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // username
            // 
            this.username.AllowDrop = true;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.username, Siticone.UI.AnimatorNS.DecorationType.None);
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.username.FocusedState.Parent = this.username;
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.username.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.username.HoveredState.Parent = this.username;
            this.username.Location = new System.Drawing.Point(82, 225);
            this.username.Margin = new System.Windows.Forms.Padding(0);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.username.PlaceholderText = "";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(336, 36);
            this.username.TabIndex = 33;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.AllowDrop = true;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.password, Siticone.UI.AnimatorNS.DecorationType.None);
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.password.FocusedState.Parent = this.password;
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.password.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.password.HoveredState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(82, 311);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(336, 36);
            this.password.TabIndex = 34;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // pictureBox1
            // 
            this.siticoneTransition1.SetDecoration(this.pictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.label3.Location = new System.Drawing.Point(204, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(236, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 35);
            this.label4.TabIndex = 41;
            this.label4.Text = "ENGINE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(154, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Thank you for choosing us";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Sign in to continue to RedENGINE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label7.Location = new System.Drawing.Point(91, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label8.Location = new System.Drawing.Point(91, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "E-Mail or Username";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.siticoneTransition1.SetDecoration(this.button1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(82, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 40);
            this.button1.TabIndex = 48;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(318, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Forgot password?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(12, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Made by Vertox#0069";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(518, 499);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox password;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}