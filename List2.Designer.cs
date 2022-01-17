namespace KeyAuth
{
    public partial class List2 : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation5 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List2));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
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
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(50);
            animation5.RotateCoeff = 1F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation5;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneTransition1.SetDecoration(this.pictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 570);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.siticoneTransition1.SetDecoration(this.pictureBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneTransition1.SetDecoration(this.pictureBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneTransition1.SetDecoration(this.pictureBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(17, 125);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneTransition1.SetDecoration(this.pictureBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 184);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneTransition1.SetDecoration(this.pictureBox6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox6.Location = new System.Drawing.Point(72, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(587, 65);
            this.pictureBox6.TabIndex = 58;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(94, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 59;
            this.label2.Text = "FiveM - Dev Kit";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneTransition1.SetDecoration(this.pictureBox8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox8.Location = new System.Drawing.Point(81, 82);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(567, 46);
            this.pictureBox8.TabIndex = 63;
            this.pictureBox8.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(85, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "Description";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneTransition1.SetDecoration(this.pictureBox7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox7.Location = new System.Drawing.Point(81, 125);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(567, 46);
            this.pictureBox7.TabIndex = 66;
            this.pictureBox7.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(84, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "placeholder...";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneTransition1.SetDecoration(this.pictureBox9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox9.Location = new System.Drawing.Point(81, 184);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(567, 46);
            this.pictureBox9.TabIndex = 68;
            this.pictureBox9.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(85, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Subscriptions";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneTransition1.SetDecoration(this.pictureBox10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox10.Location = new System.Drawing.Point(81, 230);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(567, 46);
            this.pictureBox10.TabIndex = 70;
            this.pictureBox10.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.siticoneTransition1.SetDecoration(this.label6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(85, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 25);
            this.label6.TabIndex = 71;
            this.label6.Text = "You don\'t have active subscription.";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneTransition1.SetDecoration(this.pictureBox11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox11.Location = new System.Drawing.Point(72, 488);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(587, 82);
            this.pictureBox11.TabIndex = 72;
            this.pictureBox11.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.siticoneTransition1.SetDecoration(this.label7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(86, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 73;
            this.label7.Text = "Go back";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.siticoneTransition1.SetDecoration(this.label8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(474, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 74;
            this.label8.Text = "Testing";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.siticoneTransition1.SetDecoration(this.button2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Honeydew;
            this.button2.Location = new System.Drawing.Point(550, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 39);
            this.button2.TabIndex = 75;
            this.button2.Text = "Launch";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneTransition1.SetDecoration(this.pictureBox12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(20, 533);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(33, 24);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 76;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // List2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(657, 569);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}