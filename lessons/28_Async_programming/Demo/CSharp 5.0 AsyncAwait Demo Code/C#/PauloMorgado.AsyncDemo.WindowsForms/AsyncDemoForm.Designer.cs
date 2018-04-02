namespace PauloMorgado.AsyncDemo.WindowsForms
{
    partial class AsyncDemoForm
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
            System.Windows.Forms.Panel loadButtonPanel;
            System.Windows.Forms.Panel progressBarPanel;
            System.Windows.Forms.Panel cancelButtonPanel;
            System.Windows.Forms.Panel controlPanel;
            this.loadButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            loadButtonPanel = new System.Windows.Forms.Panel();
            progressBarPanel = new System.Windows.Forms.Panel();
            cancelButtonPanel = new System.Windows.Forms.Panel();
            controlPanel = new System.Windows.Forms.Panel();
            loadButtonPanel.SuspendLayout();
            progressBarPanel.SuspendLayout();
            cancelButtonPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButtonPanel
            // 
            loadButtonPanel.AutoSize = true;
            loadButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            loadButtonPanel.Controls.Add(this.loadButton);
            loadButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            loadButtonPanel.Location = new System.Drawing.Point(0, 0);
            loadButtonPanel.Name = "loadButtonPanel";
            loadButtonPanel.Padding = new System.Windows.Forms.Padding(3);
            loadButtonPanel.Size = new System.Drawing.Size(72, 35);
            loadButtonPanel.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(6, 6);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(60, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.HandleLoadButtonClick);
            // 
            // progressBarPanel
            // 
            progressBarPanel.AutoSize = true;
            progressBarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            progressBarPanel.Controls.Add(this.progressBar);
            progressBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            progressBarPanel.Location = new System.Drawing.Point(72, 0);
            progressBarPanel.Name = "progressBarPanel";
            progressBarPanel.Size = new System.Drawing.Size(143, 35);
            progressBarPanel.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(6, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(131, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // cancelButtonPanel
            // 
            cancelButtonPanel.AutoSize = true;
            cancelButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cancelButtonPanel.Controls.Add(this.cancelButton);
            cancelButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            cancelButtonPanel.Location = new System.Drawing.Point(215, 0);
            cancelButtonPanel.Name = "cancelButtonPanel";
            cancelButtonPanel.Size = new System.Drawing.Size(69, 35);
            cancelButtonPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.HandleCancelButtonClick);
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(progressBarPanel);
            controlPanel.Controls.Add(cancelButtonPanel);
            controlPanel.Controls.Add(loadButtonPanel);
            controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            controlPanel.Location = new System.Drawing.Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new System.Drawing.Size(284, 35);
            controlPanel.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(284, 226);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // AsyncDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(controlPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "AsyncDemoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async Demo";
            loadButtonPanel.ResumeLayout(false);
            progressBarPanel.ResumeLayout(false);
            cancelButtonPanel.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

