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
            this.�û�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�˳�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��Ϣ�ɼ�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ͳ�Ʒ���ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.�û�ToolStripMenuItem,
            this.��Ϣ�ɼ�ToolStripMenuItem,
            this.ͳ�Ʒ���ToolStripMenuItem,
            this.����ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // �û�ToolStripMenuItem
            // 
            this.�û�ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.����ToolStripMenuItem,
            this.�˳�ToolStripMenuItem});
            this.�û�ToolStripMenuItem.Name = "�û�ToolStripMenuItem";
            this.�û�ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.�û�ToolStripMenuItem.Text = "�û�";
            // 
            // ����ToolStripMenuItem
            // 
            this.����ToolStripMenuItem.Name = "����ToolStripMenuItem";
            this.����ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.����ToolStripMenuItem.Text = "����";
            // 
            // �˳�ToolStripMenuItem
            // 
            this.�˳�ToolStripMenuItem.Name = "�˳�ToolStripMenuItem";
            this.�˳�ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.�˳�ToolStripMenuItem.Text = "�˳�";
            // 
            // ��Ϣ�ɼ�ToolStripMenuItem
            // 
            this.��Ϣ�ɼ�ToolStripMenuItem.Name = "��Ϣ�ɼ�ToolStripMenuItem";
            this.��Ϣ�ɼ�ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.��Ϣ�ɼ�ToolStripMenuItem.Text = "���ݲɼ�";
            // 
            // ͳ�Ʒ���ToolStripMenuItem
            // 
            this.ͳ�Ʒ���ToolStripMenuItem.Name = "ͳ�Ʒ���ToolStripMenuItem";
            this.ͳ�Ʒ���ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ͳ�Ʒ���ToolStripMenuItem.Text = "ͳ�Ʒ���";
            // 
            // ����ToolStripMenuItem
            // 
            this.����ToolStripMenuItem.Name = "����ToolStripMenuItem";
            this.����ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.����ToolStripMenuItem.Text = "����";
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
            this.Text = "���ϴ�ѧ������ľ����ϵͳ";
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
        private System.Windows.Forms.ToolStripMenuItem �û�ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ����ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �˳�ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��Ϣ�ɼ�ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ͳ�Ʒ���ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ����ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddTree;
        private System.Windows.Forms.ToolStripButton btnRemoveTree;
        private ESRI.ArcGIS.Controls.AxMapControl mapControl;
        private ESRI.ArcGIS.Controls.AxToolbarControl tbMapView;
        private System.Windows.Forms.ToolStripButton btnEditTreeInfo;
    }
}

