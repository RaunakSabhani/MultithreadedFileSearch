namespace rxs160630_Asg4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlFileTextBox = new System.Windows.Forms.TextBox();
            this.ctlSearchTextBox = new System.Windows.Forms.TextBox();
            this.ctlBrowseButton = new System.Windows.Forms.Button();
            this.ctlSearchButton = new System.Windows.Forms.Button();
            this.openFileDialogCtl = new System.Windows.Forms.OpenFileDialog();
            this.ctlStatusBar = new System.Windows.Forms.StatusStrip();
            this.ctlStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctlStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctlBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ctlListView = new System.Windows.Forms.ListView();
            this.LineNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // ctlFileTextBox
            // 
            this.ctlFileTextBox.Location = new System.Drawing.Point(100, 13);
            this.ctlFileTextBox.Name = "ctlFileTextBox";
            this.ctlFileTextBox.Size = new System.Drawing.Size(507, 22);
            this.ctlFileTextBox.TabIndex = 2;
            // 
            // ctlSearchTextBox
            // 
            this.ctlSearchTextBox.Location = new System.Drawing.Point(100, 47);
            this.ctlSearchTextBox.Name = "ctlSearchTextBox";
            this.ctlSearchTextBox.Size = new System.Drawing.Size(507, 22);
            this.ctlSearchTextBox.TabIndex = 4;
            this.ctlSearchTextBox.TextChanged += new System.EventHandler(this.ctlSearchTextBox_TextChanged);
            // 
            // ctlBrowseButton
            // 
            this.ctlBrowseButton.Location = new System.Drawing.Point(624, 13);
            this.ctlBrowseButton.Name = "ctlBrowseButton";
            this.ctlBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.ctlBrowseButton.TabIndex = 3;
            this.ctlBrowseButton.Text = "Browse";
            this.ctlBrowseButton.UseVisualStyleBackColor = true;
            this.ctlBrowseButton.Click += new System.EventHandler(this.ctlBrowseButton_Click);
            // 
            // ctlSearchButton
            // 
            this.ctlSearchButton.Location = new System.Drawing.Point(624, 47);
            this.ctlSearchButton.Name = "ctlSearchButton";
            this.ctlSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ctlSearchButton.TabIndex = 5;
            this.ctlSearchButton.Text = "Search";
            this.ctlSearchButton.UseVisualStyleBackColor = true;
            this.ctlSearchButton.Click += new System.EventHandler(this.ctlSearchButton_Click);
            // 
            // openFileDialogCtl
            // 
            this.openFileDialogCtl.FileName = "openFileDialogCtl";
            // 
            // ctlStatusBar
            // 
            this.ctlStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlStatusStrip,
            this.ctlStatusLabel});
            this.ctlStatusBar.Location = new System.Drawing.Point(0, 462);
            this.ctlStatusBar.Name = "ctlStatusBar";
            this.ctlStatusBar.Size = new System.Drawing.Size(711, 22);
            this.ctlStatusBar.TabIndex = 6;
            this.ctlStatusBar.Text = "statusStrip1";
            // 
            // ctlStatusStrip
            // 
            this.ctlStatusStrip.Name = "ctlStatusStrip";
            this.ctlStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // ctlStatusLabel
            // 
            this.ctlStatusLabel.Name = "ctlStatusLabel";
            this.ctlStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ctlBackgroundWorker
            // 
            this.ctlBackgroundWorker.WorkerReportsProgress = true;
            this.ctlBackgroundWorker.WorkerSupportsCancellation = true;
            this.ctlBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ctlBackgroundWorker_DoWork);
            this.ctlBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ctlBackgroundWorker_ProgressChanged);
            this.ctlBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ctlBackgroundWorker_RunWorkerCompleted);
            // 
            // ctlListView
            // 
            this.ctlListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LineNo,
            this.Text});
            this.ctlListView.FullRowSelect = true;
            this.ctlListView.Location = new System.Drawing.Point(16, 90);
            this.ctlListView.Name = "ctlListView";
            this.ctlListView.Size = new System.Drawing.Size(683, 350);
            this.ctlListView.TabIndex = 7;
            this.ctlListView.UseCompatibleStateImageBehavior = false;
            this.ctlListView.View = System.Windows.Forms.View.Details;
            // 
            // LineNo
            // 
            this.LineNo.Text = "LineNo";
            this.LineNo.Width = 79;
            // 
            // Text
            // 
            this.Text.Text = "Text";
            this.Text.Width = 467;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 484);
            this.Controls.Add(this.ctlListView);
            this.Controls.Add(this.ctlStatusBar);
            this.Controls.Add(this.ctlSearchButton);
            this.Controls.Add(this.ctlBrowseButton);
            this.Controls.Add(this.ctlSearchTextBox);
            this.Controls.Add(this.ctlFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ctlStatusBar.ResumeLayout(false);
            this.ctlStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctlFileTextBox;
        private System.Windows.Forms.TextBox ctlSearchTextBox;
        private System.Windows.Forms.Button ctlBrowseButton;
        private System.Windows.Forms.Button ctlSearchButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogCtl;
        private System.Windows.Forms.StatusStrip ctlStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel ctlStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ctlStatusLabel;
        private System.ComponentModel.BackgroundWorker ctlBackgroundWorker;
        private System.Windows.Forms.ListView ctlListView;
        private System.Windows.Forms.ColumnHeader LineNo;
        private System.Windows.Forms.ColumnHeader Text;
    }
}

