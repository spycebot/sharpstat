namespace sharpstat
{
    partial class SharpStatForm
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
            labelFileName = new Label();
            buttonLoadFile = new Button();
            textBoxFilePathDisplay = new TextBox();
            SuspendLayout();
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Bahnschrift", 12F);
            labelFileName.Location = new Point(31, 22);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(87, 19);
            labelFileName.TabIndex = 0;
            labelFileName.Text = "File Name:";
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadFile.Location = new Point(31, 59);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(132, 34);
            buttonLoadFile.TabIndex = 1;
            buttonLoadFile.Text = "Load File";
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // textBoxFilePathDisplay
            // 
            textBoxFilePathDisplay.Location = new Point(124, 22);
            textBoxFilePathDisplay.Name = "textBoxFilePathDisplay";
            textBoxFilePathDisplay.ReadOnly = true;
            textBoxFilePathDisplay.Size = new Size(576, 23);
            textBoxFilePathDisplay.TabIndex = 2;
            // 
            // SharpStatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxFilePathDisplay);
            Controls.Add(buttonLoadFile);
            Controls.Add(labelFileName);
            Name = "SharpStatForm";
            Text = "SharpStat";
            Load += SharpStatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFileName;
        private Button buttonLoadFile;
        private TextBox textBoxFilePathDisplay;
    }
}
