namespace CSUTreeAdmin
{
    partial class CSUTreeAdminMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSUTreeAdminMainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息采集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddTree = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveTree = new System.Windows.Forms.ToolStripButton();
            this.btnEditTreeInfo = new System.Windows.Forms.ToolStripButton();
            this.tbMapView = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.mapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMapView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户ToolStripMenuItem,
            this.信息采集ToolStripMenuItem,
            this.统计分析ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登入ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 登入ToolStripMenuItem
            // 
            this.登入ToolStripMenuItem.Name = "登入ToolStripMenuItem";
            this.登入ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.登入ToolStripMenuItem.Text = "登入";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 信息采集ToolStripMenuItem
            // 
            this.信息采集ToolStripMenuItem.Name = "信息采集ToolStripMenuItem";
            this.信息采集ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.信息采集ToolStripMenuItem.Text = "数据采集";
            // 
            // 统计分析ToolStripMenuItem
            // 
            this.统计分析ToolStripMenuItem.Name = "统计分析ToolStripMenuItem";
            this.统计分析ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.统计分析ToolStripMenuItem.Text = "统计分析";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTree,
            this.btnRemoveTree,
            this.btnEditTreeInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddTree
            // 
            this.btnAddTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTree.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTree.Image")));
            this.btnAddTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTree.Name = "btnAddTree";
            this.btnAddTree.Size = new System.Drawing.Size(23, 22);
            this.btnAddTree.Text = "toolStripButton1";
            this.btnAddTree.Click += new System.EventHandler(this.btnAddTree_Click);
            // 
            // btnRemoveTree
            // 
            this.btnRemoveTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveTree.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTree.Image")));
            this.btnRemoveTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveTree.Name = "btnRemoveTree";
            this.btnRemoveTree.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveTree.Text = "toolStripButton2";
            this.btnRemoveTree.Click += new System.EventHandler(this.btnRemoveTree_Click);
            // 
            // btnEditTreeInfo
            // 
            this.btnEditTreeInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditTreeInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTreeInfo.Image")));
            this.btnEditTreeInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTreeInfo.Name = "btnEditTreeInfo";
            this.btnEditTreeInfo.Size = new System.Drawing.Size(23, 22);
            this.btnEditTreeInfo.Text = "toolStripButton1";
            this.btnEditTreeInfo.Click += new System.EventHandler(this.btnEditTreeInfo_Click);
            // 
            // tbMapView
            // 
            this.tbMapView.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbMapView.Location = new System.Drawing.Point(772, 53);
            this.tbMapView.Name = "tbMapView";
            this.tbMapView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tbMapView.OcxState")));
            this.tbMapView.Size = new System.Drawing.Size(28, 478);
            this.tbMapView.TabIndex = 3;
            this.tbMapView.OnItemClick += new ESRI.ArcGIS.Controls.IToolbarControlEvents_Ax_OnItemClickEventHandler(this.tbMapView_OnItemClick);
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 53);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(800, 478);
            this.mapControl.TabIndex = 2;
            this.mapControl.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.mapControl_OnMouseDown);
            // 
            // CSUTreeAdminMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.tbMapView);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CSUTreeAdminMainform";
            this.Text = "中南大学古树名木管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMapView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息采集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddTree;
        private System.Windows.Forms.ToolStripButton btnRemoveTree;
        private ESRI.ArcGIS.Controls.AxMapControl mapControl;
        private ESRI.ArcGIS.Controls.AxToolbarControl tbMapView;
        private System.Windows.Forms.ToolStripButton btnEditTreeInfo;
    }
}

