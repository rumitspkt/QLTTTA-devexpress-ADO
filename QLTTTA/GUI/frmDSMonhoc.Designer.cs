namespace QLTTTA.GUI
{
   partial class frmDSMonhoc
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSMonhoc));
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.btnThemMH = new DevExpress.XtraBars.BarButtonItem();
         this.btnSuaMH = new DevExpress.XtraBars.BarButtonItem();
         this.btnXoaMH = new DevExpress.XtraBars.BarButtonItem();
         this.btnLuuMH = new DevExpress.XtraBars.BarButtonItem();
         this.btnLammoiMH = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.edtSoGioHoc = new DevExpress.XtraEditors.TextEdit();
         this.edtTenMH = new DevExpress.XtraEditors.TextEdit();
         this.edtMaMH = new DevExpress.XtraEditors.TextEdit();
         this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.edtSoGioHoc.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtTenMH.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtMaMH.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemMH,
            this.btnXoaMH,
            this.btnSuaMH,
            this.btnLuuMH,
            this.btnLammoiMH,
            this.barButtonItem1});
         this.barManager1.MainMenu = this.bar2;
         this.barManager1.MaxItemId = 6;
         // 
         // bar2
         // 
         this.bar2.BarName = "Main menu";
         this.bar2.DockCol = 0;
         this.bar2.DockRow = 0;
         this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLammoiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // btnThemMH
         // 
         this.btnThemMH.Caption = "Thêm";
         this.btnThemMH.Id = 0;
         this.btnThemMH.ImageOptions.Image = global::QLTTTA.Properties.Resources.add;
         this.btnThemMH.ImageOptions.LargeImage = global::QLTTTA.Properties.Resources.add;
         this.btnThemMH.Name = "btnThemMH";
         this.btnThemMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemMH_ItemClick);
         // 
         // btnSuaMH
         // 
         this.btnSuaMH.Caption = "Sửa";
         this.btnSuaMH.Id = 2;
         this.btnSuaMH.ImageOptions.Image = global::QLTTTA.Properties.Resources.Pencil_icon;
         this.btnSuaMH.Name = "btnSuaMH";
         this.btnSuaMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaMH_ItemClick);
         // 
         // btnXoaMH
         // 
         this.btnXoaMH.Caption = "Xóa";
         this.btnXoaMH.Id = 1;
         this.btnXoaMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMH.ImageOptions.Image")));
         this.btnXoaMH.Name = "btnXoaMH";
         this.btnXoaMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaMH_ItemClick);
         // 
         // btnLuuMH
         // 
         this.btnLuuMH.Caption = "Lưu lại";
         this.btnLuuMH.Id = 3;
         this.btnLuuMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuMH.ImageOptions.Image")));
         this.btnLuuMH.Name = "btnLuuMH";
         this.btnLuuMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuMH_ItemClick);
         // 
         // btnLammoiMH
         // 
         this.btnLammoiMH.Caption = "Làm mới";
         this.btnLammoiMH.Id = 4;
         this.btnLammoiMH.ImageOptions.Image = global::QLTTTA.Properties.Resources.refresh;
         this.btnLammoiMH.Name = "btnLammoiMH";
         this.btnLammoiMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoiMH_ItemClick);
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(604, 40);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 352);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(604, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 312);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(604, 40);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 312);
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.edtSoGioHoc);
         this.layoutControl1.Controls.Add(this.edtTenMH);
         this.layoutControl1.Controls.Add(this.edtMaMH);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.layoutControl1.Location = new System.Drawing.Point(0, 40);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(766, 41, 450, 400);
         this.layoutControl1.Root = this.layoutControlGroup1;
         this.layoutControl1.Size = new System.Drawing.Size(604, 120);
         this.layoutControl1.TabIndex = 4;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // edtSoGioHoc
         // 
         this.edtSoGioHoc.Enabled = false;
         this.edtSoGioHoc.Location = new System.Drawing.Point(76, 36);
         this.edtSoGioHoc.MenuManager = this.barManager1;
         this.edtSoGioHoc.Name = "edtSoGioHoc";
         this.edtSoGioHoc.Size = new System.Drawing.Size(516, 20);
         this.edtSoGioHoc.StyleController = this.layoutControl1;
         this.edtSoGioHoc.TabIndex = 6;
         // 
         // edtTenMH
         // 
         this.edtTenMH.Enabled = false;
         this.edtTenMH.Location = new System.Drawing.Point(367, 12);
         this.edtTenMH.MenuManager = this.barManager1;
         this.edtTenMH.Name = "edtTenMH";
         this.edtTenMH.Size = new System.Drawing.Size(225, 20);
         this.edtTenMH.StyleController = this.layoutControl1;
         this.edtTenMH.TabIndex = 5;
         // 
         // edtMaMH
         // 
         this.edtMaMH.Enabled = false;
         this.edtMaMH.Location = new System.Drawing.Point(76, 12);
         this.edtMaMH.MenuManager = this.barManager1;
         this.edtMaMH.Name = "edtMaMH";
         this.edtMaMH.Size = new System.Drawing.Size(223, 20);
         this.edtMaMH.StyleController = this.layoutControl1;
         this.edtMaMH.TabIndex = 4;
         // 
         // layoutControlGroup1
         // 
         this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.layoutControlGroup1.GroupBordersVisible = false;
         this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
         this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlGroup1.Name = "Root";
         this.layoutControlGroup1.Size = new System.Drawing.Size(604, 120);
         this.layoutControlGroup1.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.edtMaMH;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(291, 24);
         this.layoutControlItem1.Text = "Mã môn học";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.edtTenMH;
         this.layoutControlItem2.Location = new System.Drawing.Point(291, 0);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(293, 24);
         this.layoutControlItem2.Text = "Tên môn học";
         this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.edtSoGioHoc;
         this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(584, 76);
         this.layoutControlItem3.Text = "Số giờ học";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
         // 
         // gcMonHoc
         // 
         this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcMonHoc.Location = new System.Drawing.Point(0, 160);
         this.gcMonHoc.MainView = this.gridView1;
         this.gcMonHoc.MenuManager = this.barManager1;
         this.gcMonHoc.Name = "gcMonHoc";
         this.gcMonHoc.Size = new System.Drawing.Size(604, 192);
         this.gcMonHoc.TabIndex = 5;
         this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
         this.gridView1.GridControl = this.gcMonHoc;
         this.gridView1.Name = "gridView1";
         this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
         // 
         // gridColumn1
         // 
         this.gridColumn1.Caption = "Mã môn học";
         this.gridColumn1.FieldName = "MaMH";
         this.gridColumn1.Name = "gridColumn1";
         this.gridColumn1.OptionsColumn.AllowEdit = false;
         this.gridColumn1.OptionsColumn.AllowFocus = false;
         this.gridColumn1.OptionsFilter.AllowFilter = false;
         this.gridColumn1.Visible = true;
         this.gridColumn1.VisibleIndex = 0;
         // 
         // gridColumn2
         // 
         this.gridColumn2.Caption = "Tên môn học";
         this.gridColumn2.FieldName = "TenMH";
         this.gridColumn2.Name = "gridColumn2";
         this.gridColumn2.OptionsColumn.AllowEdit = false;
         this.gridColumn2.OptionsColumn.AllowFocus = false;
         this.gridColumn2.OptionsFilter.AllowFilter = false;
         this.gridColumn2.Visible = true;
         this.gridColumn2.VisibleIndex = 1;
         // 
         // gridColumn3
         // 
         this.gridColumn3.Caption = "Số giờ học";
         this.gridColumn3.FieldName = "SoGioHoc";
         this.gridColumn3.Name = "gridColumn3";
         this.gridColumn3.OptionsColumn.AllowEdit = false;
         this.gridColumn3.OptionsColumn.AllowFocus = false;
         this.gridColumn3.OptionsFilter.AllowFilter = false;
         this.gridColumn3.Visible = true;
         this.gridColumn3.VisibleIndex = 2;
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "Xuất Excel";
         this.barButtonItem1.Id = 5;
         this.barButtonItem1.ImageOptions.Image = global::QLTTTA.Properties.Resources.Excel_2_icon;
         this.barButtonItem1.Name = "barButtonItem1";
         this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
         // 
         // frmDSMonhoc
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(604, 352);
         this.Controls.Add(this.gcMonHoc);
         this.Controls.Add(this.layoutControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "frmDSMonhoc";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Danh sách môn học";
         this.Load += new System.EventHandler(this.frmDSMonhoc_Load);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.edtSoGioHoc.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtTenMH.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtMaMH.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem btnThemMH;
      private DevExpress.XtraBars.BarButtonItem btnXoaMH;
      private DevExpress.XtraBars.BarButtonItem btnSuaMH;
      private DevExpress.XtraBars.BarButtonItem btnLuuMH;
      private DevExpress.XtraBars.BarButtonItem btnLammoiMH;
      private DevExpress.XtraGrid.GridControl gcMonHoc;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraEditors.TextEdit edtSoGioHoc;
      private DevExpress.XtraEditors.TextEdit edtTenMH;
      private DevExpress.XtraEditors.TextEdit edtMaMH;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
   }
}