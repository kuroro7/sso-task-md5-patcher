namespace sso_task_md5_patcher {
    partial class fMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            statusStrip1 = new StatusStrip();
            lbStatus = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            grid = new DataGridView();
            columnFile = new DataGridViewTextBoxColumn();
            columnMd5Expected = new DataGridViewTextBoxColumn();
            columnCurrentMd5 = new DataGridViewTextBoxColumn();
            headerGroupBox = new GroupBox();
            patchPanel = new Panel();
            btPatch = new Button();
            lbPackCount = new Label();
            lbItemCount = new Label();
            lbMagic = new Label();
            lbVersion = new Label();
            edtPackCount = new TextBox();
            edtItemCount = new TextBox();
            edtMagic = new TextBox();
            edtVersion = new TextBox();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            headerGroupBox.SuspendLayout();
            patchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbStatus });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(89, 17);
            lbStatus.Text = "No File Opened";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(grid);
            mainPanel.Controls.Add(headerGroupBox);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 24);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(5);
            mainPanel.Size = new Size(784, 515);
            mainPanel.TabIndex = 3;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { columnFile, columnMd5Expected, columnCurrentMd5 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle = dataGridViewCellStyle1;
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(5, 81);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(774, 429);
            grid.TabIndex = 5;
            // 
            // columnFile
            // 
            columnFile.HeaderText = "File";
            columnFile.Name = "columnFile";
            columnFile.ReadOnly = true;
            columnFile.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnFile.Width = 150;
            // 
            // columnMd5Expected
            // 
            columnMd5Expected.HeaderText = "Expected MD5";
            columnMd5Expected.Name = "columnMd5Expected";
            columnMd5Expected.ReadOnly = true;
            columnMd5Expected.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnMd5Expected.Width = 250;
            // 
            // columnCurrentMd5
            // 
            columnCurrentMd5.HeaderText = "Current MD5";
            columnCurrentMd5.Name = "columnCurrentMd5";
            columnCurrentMd5.ReadOnly = true;
            columnCurrentMd5.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnCurrentMd5.Width = 250;
            // 
            // headerGroupBox
            // 
            headerGroupBox.Controls.Add(patchPanel);
            headerGroupBox.Controls.Add(lbPackCount);
            headerGroupBox.Controls.Add(lbItemCount);
            headerGroupBox.Controls.Add(lbMagic);
            headerGroupBox.Controls.Add(lbVersion);
            headerGroupBox.Controls.Add(edtPackCount);
            headerGroupBox.Controls.Add(edtItemCount);
            headerGroupBox.Controls.Add(edtMagic);
            headerGroupBox.Controls.Add(edtVersion);
            headerGroupBox.Dock = DockStyle.Top;
            headerGroupBox.Location = new Point(5, 5);
            headerGroupBox.Name = "headerGroupBox";
            headerGroupBox.Size = new Size(774, 76);
            headerGroupBox.TabIndex = 4;
            headerGroupBox.TabStop = false;
            headerGroupBox.Text = "Task Data Info";
            // 
            // patchPanel
            // 
            patchPanel.Controls.Add(btPatch);
            patchPanel.Dock = DockStyle.Right;
            patchPanel.Location = new Point(666, 19);
            patchPanel.Name = "patchPanel";
            patchPanel.Padding = new Padding(5);
            patchPanel.Size = new Size(105, 54);
            patchPanel.TabIndex = 8;
            // 
            // btPatch
            // 
            btPatch.Dock = DockStyle.Fill;
            btPatch.Enabled = false;
            btPatch.Image = Properties.Resources.service;
            btPatch.Location = new Point(5, 5);
            btPatch.Name = "btPatch";
            btPatch.Size = new Size(95, 44);
            btPatch.TabIndex = 0;
            btPatch.Text = "Patch";
            btPatch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btPatch.UseVisualStyleBackColor = true;
            btPatch.Click += btPatch_Click;
            // 
            // lbPackCount
            // 
            lbPackCount.AutoSize = true;
            lbPackCount.Location = new Point(393, 19);
            lbPackCount.Name = "lbPackCount";
            lbPackCount.Size = new Size(68, 15);
            lbPackCount.TabIndex = 7;
            lbPackCount.Text = "Pack Count";
            // 
            // lbItemCount
            // 
            lbItemCount.AutoSize = true;
            lbItemCount.Location = new Point(287, 19);
            lbItemCount.Name = "lbItemCount";
            lbItemCount.Size = new Size(70, 15);
            lbItemCount.TabIndex = 6;
            lbItemCount.Text = "Tasks Count";
            // 
            // lbMagic
            // 
            lbMagic.AutoSize = true;
            lbMagic.Location = new Point(147, 19);
            lbMagic.Name = "lbMagic";
            lbMagic.Size = new Size(40, 15);
            lbMagic.TabIndex = 5;
            lbMagic.Text = "Magic";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Location = new Point(7, 19);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(45, 15);
            lbVersion.TabIndex = 4;
            lbVersion.Text = "Version";
            // 
            // edtPackCount
            // 
            edtPackCount.Enabled = false;
            edtPackCount.Location = new Point(393, 37);
            edtPackCount.Name = "edtPackCount";
            edtPackCount.Size = new Size(100, 23);
            edtPackCount.TabIndex = 3;
            // 
            // edtItemCount
            // 
            edtItemCount.Enabled = false;
            edtItemCount.Location = new Point(287, 37);
            edtItemCount.Name = "edtItemCount";
            edtItemCount.Size = new Size(100, 23);
            edtItemCount.TabIndex = 2;
            // 
            // edtMagic
            // 
            edtMagic.Enabled = false;
            edtMagic.Location = new Point(147, 37);
            edtMagic.Name = "edtMagic";
            edtMagic.Size = new Size(134, 23);
            edtMagic.TabIndex = 1;
            // 
            // edtVersion
            // 
            edtVersion.Enabled = false;
            edtVersion.Location = new Point(7, 37);
            edtVersion.Name = "edtVersion";
            edtVersion.Size = new Size(134, 23);
            edtVersion.TabIndex = 0;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(mainPanel);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSO Task MD5 Patcher";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            headerGroupBox.ResumeLayout(false);
            headerGroupBox.PerformLayout();
            patchPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private Panel mainPanel;
        private GroupBox headerGroupBox;
        private DataGridView grid;
        private Label lbMagic;
        private Label lbVersion;
        private TextBox edtPackCount;
        private TextBox edtItemCount;
        private TextBox edtMagic;
        private TextBox edtVersion;
        private Label lbPackCount;
        private Label lbItemCount;
        private Panel patchPanel;
        private Button btPatch;
        private DataGridViewTextBoxColumn columnFile;
        private DataGridViewTextBoxColumn columnMd5Expected;
        private DataGridViewTextBoxColumn columnCurrentMd5;
        private ToolStripStatusLabel lbStatus;
    }
}
