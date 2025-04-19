namespace KursovoyShag
{
    partial class mainPageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPageForm));
            label1 = new Label();
            AvatarPictureBox = new PictureBox();
            PostMeLable = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 340);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Main Page";
            // 
            // AvatarPictureBox
            // 
            AvatarPictureBox.BackColor = Color.Transparent;
            AvatarPictureBox.Image = (Image)resources.GetObject("AvatarPictureBox.Image");
            AvatarPictureBox.InitialImage = null;
            AvatarPictureBox.Location = new Point(1013, 12);
            AvatarPictureBox.Name = "AvatarPictureBox";
            AvatarPictureBox.Size = new Size(39, 39);
            AvatarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AvatarPictureBox.TabIndex = 1;
            AvatarPictureBox.TabStop = false;
            AvatarPictureBox.Click += AvatarPictureBox_Click;
            // 
            // PostMeLable
            // 
            PostMeLable.AutoSize = true;
            PostMeLable.BackColor = Color.Transparent;
            PostMeLable.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PostMeLable.Location = new Point(12, 4);
            PostMeLable.Name = "PostMeLable";
            PostMeLable.Size = new Size(134, 47);
            PostMeLable.TabIndex = 2;
            PostMeLable.Text = "PostMe";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(985, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // mainPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(pictureBox1);
            Controls.Add(PostMeLable);
            Controls.Add(AvatarPictureBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainPageForm";
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox AvatarPictureBox;
        private Label PostMeLable;
        private PictureBox pictureBox1;
    }
}
