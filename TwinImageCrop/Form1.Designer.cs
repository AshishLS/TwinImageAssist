namespace TwinImageCrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefLine = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbxLockBoth = new System.Windows.Forms.CheckBox();
            this.leftZoomBar = new System.Windows.Forms.TrackBar();
            this.rightZoomTrack = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftZoomBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightZoomTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnRefLine
            // 
            this.btnRefLine.Location = new System.Drawing.Point(12, 52);
            this.btnRefLine.Name = "btnRefLine";
            this.btnRefLine.Size = new System.Drawing.Size(75, 23);
            this.btnRefLine.TabIndex = 1;
            this.btnRefLine.Text = "Ref Line";
            this.btnRefLine.UseVisualStyleBackColor = true;
            this.btnRefLine.Click += new System.EventHandler(this.btnRefLine_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(731, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 512);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // cbxLockBoth
            // 
            this.cbxLockBoth.AutoSize = true;
            this.cbxLockBoth.Location = new System.Drawing.Point(12, 82);
            this.cbxLockBoth.Name = "cbxLockBoth";
            this.cbxLockBoth.Size = new System.Drawing.Size(75, 17);
            this.cbxLockBoth.TabIndex = 3;
            this.cbxLockBoth.Text = "Lock Both";
            this.cbxLockBoth.UseVisualStyleBackColor = true;
            this.cbxLockBoth.CheckedChanged += new System.EventHandler(this.cbxLockBoth_CheckedChanged);
            // 
            // leftZoomBar
            // 
            this.leftZoomBar.Location = new System.Drawing.Point(42, 161);
            this.leftZoomBar.Name = "leftZoomBar";
            this.leftZoomBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.leftZoomBar.Size = new System.Drawing.Size(45, 192);
            this.leftZoomBar.TabIndex = 4;
            this.leftZoomBar.Scroll += new System.EventHandler(this.leftZoomBar_Scroll);
            // 
            // rightZoomTrack
            // 
            this.rightZoomTrack.Location = new System.Drawing.Point(669, 161);
            this.rightZoomTrack.Name = "rightZoomTrack";
            this.rightZoomTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rightZoomTrack.Size = new System.Drawing.Size(45, 192);
            this.rightZoomTrack.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 538);
            this.Controls.Add(this.rightZoomTrack);
            this.Controls.Add(this.leftZoomBar);
            this.Controls.Add(this.cbxLockBoth);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRefLine);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftZoomBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightZoomTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefLine;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cbxLockBoth;
        private System.Windows.Forms.TrackBar leftZoomBar;
        private System.Windows.Forms.TrackBar rightZoomTrack;
    }
}

