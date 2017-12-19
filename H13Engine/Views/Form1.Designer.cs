namespace H13Engine
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
               this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
               this.panel1 = new System.Windows.Forms.Panel();
               this.HalconWindowControl = new HalconDotNet.HSmartWindowControl();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.openHDevProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.statusStrip1 = new System.Windows.Forms.StatusStrip();
               this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
               this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
               this.textBoxImageName = new System.Windows.Forms.TextBox();
               this.tableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
               this.halconImageSelect = new System.Windows.Forms.Button();
               this.halconProgramSelect = new System.Windows.Forms.Button();
               this.halconProcedureRun = new System.Windows.Forms.Button();
               this.listView1 = new System.Windows.Forms.ListView();
               this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
               this.openHdevDialog = new System.Windows.Forms.OpenFileDialog();
               this.tableLayoutPanel1.SuspendLayout();
               this.panel1.SuspendLayout();
               this.menuStrip1.SuspendLayout();
               this.statusStrip1.SuspendLayout();
               this.tableLayoutButtons.SuspendLayout();
               this.SuspendLayout();
               // 
               // tableLayoutPanel1
               // 
               this.tableLayoutPanel1.AutoSize = true;
               this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.tableLayoutPanel1.ColumnCount = 2;
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
               this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
               this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
               this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
               this.tableLayoutPanel1.Controls.Add(this.textBoxImageName, 1, 0);
               this.tableLayoutPanel1.Controls.Add(this.tableLayoutButtons, 0, 1);
               this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
               this.tableLayoutPanel1.Name = "tableLayoutPanel1";
               this.tableLayoutPanel1.RowCount = 3;
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
               this.tableLayoutPanel1.TabIndex = 0;
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.HalconWindowControl);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panel1.Location = new System.Drawing.Point(163, 29);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(618, 507);
               this.panel1.TabIndex = 4;
               // 
               // HalconWindowControl
               // 
               this.HalconWindowControl.AutoSize = true;
               this.HalconWindowControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.HalconWindowControl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
               this.HalconWindowControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.HalconWindowControl.Dock = System.Windows.Forms.DockStyle.Fill;
               this.HalconWindowControl.HDoubleClickToFitContent = true;
               this.HalconWindowControl.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
               this.HalconWindowControl.HImagePart = new System.Drawing.Rectangle(0, 0, -1, -1);
               this.HalconWindowControl.HKeepAspectRatio = true;
               this.HalconWindowControl.HMoveContent = true;
               this.HalconWindowControl.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
               this.HalconWindowControl.Location = new System.Drawing.Point(0, 0);
               this.HalconWindowControl.Margin = new System.Windows.Forms.Padding(0);
               this.HalconWindowControl.Name = "HalconWindowControl";
               this.HalconWindowControl.Size = new System.Drawing.Size(618, 507);
               this.HalconWindowControl.TabIndex = 0;
               this.HalconWindowControl.WindowSize = new System.Drawing.Size(618, 507);
               this.HalconWindowControl.Load += new System.EventHandler(this.HalconWindowControl_Load);
               // 
               // menuStrip1
               // 
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(160, 24);
               this.menuStrip1.TabIndex = 2;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.openHDevProgramToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
               this.fileToolStripMenuItem.Text = "File";
               // 
               // openImageToolStripMenuItem
               // 
               this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
               this.openImageToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
               this.openImageToolStripMenuItem.Text = "Open Image...";
               this.openImageToolStripMenuItem.Click += new System.EventHandler(this.OpenImageItem_Click);
               // 
               // openHDevProgramToolStripMenuItem
               // 
               this.openHDevProgramToolStripMenuItem.Name = "openHDevProgramToolStripMenuItem";
               this.openHDevProgramToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
               this.openHDevProgramToolStripMenuItem.Text = "Open HDev Program...";
               this.openHDevProgramToolStripMenuItem.Click += new System.EventHandler(this.OpenHdevelopItem_Click);
               // 
               // statusStrip1
               // 
               this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
               this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
               this.statusStrip1.Location = new System.Drawing.Point(0, 539);
               this.statusStrip1.Name = "statusStrip1";
               this.statusStrip1.Size = new System.Drawing.Size(784, 22);
               this.statusStrip1.TabIndex = 1;
               this.statusStrip1.Text = "statusStrip1";
               // 
               // toolStripStatusLabel1
               // 
               this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
               this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
               this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
               // 
               // toolStripStatusLabel2
               // 
               this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
               this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
               this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
               // 
               // textBoxImageName
               // 
               this.textBoxImageName.Dock = System.Windows.Forms.DockStyle.Fill;
               this.textBoxImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBoxImageName.Location = new System.Drawing.Point(163, 3);
               this.textBoxImageName.Name = "textBoxImageName";
               this.textBoxImageName.ReadOnly = true;
               this.textBoxImageName.Size = new System.Drawing.Size(618, 20);
               this.textBoxImageName.TabIndex = 3;
               // 
               // tableLayoutButtons
               // 
               this.tableLayoutButtons.ColumnCount = 1;
               this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
               this.tableLayoutButtons.Controls.Add(this.halconImageSelect, 0, 0);
               this.tableLayoutButtons.Controls.Add(this.halconProgramSelect, 0, 1);
               this.tableLayoutButtons.Controls.Add(this.halconProcedureRun, 0, 4);
               this.tableLayoutButtons.Controls.Add(this.listView1, 0, 3);
               this.tableLayoutButtons.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tableLayoutButtons.Location = new System.Drawing.Point(3, 29);
               this.tableLayoutButtons.Name = "tableLayoutButtons";
               this.tableLayoutButtons.RowCount = 9;
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutButtons.Size = new System.Drawing.Size(154, 507);
               this.tableLayoutButtons.TabIndex = 5;
               // 
               // halconImageSelect
               // 
               this.halconImageSelect.Dock = System.Windows.Forms.DockStyle.Top;
               this.halconImageSelect.Location = new System.Drawing.Point(3, 3);
               this.halconImageSelect.Name = "halconImageSelect";
               this.halconImageSelect.Size = new System.Drawing.Size(148, 23);
               this.halconImageSelect.TabIndex = 0;
               this.halconImageSelect.Text = "Image...";
               this.halconImageSelect.UseVisualStyleBackColor = true;
               this.halconImageSelect.Click += new System.EventHandler(this.OpenImageItem_Click);
               // 
               // halconProgramSelect
               // 
               this.halconProgramSelect.Dock = System.Windows.Forms.DockStyle.Top;
               this.halconProgramSelect.Location = new System.Drawing.Point(3, 32);
               this.halconProgramSelect.Name = "halconProgramSelect";
               this.halconProgramSelect.Size = new System.Drawing.Size(148, 23);
               this.halconProgramSelect.TabIndex = 1;
               this.halconProgramSelect.Text = "HDev...";
               this.halconProgramSelect.UseVisualStyleBackColor = true;
               this.halconProgramSelect.Click += new System.EventHandler(this.OpenHdevelopItem_Click);
               // 
               // halconProcedureRun
               // 
               this.halconProcedureRun.Dock = System.Windows.Forms.DockStyle.Top;
               this.halconProcedureRun.Location = new System.Drawing.Point(3, 401);
               this.halconProcedureRun.Name = "halconProcedureRun";
               this.halconProcedureRun.Size = new System.Drawing.Size(148, 23);
               this.halconProcedureRun.TabIndex = 2;
               this.halconProcedureRun.Text = "Run";
               this.halconProcedureRun.UseVisualStyleBackColor = true;
               this.halconProcedureRun.Click += new System.EventHandler(this.HalconProcedureRun_Click);
               // 
               // listView1
               // 
               this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
               this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listView1.FullRowSelect = true;
               this.listView1.GridLines = true;
               this.listView1.HideSelection = false;
               this.listView1.Location = new System.Drawing.Point(3, 61);
               this.listView1.MultiSelect = false;
               this.listView1.Name = "listView1";
               this.listView1.ShowGroups = false;
               this.listView1.Size = new System.Drawing.Size(148, 334);
               this.listView1.TabIndex = 3;
               this.listView1.UseCompatibleStateImageBehavior = false;
               this.listView1.View = System.Windows.Forms.View.List;
               // 
               // openImageDialog
               // 
               this.openImageDialog.DefaultExt = "jpg";
               this.openImageDialog.Filter = "Image files|*.jpg;*.png;*.tif;*.bmp|All files|*.*";
               this.openImageDialog.SupportMultiDottedExtensions = true;
               this.openImageDialog.Title = "Select Image File";
               // 
               // openHdevDialog
               // 
               this.openHdevDialog.DefaultExt = "hdev";
               this.openHdevDialog.Filter = "HDevelop|*.hdev|All files|*.*";
               this.openHdevDialog.SupportMultiDottedExtensions = true;
               this.openHdevDialog.Title = "Select HDevelop File";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.tableLayoutPanel1);
               this.MainMenuStrip = this.menuStrip1;
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
               this.tableLayoutPanel1.ResumeLayout(false);
               this.tableLayoutPanel1.PerformLayout();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.statusStrip1.ResumeLayout(false);
               this.statusStrip1.PerformLayout();
               this.tableLayoutButtons.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
          private HalconDotNet.HSmartWindowControl HalconWindowControl;
          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem openHDevProgramToolStripMenuItem;
          private System.Windows.Forms.StatusStrip statusStrip1;
          private System.Windows.Forms.TextBox textBoxImageName;
          private System.Windows.Forms.OpenFileDialog openImageDialog;
          private System.Windows.Forms.OpenFileDialog openHdevDialog;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.TableLayoutPanel tableLayoutButtons;
          private System.Windows.Forms.Button halconImageSelect;
          private System.Windows.Forms.Button halconProgramSelect;
          private System.Windows.Forms.Button halconProcedureRun;
          private System.Windows.Forms.ListView listView1;
     }
}

