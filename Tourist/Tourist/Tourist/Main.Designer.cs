<<<<<<< HEAD:Tourist/Tourist/Tourist/Main.Designer.cs
﻿namespace Tourist
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.detailView = new System.Windows.Forms.ListView();
            this.columnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TouristMenu = new System.Windows.Forms.MenuStrip();
            this.분석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExifLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TouristDirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label_targetdir = new System.Windows.Forms.Label();
            this.label_selectedPath = new System.Windows.Forms.Label();
            this.TouristTabControl = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.TouristGmap = new GMap.NET.WindowsForms.GMapControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.image_Preview = new System.Windows.Forms.PictureBox();
            this.detailViewLabel = new System.Windows.Forms.Label();
            this.TouristMenu.SuspendLayout();
            this.TouristTabControl.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // detailView
            // 
            this.detailView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFileName,
            this.columnFilePath,
            this.columnFileSize});
            this.detailView.Location = new System.Drawing.Point(12, 396);
            this.detailView.Name = "detailView";
            this.detailView.Size = new System.Drawing.Size(754, 260);
            this.detailView.TabIndex = 0;
            this.detailView.UseCompatibleStateImageBehavior = false;
            this.detailView.View = System.Windows.Forms.View.Details;
            // 
            // columnFileName
            // 
            this.columnFileName.Text = "파일이름";
            this.columnFileName.Width = 120;
            // 
            // columnFilePath
            // 
            this.columnFilePath.Text = "파일경로";
            this.columnFilePath.Width = 250;
            // 
            // columnFileSize
            // 
            this.columnFileSize.Text = "파일사이즈";
            this.columnFileSize.Width = 150;
            // 
            // TouristMenu
            // 
            this.TouristMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.분석ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.TouristMenu.Location = new System.Drawing.Point(0, 0);
            this.TouristMenu.Name = "TouristMenu";
            this.TouristMenu.Size = new System.Drawing.Size(778, 24);
            this.TouristMenu.TabIndex = 1;
            this.TouristMenu.Text = "TouristMenu";
            // 
            // 분석ToolStripMenuItem
            // 
            this.분석ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExifLoadToolStripMenuItem});
            this.분석ToolStripMenuItem.Name = "분석ToolStripMenuItem";
            this.분석ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.분석ToolStripMenuItem.Text = "분석";
            // 
            // ExifLoadToolStripMenuItem
            // 
            this.ExifLoadToolStripMenuItem.Name = "ExifLoadToolStripMenuItem";
            this.ExifLoadToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ExifLoadToolStripMenuItem.Text = "불러오기";
            this.ExifLoadToolStripMenuItem.Click += new System.EventHandler(this.ExifLoadToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeveloperToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // DeveloperToolStripMenuItem
            // 
            this.DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem";
            this.DeveloperToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.DeveloperToolStripMenuItem.Text = "Credit";
            this.DeveloperToolStripMenuItem.Click += new System.EventHandler(this.DeveloperToolStripMenuItem_Click);
            // 
            // label_targetdir
            // 
            this.label_targetdir.AutoSize = true;
            this.label_targetdir.Location = new System.Drawing.Point(12, 378);
            this.label_targetdir.Name = "label_targetdir";
            this.label_targetdir.Size = new System.Drawing.Size(122, 15);
            this.label_targetdir.TabIndex = 2;
            this.label_targetdir.Text = "분석 대상 디렉터리 : ";
            // 
            // label_selectedPath
            // 
            this.label_selectedPath.AutoSize = true;
            this.label_selectedPath.Location = new System.Drawing.Point(134, 378);
            this.label_selectedPath.Name = "label_selectedPath";
            this.label_selectedPath.Size = new System.Drawing.Size(0, 15);
            this.label_selectedPath.TabIndex = 3;
            // 
            // TouristTabControl
            // 
            this.TouristTabControl.Controls.Add(this.tabMap);
            this.TouristTabControl.Controls.Add(this.tabDetail);
            this.TouristTabControl.Location = new System.Drawing.Point(15, 27);
            this.TouristTabControl.Name = "TouristTabControl";
            this.TouristTabControl.SelectedIndex = 0;
            this.TouristTabControl.Size = new System.Drawing.Size(751, 348);
            this.TouristTabControl.TabIndex = 4;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.TouristGmap);
            this.tabMap.Location = new System.Drawing.Point(4, 24);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(743, 320);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Maps";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // TouristGmap
            // 
            this.TouristGmap.Bearing = 0F;
            this.TouristGmap.CanDragMap = true;
            this.TouristGmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.TouristGmap.GrayScaleMode = false;
            this.TouristGmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.TouristGmap.LevelsKeepInMemmory = 5;
            this.TouristGmap.Location = new System.Drawing.Point(3, 3);
            this.TouristGmap.MarkersEnabled = true;
            this.TouristGmap.MaxZoom = 100;
            this.TouristGmap.MinZoom = 2;
            this.TouristGmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.TouristGmap.Name = "TouristGmap";
            this.TouristGmap.NegativeMode = false;
            this.TouristGmap.PolygonsEnabled = true;
            this.TouristGmap.RetryLoadTile = 0;
            this.TouristGmap.RoutesEnabled = true;
            this.TouristGmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.TouristGmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.TouristGmap.ShowTileGridLines = false;
            this.TouristGmap.Size = new System.Drawing.Size(737, 314);
            this.TouristGmap.TabIndex = 0;
            this.TouristGmap.Zoom = 5D;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.image_Preview);
            this.tabDetail.Location = new System.Drawing.Point(4, 24);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(743, 320);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "FileDetail";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // image_Preview
            // 
            this.image_Preview.Location = new System.Drawing.Point(0, 0);
            this.image_Preview.Name = "image_Preview";
            this.image_Preview.Size = new System.Drawing.Size(279, 280);
            this.image_Preview.TabIndex = 0;
            this.image_Preview.TabStop = false;
            // 
            // detailViewLabel
            // 
            this.detailViewLabel.AutoSize = true;
            this.detailViewLabel.Location = new System.Drawing.Point(289, 525);
            this.detailViewLabel.Name = "detailViewLabel";
            this.detailViewLabel.Size = new System.Drawing.Size(178, 15);
            this.detailViewLabel.TabIndex = 5;
            this.detailViewLabel.Text = "분석 가능한 이미지가 없습니다.";
            this.detailViewLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 668);
            this.Controls.Add(this.label_selectedPath);
            this.Controls.Add(this.label_targetdir);
            this.Controls.Add(this.TouristMenu);
            this.Controls.Add(this.TouristTabControl);
            this.Controls.Add(this.detailViewLabel);
            this.Controls.Add(this.detailView);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.TouristMenu;
            this.Name = "Main";
            this.Text = "Tourist - JPG Image Extractor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TouristMenu.ResumeLayout(false);
            this.TouristMenu.PerformLayout();
            this.TouristTabControl.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView detailView;
        private System.Windows.Forms.ColumnHeader columnFileName;
        private System.Windows.Forms.ColumnHeader columnFilePath;
        private System.Windows.Forms.ColumnHeader columnFileSize;
        private System.Windows.Forms.MenuStrip TouristMenu;
        private System.Windows.Forms.ToolStripMenuItem 분석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExifLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeveloperToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog TouristDirBrowser;
        private System.Windows.Forms.Label label_targetdir;
        private System.Windows.Forms.Label label_selectedPath;
        private System.Windows.Forms.TabControl TouristTabControl;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.TabPage tabDetail;
        private GMap.NET.WindowsForms.GMapControl TouristGmap;
        private System.Windows.Forms.Label detailViewLabel;
        private System.Windows.Forms.PictureBox image_Preview;
    }
}

=======
﻿namespace Tourist
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.detailView = new System.Windows.Forms.ListView();
            this.columnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TouristMenu = new System.Windows.Forms.MenuStrip();
            this.분석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExifLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TouristDirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label_targetdir = new System.Windows.Forms.Label();
            this.label_selectedPath = new System.Windows.Forms.Label();
            this.TouristTabControl = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.TouristGmap = new GMap.NET.WindowsForms.GMapControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.detailViewLabel = new System.Windows.Forms.Label();
            this.TouristMenu.SuspendLayout();
            this.TouristTabControl.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailView
            // 
            this.detailView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFileName,
            this.columnFilePath,
            this.columnFileSize});
            this.detailView.Location = new System.Drawing.Point(12, 396);
            this.detailView.Name = "detailView";
            this.detailView.Size = new System.Drawing.Size(754, 260);
            this.detailView.TabIndex = 0;
            this.detailView.UseCompatibleStateImageBehavior = false;
            this.detailView.View = System.Windows.Forms.View.Details;
            // 
            // columnFileName
            // 
            this.columnFileName.Text = "파일이름";
            this.columnFileName.Width = 120;
            // 
            // columnFilePath
            // 
            this.columnFilePath.Text = "파일경로";
            this.columnFilePath.Width = 250;
            // 
            // columnFileSize
            // 
            this.columnFileSize.Text = "파일사이즈";
            this.columnFileSize.Width = 150;
            // 
            // TouristMenu
            // 
            this.TouristMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.분석ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.TouristMenu.Location = new System.Drawing.Point(0, 0);
            this.TouristMenu.Name = "TouristMenu";
            this.TouristMenu.Size = new System.Drawing.Size(778, 24);
            this.TouristMenu.TabIndex = 1;
            this.TouristMenu.Text = "TouristMenu";
            // 
            // 분석ToolStripMenuItem
            // 
            this.분석ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExifLoadToolStripMenuItem});
            this.분석ToolStripMenuItem.Name = "분석ToolStripMenuItem";
            this.분석ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.분석ToolStripMenuItem.Text = "분석";
            // 
            // ExifLoadToolStripMenuItem
            // 
            this.ExifLoadToolStripMenuItem.Name = "ExifLoadToolStripMenuItem";
            this.ExifLoadToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ExifLoadToolStripMenuItem.Text = "불러오기";
            this.ExifLoadToolStripMenuItem.Click += new System.EventHandler(this.ExifLoadToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeveloperToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // DeveloperToolStripMenuItem
            // 
            this.DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem";
            this.DeveloperToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.DeveloperToolStripMenuItem.Text = "Credit";
            this.DeveloperToolStripMenuItem.Click += new System.EventHandler(this.DeveloperToolStripMenuItem_Click);
            // 
            // label_targetdir
            // 
            this.label_targetdir.AutoSize = true;
            this.label_targetdir.Location = new System.Drawing.Point(12, 378);
            this.label_targetdir.Name = "label_targetdir";
            this.label_targetdir.Size = new System.Drawing.Size(122, 15);
            this.label_targetdir.TabIndex = 2;
            this.label_targetdir.Text = "분석 대상 디렉터리 : ";
            // 
            // label_selectedPath
            // 
            this.label_selectedPath.AutoSize = true;
            this.label_selectedPath.Location = new System.Drawing.Point(129, 314);
            this.label_selectedPath.Name = "label_selectedPath";
            this.label_selectedPath.Size = new System.Drawing.Size(0, 15);
            this.label_selectedPath.TabIndex = 3;
            // 
            // TouristTabControl
            // 
            this.TouristTabControl.Controls.Add(this.tabMap);
            this.TouristTabControl.Controls.Add(this.tabDetail);
            this.TouristTabControl.Location = new System.Drawing.Point(15, 27);
            this.TouristTabControl.Name = "TouristTabControl";
            this.TouristTabControl.SelectedIndex = 0;
            this.TouristTabControl.Size = new System.Drawing.Size(751, 348);
            this.TouristTabControl.TabIndex = 4;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.TouristGmap);
            this.tabMap.Location = new System.Drawing.Point(4, 24);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(743, 320);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Maps";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // TouristGmap
            // 
            this.TouristGmap.Bearing = 0F;
            this.TouristGmap.CanDragMap = true;
            this.TouristGmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.TouristGmap.GrayScaleMode = false;
            this.TouristGmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.TouristGmap.LevelsKeepInMemmory = 5;
            this.TouristGmap.Location = new System.Drawing.Point(3, 3);
            this.TouristGmap.MarkersEnabled = true;
            this.TouristGmap.MaxZoom = 10;
            this.TouristGmap.MinZoom = 2;
            this.TouristGmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.TouristGmap.Name = "TouristGmap";
            this.TouristGmap.NegativeMode = false;
            this.TouristGmap.PolygonsEnabled = true;
            this.TouristGmap.RetryLoadTile = 0;
            this.TouristGmap.RoutesEnabled = true;
            this.TouristGmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.TouristGmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.TouristGmap.ShowTileGridLines = false;
            this.TouristGmap.Size = new System.Drawing.Size(737, 314);
            this.TouristGmap.TabIndex = 0;
            this.TouristGmap.Zoom = 5D;
            // 
            // tabDetail
            // 
            this.tabDetail.Location = new System.Drawing.Point(4, 24);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(743, 320);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "FileDetail";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // detailViewLabel
            // 
            this.detailViewLabel.AutoSize = true;
            this.detailViewLabel.Location = new System.Drawing.Point(289, 525);
            this.detailViewLabel.Name = "detailViewLabel";
            this.detailViewLabel.Size = new System.Drawing.Size(178, 15);
            this.detailViewLabel.TabIndex = 5;
            this.detailViewLabel.Text = "분석 가능한 이미지가 없습니다.";
            this.detailViewLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 668);
            this.Controls.Add(this.label_selectedPath);
            this.Controls.Add(this.label_targetdir);
            this.Controls.Add(this.TouristMenu);
            this.Controls.Add(this.TouristTabControl);
            this.Controls.Add(this.detailViewLabel);
            this.Controls.Add(this.detailView);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.TouristMenu;
            this.Name = "Main";
            this.Text = "Tourist - JPG Image Extractor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TouristMenu.ResumeLayout(false);
            this.TouristMenu.PerformLayout();
            this.TouristTabControl.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView detailView;
        private System.Windows.Forms.ColumnHeader columnFileName;
        private System.Windows.Forms.ColumnHeader columnFilePath;
        private System.Windows.Forms.ColumnHeader columnFileSize;
        private System.Windows.Forms.MenuStrip TouristMenu;
        private System.Windows.Forms.ToolStripMenuItem 분석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExifLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeveloperToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog TouristDirBrowser;
        private System.Windows.Forms.Label label_targetdir;
        private System.Windows.Forms.Label label_selectedPath;
        private System.Windows.Forms.TabControl TouristTabControl;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.TabPage tabDetail;
        private GMap.NET.WindowsForms.GMapControl TouristGmap;
        private System.Windows.Forms.Label detailViewLabel;
    }
}

>>>>>>> origin/master:Tourist/Tourist/Main.Designer.cs
