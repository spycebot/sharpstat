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
            buttonExitApp = new Button();
            label1 = new Label();
            labelFileTypeReadout = new Label();
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
            textBoxFilePathDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonExitApp
            // 
            buttonExitApp.Font = new Font("Bahnschrift", 12F);
            buttonExitApp.Location = new Point(572, 59);
            buttonExitApp.Name = "buttonExitApp";
            buttonExitApp.Size = new Size(128, 34);
            buttonExitApp.TabIndex = 3;
            buttonExitApp.Text = "Exit";
            buttonExitApp.UseVisualStyleBackColor = true;
            buttonExitApp.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F);
            label1.Location = new Point(31, 109);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 4;
            label1.Text = "File Type:";
            label1.Click += label1_Click;
            // 
            // labelFileTypeReadout
            // 
            labelFileTypeReadout.AutoSize = true;
            labelFileTypeReadout.Font = new Font("Bahnschrift", 12F);
            labelFileTypeReadout.Location = new Point(112, 109);
            labelFileTypeReadout.Name = "labelFileTypeReadout";
            labelFileTypeReadout.Size = new Size(47, 19);
            labelFileTypeReadout.TabIndex = 5;
            labelFileTypeReadout.Text = "None";
            // 
            // SharpStatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelFileTypeReadout);
            Controls.Add(label1);
            Controls.Add(buttonExitApp);
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
        private Button buttonExitApp;
        private Label label1;
        private Label labelFileTypeReadout;
    }
}
