namespace QLTTTA.GUI
{
   partial class frmDSHocVien
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSHocVien));
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.btnThemHV = new DevExpress.XtraBars.BarButtonItem();
         this.btnSuaHV = new DevExpress.XtraBars.BarButtonItem();
         this.btnXoaHV = new DevExpress.XtraBars.BarButtonItem();
         this.btnLuuHV = new DevExpress.XtraBars.BarButtonItem();
         this.btnLammoiHV = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.dateEdtNgaySinh = new DevExpress.XtraEditors.DateEdit();
         this.edtDiaChi = new DevExpress.XtraEditors.TextEdit();
         this.edtHoTen = new DevExpress.XtraEditors.TextEdit();
         this.edtSoDT = new DevExpress.XtraEditors.TextEdit();
         this.edtMaHV = new DevExpress.XtraEditors.TextEdit();
         this.edtGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
         this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
         this.gcHocVien = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dateEdtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dateEdtNgaySinh.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtDiaChi.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtHoTen.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtSoDT.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtMaHV.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtGioiTinh.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcHocVien)).BeginInit();
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
            this.btnThemHV,
            this.btnXoaHV,
            this.btnSuaHV,
            this.btnLuuHV,
            this.btnLammoiHV,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemHV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaHV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaHV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuHV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLammoiHV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // btnThemHV
         // 
         this.btnThemHV.Caption = "Thêm";
         this.btnThemHV.Id = 0;
         this.btnThemHV.ImageOptions.Image = global::QLTTTA.Properties.Resources.add;
         this.btnThemHV.ImageOptions.LargeImage = global::QLTTTA.Properties.Resources.add;
         this.btnThemHV.Name = "btnThemHV";
         this.btnThemHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemHV_ItemClick_1);
         // 
         // btnSuaHV
         // 
         this.btnSuaHV.Caption = "Sửa";
         this.btnSuaHV.Id = 2;
         this.btnSuaHV.ImageOptions.Image = global::QLTTTA.Properties.Resources.Pencil_icon;
         this.btnSuaHV.Name = "btnSuaHV";
         this.btnSuaHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaHV_ItemClick_1);
         // 
         // btnXoaHV
         // 
         this.btnXoaHV.Caption = "Xóa";
         this.btnXoaHV.Id = 1;
         this.btnXoaHV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHV.ImageOptions.Image")));
         this.btnXoaHV.Name = "btnXoaHV";
         this.btnXoaHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaHV_ItemClick_1);
         // 
         // btnLuuHV
         // 
         this.btnLuuHV.Caption = "Lưu lại";
         this.btnLuuHV.Id = 3;
         this.btnLuuHV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuHV.ImageOptions.Image")));
         this.btnLuuHV.Name = "btnLuuHV";
         this.btnLuuHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuHV_ItemClick_1);
         // 
         // btnLammoiHV
         // 
         this.btnLammoiHV.Caption = "Làm mới";
         this.btnLammoiHV.Id = 4;
         this.btnLammoiHV.ImageOptions.Image = global::QLTTTA.Properties.Resources.refresh;
         this.btnLammoiHV.Name = "btnLammoiHV";
         this.btnLammoiHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoiHV_ItemClick_1);
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(590, 40);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 352);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(590, 0);
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
         this.barDockControlRight.Location = new System.Drawing.Point(590, 40);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 312);
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.dateEdtNgaySinh);
         this.layoutControl1.Controls.Add(this.edtDiaChi);
         this.layoutControl1.Controls.Add(this.edtHoTen);
         this.layoutControl1.Controls.Add(this.edtSoDT);
         this.layoutControl1.Controls.Add(this.edtMaHV);
         this.layoutControl1.Controls.Add(this.edtGioiTinh);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.layoutControl1.Location = new System.Drawing.Point(0, 40);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(766, 41, 450, 400);
         this.layoutControl1.Root = this.layoutControlGroup1;
         this.layoutControl1.Size = new System.Drawing.Size(590, 120);
         this.layoutControl1.TabIndex = 4;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // dateEdtNgaySinh
         // 
         this.dateEdtNgaySinh.EditValue = null;
         this.dateEdtNgaySinh.Enabled = false;
         this.dateEdtNgaySinh.Location = new System.Drawing.Point(361, 84);
         this.dateEdtNgaySinh.MenuManager = this.barManager1;
         this.dateEdtNgaySinh.Name = "dateEdtNgaySinh";
         this.dateEdtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dateEdtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dateEdtNgaySinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
         this.dateEdtNgaySinh.Size = new System.Drawing.Size(217, 20);
         this.dateEdtNgaySinh.StyleController = this.layoutControl1;
         this.dateEdtNgaySinh.TabIndex = 8;
         // 
         // edtDiaChi
         // 
         this.edtDiaChi.Enabled = false;
         this.edtDiaChi.Location = new System.Drawing.Point(77, 60);
         this.edtDiaChi.MenuManager = this.barManager1;
         this.edtDiaChi.Name = "edtDiaChi";
         this.edtDiaChi.Size = new System.Drawing.Size(215, 20);
         this.edtDiaChi.StyleController = this.layoutControl1;
         this.edtDiaChi.TabIndex = 7;
         // 
         // edtHoTen
         // 
         this.edtHoTen.Enabled = false;
         this.edtHoTen.Location = new System.Drawing.Point(77, 36);
         this.edtHoTen.MenuManager = this.barManager1;
         this.edtHoTen.Name = "edtHoTen";
         this.edtHoTen.Size = new System.Drawing.Size(501, 20);
         this.edtHoTen.StyleController = this.layoutControl1;
         this.edtHoTen.TabIndex = 6;
         // 
         // edtSoDT
         // 
         this.edtSoDT.Enabled = false;
         this.edtSoDT.Location = new System.Drawing.Point(77, 84);
         this.edtSoDT.MenuManager = this.barManager1;
         this.edtSoDT.Name = "edtSoDT";
         this.edtSoDT.Size = new System.Drawing.Size(215, 20);
         this.edtSoDT.StyleController = this.layoutControl1;
         this.edtSoDT.TabIndex = 5;
         // 
         // edtMaHV
         // 
         this.edtMaHV.Enabled = false;
         this.edtMaHV.Location = new System.Drawing.Point(77, 12);
         this.edtMaHV.MenuManager = this.barManager1;
         this.edtMaHV.Name = "edtMaHV";
         this.edtMaHV.Size = new System.Drawing.Size(501, 20);
         this.edtMaHV.StyleController = this.layoutControl1;
         this.edtMaHV.TabIndex = 4;
         // 
         // edtGioiTinh
         // 
         this.edtGioiTinh.Enabled = false;
         this.edtGioiTinh.Location = new System.Drawing.Point(361, 60);
         this.edtGioiTinh.MenuManager = this.barManager1;
         this.edtGioiTinh.Name = "edtGioiTinh";
         this.edtGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.edtGioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
         this.edtGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
         this.edtGioiTinh.Size = new System.Drawing.Size(217, 20);
         this.edtGioiTinh.StyleController = this.layoutControl1;
         this.edtGioiTinh.TabIndex = 9;
         // 
         // layoutControlGroup1
         // 
         this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.layoutControlGroup1.GroupBordersVisible = false;
         this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem8});
         this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlGroup1.Name = "Root";
         this.layoutControlGroup1.Size = new System.Drawing.Size(590, 120);
         this.layoutControlGroup1.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.edtMaHV;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(570, 24);
         this.layoutControlItem1.Text = "Mã học viên";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.edtHoTen;
         this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(570, 24);
         this.layoutControlItem3.Text = "Họ tên";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 13);
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.edtDiaChi;
         this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(284, 24);
         this.layoutControlItem4.Text = "Địa chỉ";
         this.layoutControlItem4.TextSize = new System.Drawing.Size(62, 13);
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.edtSoDT;
         this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(284, 28);
         this.layoutControlItem2.Text = "Số điện thoại";
         this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 13);
         // 
         // layoutControlItem5
         // 
         this.layoutControlItem5.Control = this.dateEdtNgaySinh;
         this.layoutControlItem5.Location = new System.Drawing.Point(284, 72);
         this.layoutControlItem5.Name = "layoutControlItem5";
         this.layoutControlItem5.Size = new System.Drawing.Size(286, 28);
         this.layoutControlItem5.Text = "Ngày sinh";
         this.layoutControlItem5.TextSize = new System.Drawing.Size(62, 13);
         // 
         // layoutControlItem8
         // 
         this.layoutControlItem8.Control = this.edtGioiTinh;
         this.layoutControlItem8.Location = new System.Drawing.Point(284, 48);
         this.layoutControlItem8.Name = "layoutControlItem8";
         this.layoutControlItem8.Size = new System.Drawing.Size(286, 24);
         this.layoutControlItem8.Text = "Giới tính";
         this.layoutControlItem8.TextSize = new System.Drawing.Size(62, 13);
         // 
         // gcHocVien
         // 
         this.gcHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcHocVien.Location = new System.Drawing.Point(0, 160);
         this.gcHocVien.MainView = this.gridView1;
         this.gcHocVien.MenuManager = this.barManager1;
         this.gcHocVien.Name = "gcHocVien";
         this.gcHocVien.Size = new System.Drawing.Size(590, 192);
         this.gcHocVien.TabIndex = 5;
         this.gcHocVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
         this.gridView1.GridControl = this.gcHocVien;
         this.gridView1.Name = "gridView1";
         this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
         // 
         // gridColumn1
         // 
         this.gridColumn1.Caption = "Mã học viên";
         this.gridColumn1.FieldName = "MaHV";
         this.gridColumn1.Name = "gridColumn1";
         this.gridColumn1.OptionsColumn.AllowEdit = false;
         this.gridColumn1.OptionsColumn.AllowFocus = false;
         this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn1.Visible = true;
         this.gridColumn1.VisibleIndex = 0;
         // 
         // gridColumn2
         // 
         this.gridColumn2.Caption = "Họ tên";
         this.gridColumn2.FieldName = "HoTen";
         this.gridColumn2.Name = "gridColumn2";
         this.gridColumn2.OptionsColumn.AllowEdit = false;
         this.gridColumn2.OptionsColumn.AllowFocus = false;
         this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn2.Visible = true;
         this.gridColumn2.VisibleIndex = 1;
         // 
         // gridColumn3
         // 
         this.gridColumn3.Caption = "Ngày sinh";
         this.gridColumn3.FieldName = "NgaySinh";
         this.gridColumn3.Name = "gridColumn3";
         this.gridColumn3.OptionsColumn.AllowEdit = false;
         this.gridColumn3.OptionsColumn.AllowFocus = false;
         this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn3.Visible = true;
         this.gridColumn3.VisibleIndex = 2;
         // 
         // gridColumn4
         // 
         this.gridColumn4.Caption = "Giới tính";
         this.gridColumn4.FieldName = "GioiTinh";
         this.gridColumn4.Name = "gridColumn4";
         this.gridColumn4.OptionsColumn.AllowEdit = false;
         this.gridColumn4.OptionsColumn.AllowFocus = false;
         this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn4.Visible = true;
         this.gridColumn4.VisibleIndex = 3;
         // 
         // gridColumn5
         // 
         this.gridColumn5.Caption = "Địa chỉ";
         this.gridColumn5.FieldName = "DiaChi";
         this.gridColumn5.Name = "gridColumn5";
         this.gridColumn5.OptionsColumn.AllowEdit = false;
         this.gridColumn5.OptionsColumn.AllowFocus = false;
         this.gridColumn5.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn5.Visible = true;
         this.gridColumn5.VisibleIndex = 4;
         // 
         // gridColumn6
         // 
         this.gridColumn6.Caption = "Số điện thoại";
         this.gridColumn6.FieldName = "SoDienThoai";
         this.gridColumn6.Name = "gridColumn6";
         this.gridColumn6.OptionsColumn.AllowEdit = false;
         this.gridColumn6.OptionsColumn.AllowFocus = false;
         this.gridColumn6.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn6.Visible = true;
         this.gridColumn6.VisibleIndex = 5;
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "Xuất Excel";
         this.barButtonItem1.Id = 5;
         this.barButtonItem1.ImageOptions.Image = global::QLTTTA.Properties.Resources.Excel_2_icon;
         this.barButtonItem1.Name = "barButtonItem1";
         this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
         // 
         // frmDSHocVien
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(590, 352);
         this.Controls.Add(this.gcHocVien);
         this.Controls.Add(this.layoutControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "frmDSHocVien";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Danh sách học viên";
         this.Load += new System.EventHandler(this.frmDSHocVien_Load);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dateEdtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dateEdtNgaySinh.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtDiaChi.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtHoTen.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtSoDT.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtMaHV.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtGioiTinh.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcHocVien)).EndInit();
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
      private DevExpress.XtraBars.BarButtonItem btnThemHV;
      private DevExpress.XtraBars.BarButtonItem btnXoaHV;
      private DevExpress.XtraBars.BarButtonItem btnSuaHV;
      private DevExpress.XtraBars.BarButtonItem btnLuuHV;
      private DevExpress.XtraBars.BarButtonItem btnLammoiHV;
      private DevExpress.XtraGrid.GridControl gcHocVien;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraEditors.TextEdit edtDiaChi;
      private DevExpress.XtraEditors.TextEdit edtHoTen;
      private DevExpress.XtraEditors.TextEdit edtSoDT;
      private DevExpress.XtraEditors.TextEdit edtMaHV;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private DevExpress.XtraEditors.DateEdit dateEdtNgaySinh;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
      private DevExpress.XtraEditors.ComboBoxEdit edtGioiTinh;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
   }
}