
namespace lab5
{
    partial class frmTextEditor
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyTool = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AboutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.MenuStrip1.SuspendLayout();
            this.FileContextMenuStrip.SuspendLayout();
            this.EditContextMenuStrip.SuspendLayout();
            this.HelpContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(617, 28);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuEditor";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDown = this.FileContextMenuStrip;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.OpenToolStripMenuItem.Text = "File";
            // 
            // FileContextMenuStrip
            // 
            this.FileContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTool,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.SaveAsTool,
            this.ExitTool});
            this.FileContextMenuStrip.Name = "contextMenuStrip1";
            this.FileContextMenuStrip.Size = new System.Drawing.Size(162, 124);
            // 
            // NewTool
            // 
            this.NewTool.Name = "NewTool";
            this.NewTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewTool.Size = new System.Drawing.Size(161, 24);
            this.NewTool.Tag = "NEW_OP";
            this.NewTool.Text = "New";
            this.NewTool.Click += new System.EventHandler(this.NewTool_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(161, 24);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // SaveAsTool
            // 
            this.SaveAsTool.Name = "SaveAsTool";
            this.SaveAsTool.Size = new System.Drawing.Size(161, 24);
            this.SaveAsTool.Tag = "SAVEAS_OP";
            this.SaveAsTool.Text = "Save As";
            this.SaveAsTool.Click += new System.EventHandler(this.SaveAsTool_Click);
            // 
            // ExitTool
            // 
            this.ExitTool.Name = "ExitTool";
            this.ExitTool.Size = new System.Drawing.Size(161, 24);
            this.ExitTool.Tag = "EXIT_OP";
            this.ExitTool.Text = "E&xit";
            this.ExitTool.Click += new System.EventHandler(this.ExitTool_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDown = this.EditContextMenuStrip;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.ToolTipText = "Copy Text";
            // 
            // EditContextMenuStrip
            // 
            this.EditContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyTool,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.EditContextMenuStrip.Name = "EditContextMenuStrip";
            this.EditContextMenuStrip.OwnerItem = this.EditToolStripMenuItem;
            this.EditContextMenuStrip.Size = new System.Drawing.Size(164, 76);
            // 
            // CopyTool
            // 
            this.CopyTool.Name = "CopyTool";
            this.CopyTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyTool.Size = new System.Drawing.Size(163, 24);
            this.CopyTool.Tag = "COPY_OP";
            this.CopyTool.Text = "Copy";
            this.CopyTool.Click += new System.EventHandler(this.CopyTool_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDown = this.HelpContextMenuStrip;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // HelpContextMenuStrip
            // 
            this.HelpContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HelpContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTool});
            this.HelpContextMenuStrip.Name = "HelpContextMenuStrip";
            this.HelpContextMenuStrip.OwnerItem = this.HelpToolStripMenuItem;
            this.HelpContextMenuStrip.Size = new System.Drawing.Size(120, 28);
            // 
            // AboutTool
            // 
            this.AboutTool.Name = "AboutTool";
            this.AboutTool.Size = new System.Drawing.Size(119, 24);
            this.AboutTool.Tag = "ABOUT_OP";
            this.AboutTool.Text = "About";
            this.AboutTool.Click += new System.EventHandler(this.AboutTool_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(617, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(0, 52);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(617, 319);
            this.txtEditor.TabIndex = 3;
            // 
            // frmTextEditor
            // 
            this.ClientSize = new System.Drawing.Size(617, 371);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor Select a File to Open";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.FileContextMenuStrip.ResumeLayout(false);
            this.EditContextMenuStrip.ResumeLayout(false);
            this.HelpContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Help;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip File;
        private System.Windows.Forms.ToolStripMenuItem NewTool;
        private System.Windows.Forms.ContextMenuStrip FileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveAsTool;
        private System.Windows.Forms.ToolStripMenuItem ExitTool;
        private System.Windows.Forms.ContextMenuStrip EditContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyTool;
        private System.Windows.Forms.ContextMenuStrip HelpContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutTool;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

