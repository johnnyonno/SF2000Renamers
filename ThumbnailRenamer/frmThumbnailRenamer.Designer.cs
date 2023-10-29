namespace ThumbnailRenamer
{
    partial class frmThumbnailRenamer
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
            lblSourceFolder = new Label();
            lblDestinationFolder = new Label();
            rbPrefix = new RadioButton();
            rbSuffix = new RadioButton();
            txtSourceFolder = new TextBox();
            txtDestinationFolder = new TextBox();
            btnSourceFolder = new Button();
            btnDestinationFolder = new Button();
            lblTag = new Label();
            txtTag = new TextBox();
            pgBar = new ProgressBar();
            btnAction = new Button();
            optgrpbox = new GroupBox();
            optgrpbox.SuspendLayout();
            SuspendLayout();
            // 
            // lblSourceFolder
            // 
            lblSourceFolder.AutoSize = true;
            lblSourceFolder.Location = new Point(24, 26);
            lblSourceFolder.Name = "lblSourceFolder";
            lblSourceFolder.Size = new Size(79, 15);
            lblSourceFolder.TabIndex = 0;
            lblSourceFolder.Text = "Source Folder";
            // 
            // lblDestinationFolder
            // 
            lblDestinationFolder.AutoSize = true;
            lblDestinationFolder.Location = new Point(24, 62);
            lblDestinationFolder.Name = "lblDestinationFolder";
            lblDestinationFolder.Size = new Size(103, 15);
            lblDestinationFolder.TabIndex = 1;
            lblDestinationFolder.Text = "Destination Folder";
            // 
            // rbPrefix
            // 
            rbPrefix.AutoSize = true;
            rbPrefix.Checked = true;
            rbPrefix.Location = new Point(8, 22);
            rbPrefix.Name = "rbPrefix";
            rbPrefix.Size = new Size(55, 19);
            rbPrefix.TabIndex = 2;
            rbPrefix.TabStop = true;
            rbPrefix.Text = "Prefix";
            rbPrefix.UseVisualStyleBackColor = true;
            // 
            // rbSuffix
            // 
            rbSuffix.AutoSize = true;
            rbSuffix.Location = new Point(75, 22);
            rbSuffix.Name = "rbSuffix";
            rbSuffix.Size = new Size(55, 19);
            rbSuffix.TabIndex = 3;
            rbSuffix.Text = "Suffix";
            rbSuffix.UseVisualStyleBackColor = true;
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Location = new Point(138, 23);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.ReadOnly = true;
            txtSourceFolder.Size = new Size(332, 23);
            txtSourceFolder.TabIndex = 4;
            // 
            // txtDestinationFolder
            // 
            txtDestinationFolder.Location = new Point(138, 59);
            txtDestinationFolder.Name = "txtDestinationFolder";
            txtDestinationFolder.ReadOnly = true;
            txtDestinationFolder.Size = new Size(332, 23);
            txtDestinationFolder.TabIndex = 5;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Location = new Point(482, 23);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(128, 23);
            btnSourceFolder.TabIndex = 6;
            btnSourceFolder.Text = "Choose Source";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // 
            // btnDestinationFolder
            // 
            btnDestinationFolder.Location = new Point(482, 62);
            btnDestinationFolder.Name = "btnDestinationFolder";
            btnDestinationFolder.Size = new Size(128, 23);
            btnDestinationFolder.TabIndex = 7;
            btnDestinationFolder.Text = "Choose Destination";
            btnDestinationFolder.UseVisualStyleBackColor = true;
            btnDestinationFolder.Click += btnDestinationFolder_Click;
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Location = new Point(298, 115);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(66, 15);
            lblTag.TabIndex = 8;
            lblTag.Text = "System Tag";
            // 
            // txtTag
            // 
            txtTag.Location = new Point(370, 110);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(100, 23);
            txtTag.TabIndex = 9;
            // 
            // pgBar
            // 
            pgBar.Location = new Point(27, 148);
            pgBar.Name = "pgBar";
            pgBar.Size = new Size(583, 23);
            pgBar.TabIndex = 10;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(535, 177);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(75, 23);
            btnAction.TabIndex = 11;
            btnAction.Text = "Rename!";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // optgrpbox
            // 
            optgrpbox.Controls.Add(rbPrefix);
            optgrpbox.Controls.Add(rbSuffix);
            optgrpbox.Location = new Point(27, 89);
            optgrpbox.Name = "optgrpbox";
            optgrpbox.Size = new Size(157, 53);
            optgrpbox.TabIndex = 12;
            optgrpbox.TabStop = false;
            optgrpbox.Text = "Tag Location";
            // 
            // frmThumbnailRenamer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 222);
            Controls.Add(optgrpbox);
            Controls.Add(btnAction);
            Controls.Add(pgBar);
            Controls.Add(txtTag);
            Controls.Add(lblTag);
            Controls.Add(btnDestinationFolder);
            Controls.Add(btnSourceFolder);
            Controls.Add(txtDestinationFolder);
            Controls.Add(txtSourceFolder);
            Controls.Add(lblDestinationFolder);
            Controls.Add(lblSourceFolder);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmThumbnailRenamer";
            Text = "SF2000 Thumbnail Renamer";
            optgrpbox.ResumeLayout(false);
            optgrpbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSourceFolder;
        private Label lblDestinationFolder;
        private RadioButton rbPrefix;
        private RadioButton rbSuffix;
        private TextBox txtSourceFolder;
        private TextBox txtDestinationFolder;
        private Button btnSourceFolder;
        private Button btnDestinationFolder;
        private Label lblTag;
        private TextBox txtTag;
        private ProgressBar pgBar;
        private Button btnAction;
        private GroupBox optgrpbox;
    }
}