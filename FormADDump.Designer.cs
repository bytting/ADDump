namespace ADDump
{
    partial class FormADDump
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormADDump));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabelCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDump = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.flowTop = new System.Windows.Forms.FlowLayoutPanel();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbFirstname = new System.Windows.Forms.CheckBox();
            this.cbLastname = new System.Windows.Forms.CheckBox();
            this.cbMail = new System.Windows.Forms.CheckBox();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbAlias = new System.Windows.Forms.CheckBox();
            this.cbTitle = new System.Windows.Forms.CheckBox();
            this.cbDepartment = new System.Windows.Forms.CheckBox();
            this.cbCompany = new System.Windows.Forms.CheckBox();
            this.cbUsername = new System.Windows.Forms.CheckBox();
            this.buttonDump = new System.Windows.Forms.Button();
            this.splitContainerInner = new System.Windows.Forms.SplitContainer();
            this.list = new System.Windows.Forms.ListView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelCurrentGroups = new System.Windows.Forms.Label();
            this.toolStripRight = new System.Windows.Forms.ToolStrip();
            this.buttonRemoveSelected = new System.Windows.Forms.ToolStripButton();
            this.buttonCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnListGroups = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.flowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInner)).BeginInit();
            this.splitContainerInner.Panel1.SuspendLayout();
            this.splitContainerInner.Panel2.SuspendLayout();
            this.splitContainerInner.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.toolStripRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelCounter});
            this.statusStrip.Location = new System.Drawing.Point(0, 732);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1336, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // statusLabelCounter
            // 
            this.statusLabelCounter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statusLabelCounter.Name = "statusLabelCounter";
            this.statusLabelCounter.Size = new System.Drawing.Size(1321, 17);
            this.statusLabelCounter.Spring = true;
            this.statusLabelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1336, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDump,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemDump
            // 
            this.menuItemDump.Image = ((System.Drawing.Image)(resources.GetObject("menuItemDump.Image")));
            this.menuItemDump.Name = "menuItemDump";
            this.menuItemDump.Size = new System.Drawing.Size(107, 22);
            this.menuItemDump.Text = "&Dump";
            this.menuItemDump.Click += new System.EventHandler(this.menuItemDump_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(107, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerInner);
            this.splitContainer.Panel2.Controls.Add(this.toolStripRight);
            this.splitContainer.Size = new System.Drawing.Size(1336, 708);
            this.splitContainer.SplitterDistance = 160;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 3;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.flowTop);
            this.splitContainerLeft.Panel1.Controls.Add(this.buttonDump);
            this.splitContainerLeft.Size = new System.Drawing.Size(160, 708);
            this.splitContainerLeft.SplitterDistance = 311;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // flowTop
            // 
            this.flowTop.Controls.Add(this.cbName);
            this.flowTop.Controls.Add(this.cbFirstname);
            this.flowTop.Controls.Add(this.cbLastname);
            this.flowTop.Controls.Add(this.cbMail);
            this.flowTop.Controls.Add(this.cbPhone);
            this.flowTop.Controls.Add(this.cbAlias);
            this.flowTop.Controls.Add(this.cbTitle);
            this.flowTop.Controls.Add(this.cbDepartment);
            this.flowTop.Controls.Add(this.cbCompany);
            this.flowTop.Controls.Add(this.cbUsername);
            this.flowTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTop.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTop.Location = new System.Drawing.Point(0, 0);
            this.flowTop.Name = "flowTop";
            this.flowTop.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowTop.Size = new System.Drawing.Size(160, 288);
            this.flowTop.TabIndex = 0;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Checked = true;
            this.cbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName.Enabled = false;
            this.cbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbName.Location = new System.Drawing.Point(3, 15);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(60, 19);
            this.cbName.TabIndex = 0;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // cbFirstname
            // 
            this.cbFirstname.AutoSize = true;
            this.cbFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFirstname.Location = new System.Drawing.Point(3, 40);
            this.cbFirstname.Name = "cbFirstname";
            this.cbFirstname.Size = new System.Drawing.Size(81, 19);
            this.cbFirstname.TabIndex = 1;
            this.cbFirstname.Text = "Firstname";
            this.cbFirstname.UseVisualStyleBackColor = true;
            // 
            // cbLastname
            // 
            this.cbLastname.AutoSize = true;
            this.cbLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLastname.Location = new System.Drawing.Point(3, 65);
            this.cbLastname.Name = "cbLastname";
            this.cbLastname.Size = new System.Drawing.Size(81, 19);
            this.cbLastname.TabIndex = 2;
            this.cbLastname.Text = "Lastname";
            this.cbLastname.UseVisualStyleBackColor = true;
            // 
            // cbMail
            // 
            this.cbMail.AutoSize = true;
            this.cbMail.Checked = true;
            this.cbMail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMail.Location = new System.Drawing.Point(3, 90);
            this.cbMail.Name = "cbMail";
            this.cbMail.Size = new System.Drawing.Size(58, 19);
            this.cbMail.TabIndex = 3;
            this.cbMail.Text = "Email";
            this.cbMail.UseVisualStyleBackColor = true;
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhone.Location = new System.Drawing.Point(3, 115);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(62, 19);
            this.cbPhone.TabIndex = 4;
            this.cbPhone.Text = "Phone";
            this.cbPhone.UseVisualStyleBackColor = true;
            // 
            // cbAlias
            // 
            this.cbAlias.AutoSize = true;
            this.cbAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlias.Location = new System.Drawing.Point(3, 140);
            this.cbAlias.Name = "cbAlias";
            this.cbAlias.Size = new System.Drawing.Size(52, 19);
            this.cbAlias.TabIndex = 5;
            this.cbAlias.Text = "Alias";
            this.cbAlias.UseVisualStyleBackColor = true;
            // 
            // cbTitle
            // 
            this.cbTitle.AutoSize = true;
            this.cbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTitle.Location = new System.Drawing.Point(3, 165);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(49, 19);
            this.cbTitle.TabIndex = 6;
            this.cbTitle.Text = "Title";
            this.cbTitle.UseVisualStyleBackColor = true;
            // 
            // cbDepartment
            // 
            this.cbDepartment.AutoSize = true;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.Location = new System.Drawing.Point(3, 190);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(91, 19);
            this.cbDepartment.TabIndex = 7;
            this.cbDepartment.Text = "Department";
            this.cbDepartment.UseVisualStyleBackColor = true;
            // 
            // cbCompany
            // 
            this.cbCompany.AutoSize = true;
            this.cbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.Location = new System.Drawing.Point(3, 215);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(78, 19);
            this.cbCompany.TabIndex = 8;
            this.cbCompany.Text = "Company";
            this.cbCompany.UseVisualStyleBackColor = true;
            // 
            // cbUsername
            // 
            this.cbUsername.AutoSize = true;
            this.cbUsername.Location = new System.Drawing.Point(3, 240);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(74, 17);
            this.cbUsername.TabIndex = 9;
            this.cbUsername.Text = "Username";
            this.cbUsername.UseVisualStyleBackColor = true;
            // 
            // buttonDump
            // 
            this.buttonDump.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDump.BackgroundImage")));
            this.buttonDump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDump.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDump.Location = new System.Drawing.Point(0, 288);
            this.buttonDump.Name = "buttonDump";
            this.buttonDump.Size = new System.Drawing.Size(160, 23);
            this.buttonDump.TabIndex = 1;
            this.buttonDump.Text = "Dump";
            this.buttonDump.UseVisualStyleBackColor = true;
            this.buttonDump.Click += new System.EventHandler(this.menuItemDump_Click);
            // 
            // splitContainerInner
            // 
            this.splitContainerInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInner.Location = new System.Drawing.Point(0, 25);
            this.splitContainerInner.Name = "splitContainerInner";
            // 
            // splitContainerInner.Panel1
            // 
            this.splitContainerInner.Panel1.Controls.Add(this.list);
            // 
            // splitContainerInner.Panel2
            // 
            this.splitContainerInner.Panel2.Controls.Add(this.lbGroups);
            this.splitContainerInner.Panel2.Controls.Add(this.panelTitle);
            this.splitContainerInner.Size = new System.Drawing.Size(1170, 683);
            this.splitContainerInner.SplitterDistance = 757;
            this.splitContainerInner.SplitterWidth = 6;
            this.splitContainerInner.TabIndex = 3;
            // 
            // list
            // 
            this.list.ContextMenuStrip = this.contextMenu;
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(757, 683);
            this.list.TabIndex = 4;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeContextMenuItem,
            this.copyContextMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(211, 48);
            // 
            // removeContextMenuItem
            // 
            this.removeContextMenuItem.Enabled = false;
            this.removeContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeContextMenuItem.Image")));
            this.removeContextMenuItem.Name = "removeContextMenuItem";
            this.removeContextMenuItem.Size = new System.Drawing.Size(210, 22);
            this.removeContextMenuItem.Text = "Remove selected from list";
            this.removeContextMenuItem.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // copyContextMenuItem
            // 
            this.copyContextMenuItem.Enabled = false;
            this.copyContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyContextMenuItem.Image")));
            this.copyContextMenuItem.Name = "copyContextMenuItem";
            this.copyContextMenuItem.Size = new System.Drawing.Size(210, 22);
            this.copyContextMenuItem.Text = "Copy to clipboard";
            this.copyContextMenuItem.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // lbGroups
            // 
            this.lbGroups.BackColor = System.Drawing.SystemColors.Control;
            this.lbGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 15;
            this.lbGroups.Location = new System.Drawing.Point(0, 23);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbGroups.Size = new System.Drawing.Size(407, 660);
            this.lbGroups.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.panelTitle.Controls.Add(this.labelCurrentGroups);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(407, 23);
            this.panelTitle.TabIndex = 1;
            // 
            // labelCurrentGroups
            // 
            this.labelCurrentGroups.AutoSize = true;
            this.labelCurrentGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCurrentGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentGroups.Location = new System.Drawing.Point(0, 0);
            this.labelCurrentGroups.Name = "labelCurrentGroups";
            this.labelCurrentGroups.Size = new System.Drawing.Size(0, 15);
            this.labelCurrentGroups.TabIndex = 0;
            // 
            // toolStripRight
            // 
            this.toolStripRight.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRemoveSelected,
            this.buttonCopyToClipboard,
            this.btnListGroups});
            this.toolStripRight.Location = new System.Drawing.Point(0, 0);
            this.toolStripRight.Name = "toolStripRight";
            this.toolStripRight.Size = new System.Drawing.Size(1170, 25);
            this.toolStripRight.TabIndex = 2;
            this.toolStripRight.Text = "toolStrip1";
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Enabled = false;
            this.buttonRemoveSelected.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveSelected.Image")));
            this.buttonRemoveSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(163, 22);
            this.buttonRemoveSelected.Text = "Remove selected from list";
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Enabled = false;
            this.buttonCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyToClipboard.Image")));
            this.buttonCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(122, 22);
            this.buttonCopyToClipboard.Text = "Copy to clipboard";
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // btnListGroups
            // 
            this.btnListGroups.Image = ((System.Drawing.Image)(resources.GetObject("btnListGroups.Image")));
            this.btnListGroups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListGroups.Name = "btnListGroups";
            this.btnListGroups.Size = new System.Drawing.Size(85, 22);
            this.btnListGroups.Text = "List groups";
            this.btnListGroups.Click += new System.EventHandler(this.btnListGroups_Click);
            // 
            // FormADDump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 754);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(620, 460);
            this.Name = "FormADDump";
            this.Text = "AD Dump";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.flowTop.ResumeLayout(false);
            this.flowTop.PerformLayout();
            this.splitContainerInner.Panel1.ResumeLayout(false);
            this.splitContainerInner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInner)).EndInit();
            this.splitContainerInner.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.toolStripRight.ResumeLayout(false);
            this.toolStripRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemDump;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelCounter;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.FlowLayoutPanel flowTop;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbFirstname;
        private System.Windows.Forms.CheckBox cbLastname;
        private System.Windows.Forms.CheckBox cbMail;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.CheckBox cbAlias;
        private System.Windows.Forms.CheckBox cbTitle;
        private System.Windows.Forms.CheckBox cbDepartment;
        private System.Windows.Forms.CheckBox cbCompany;
        private System.Windows.Forms.ToolStrip toolStripRight;
        private System.Windows.Forms.ToolStripButton buttonRemoveSelected;
        private System.Windows.Forms.ToolStripButton buttonCopyToClipboard;
        private System.Windows.Forms.Button buttonDump;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenuItem;
        private System.Windows.Forms.ToolStripButton btnListGroups;
        private System.Windows.Forms.SplitContainer splitContainerInner;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelCurrentGroups;
        private System.Windows.Forms.CheckBox cbUsername;
    }
}

