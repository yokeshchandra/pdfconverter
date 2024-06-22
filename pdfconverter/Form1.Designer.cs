namespace MyWindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.browseButton = new System.Windows.Forms.Button();
            this.createFileButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(320, 20);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // createFileButton
            // 
            this.createFileButton.Location = new System.Drawing.Point(150, 60);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(100, 23);
            this.createFileButton.TabIndex = 1;
            this.createFileButton.Text = "Create File";
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(70, 20);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(230, 20);
            this.pathTextBox.TabIndex = 2;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(20, 20);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(32, 13);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 100);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.createFileButton);
            this.Controls.Add(this.browseButton);
            this.Name = "Form1";
            this.Text = "PDF Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
