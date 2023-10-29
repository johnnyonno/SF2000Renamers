namespace RomStubCreator
{
    partial class frmRomStubCreator
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
            lblDestinationFolder = new Label();
            lblSourceFolder = new Label();
            rbPrefix = new RadioButton();
            rbSuffix = new RadioButton();
            optgrpbox = new GroupBox();
            btnAction = new Button();
            pgBar = new ProgressBar();
            txtTag = new TextBox();
            lblTag = new Label();
            btnDestinationFolder = new Button();
            btnSourceFolder = new Button();
            txtDestinationFolder = new TextBox();
            txtSourceFolder = new TextBox();
            txtOverride = new TextBox();
            lblOverride = new Label();
            optgrpbox.SuspendLayout();
            SuspendLayout();
            // 
            // lblDestinationFolder
            // 
            lblDestinationFolder.AutoSize = true;
            lblDestinationFolder.Location = new Point(19, 51);
            lblDestinationFolder.Name = "lblDestinationFolder";
            lblDestinationFolder.Size = new Size(103, 15);
            lblDestinationFolder.TabIndex = 14;
            lblDestinationFolder.Text = "Destination Folder";
            // 
            // lblSourceFolder
            // 
            lblSourceFolder.AutoSize = true;
            lblSourceFolder.Location = new Point(19, 15);
            lblSourceFolder.Name = "lblSourceFolder";
            lblSourceFolder.Size = new Size(79, 15);
            lblSourceFolder.TabIndex = 13;
            lblSourceFolder.Text = "Source Folder";
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
            // optgrpbox
            // 
            optgrpbox.Controls.Add(rbPrefix);
            optgrpbox.Controls.Add(rbSuffix);
            optgrpbox.Location = new Point(22, 78);
            optgrpbox.Name = "optgrpbox";
            optgrpbox.Size = new Size(157, 53);
            optgrpbox.TabIndex = 23;
            optgrpbox.TabStop = false;
            optgrpbox.Text = "Tag Location";
            // 
            // btnAction
            // 
            btnAction.Location = new Point(530, 166);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(75, 23);
            btnAction.TabIndex = 22;
            btnAction.Text = "Create!";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // pgBar
            // 
            pgBar.Location = new Point(22, 137);
            pgBar.Name = "pgBar";
            pgBar.Size = new Size(583, 23);
            pgBar.TabIndex = 21;
            // 
            // txtTag
            // 
            txtTag.Location = new Point(281, 101);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(100, 23);
            txtTag.TabIndex = 20;
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Location = new Point(209, 106);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(66, 15);
            lblTag.TabIndex = 19;
            lblTag.Text = "System Tag";
            // 
            // btnDestinationFolder
            // 
            btnDestinationFolder.Location = new Point(477, 51);
            btnDestinationFolder.Name = "btnDestinationFolder";
            btnDestinationFolder.Size = new Size(128, 23);
            btnDestinationFolder.TabIndex = 18;
            btnDestinationFolder.Text = "Choose Destination";
            btnDestinationFolder.UseVisualStyleBackColor = true;
            btnDestinationFolder.Click += btnDestinationFolder_Click;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Location = new Point(477, 12);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(128, 23);
            btnSourceFolder.TabIndex = 17;
            btnSourceFolder.Text = "Choose Source";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // 
            // txtDestinationFolder
            // 
            txtDestinationFolder.Location = new Point(133, 48);
            txtDestinationFolder.Name = "txtDestinationFolder";
            txtDestinationFolder.ReadOnly = true;
            txtDestinationFolder.Size = new Size(332, 23);
            txtDestinationFolder.TabIndex = 16;
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Location = new Point(133, 12);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.ReadOnly = true;
            txtSourceFolder.Size = new Size(332, 23);
            txtSourceFolder.TabIndex = 15;
            // 
            // txtOverride
            // 
            txtOverride.Location = new Point(505, 99);
            txtOverride.Name = "txtOverride";
            txtOverride.Size = new Size(100, 23);
            txtOverride.TabIndex = 25;
            txtOverride.Text = "gba";
            // 
            // lblOverride
            // 
            lblOverride.AutoSize = true;
            lblOverride.Location = new Point(397, 104);
            lblOverride.Name = "lblOverride";
            lblOverride.Size = new Size(106, 15);
            lblOverride.TabIndex = 24;
            lblOverride.Text = "Override Extension";
            // 
            // frmRomStubCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 217);
            Controls.Add(txtOverride);
            Controls.Add(lblOverride);
            Controls.Add(lblDestinationFolder);
            Controls.Add(lblSourceFolder);
            Controls.Add(optgrpbox);
            Controls.Add(btnAction);
            Controls.Add(pgBar);
            Controls.Add(txtTag);
            Controls.Add(lblTag);
            Controls.Add(btnDestinationFolder);
            Controls.Add(btnSourceFolder);
            Controls.Add(txtDestinationFolder);
            Controls.Add(txtSourceFolder);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmRomStubCreator";
            Text = "SF2000 Rom Stub Creator";
            optgrpbox.ResumeLayout(false);
            optgrpbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDestinationFolder;
        private Label lblSourceFolder;
        private RadioButton rbPrefix;
        private RadioButton rbSuffix;
        private GroupBox optgrpbox;
        private Button btnAction;
        private ProgressBar pgBar;
        private TextBox txtTag;
        private Label lblTag;
        private Button btnDestinationFolder;
        private Button btnSourceFolder;
        private TextBox txtDestinationFolder;
        private TextBox txtSourceFolder;
        private TextBox txtOverride;
        private Label lblOverride;
    }
}