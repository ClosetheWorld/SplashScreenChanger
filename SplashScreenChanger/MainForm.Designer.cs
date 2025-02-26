namespace SplashScreenChanger
{
    partial class MainForm
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
            selectedImage = new PictureBox();
            selectImageButton = new Button();
            applyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)selectedImage).BeginInit();
            SuspendLayout();
            // 
            // selectedImage
            // 
            selectedImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectedImage.Location = new Point(63, 51);
            selectedImage.Name = "selectedImage";
            selectedImage.Size = new Size(464, 261);
            selectedImage.SizeMode = PictureBoxSizeMode.Zoom;
            selectedImage.TabIndex = 0;
            selectedImage.TabStop = false;
            // 
            // selectImageButton
            // 
            selectImageButton.Font = new Font("Yu Gothic UI", 12F);
            selectImageButton.Location = new Point(12, 12);
            selectImageButton.Name = "selectImageButton";
            selectImageButton.Size = new Size(560, 33);
            selectImageButton.TabIndex = 1;
            selectImageButton.Text = "SplashScreenにする画像を選択";
            selectImageButton.UseVisualStyleBackColor = true;
            selectImageButton.Click += selectImageButton_Click;
            // 
            // applyButton
            // 
            applyButton.Font = new Font("Yu Gothic UI", 12F);
            applyButton.Location = new Point(12, 318);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(560, 33);
            applyButton.TabIndex = 2;
            applyButton.Text = "変更";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(applyButton);
            Controls.Add(selectImageButton);
            Controls.Add(selectedImage);
            MaximizeBox = false;
            MaximumSize = new Size(600, 400);
            MinimizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "MainForm";
            Text = "SplashScreenChanger";
            ((System.ComponentModel.ISupportInitialize)selectedImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox selectedImage;
        private Button selectImageButton;
        private Button applyButton;
    }
}
