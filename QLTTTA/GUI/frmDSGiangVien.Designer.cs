namespace QLTTTA.GUI
{
   partial class frmDSGiangVien
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSGiangVien));
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.btnThemGV = new DevExpress.XtraBars.BarButtonItem();
         this.btnSuaGV = new DevExpress.XtraBars.BarButtonItem();
         this.btnXoaGV = new DevExpress.XtraBars.BarButtonItem();
         this.btnLuuGV = new DevExpress.XtraBars.BarButtonItem();
         this.btnLammoiGV = new DevExpress.XtraBars.BarButtonItem();
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.edtLuong = new DevExpress.XtraEditors.TextEdit();
         this.cbbHocVi = new DevExpress.XtraEditors.ComboBoxEdit();
         this.cbbMail = new DevExpress.XtraEditors.ComboBoxEdit();
         this.nmrThamNien = new System.Windows.Forms.NumericUpDown();
         this.dateEdtNgaySinh = new DevExpress.XtraEditors.DateEdit();
         this.edtHoTen = new DevExpress.XtraEditors.TextEdit();
         this.edtMaGV = new DevExpress.XtraEditors.TextEdit();
         this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.gcGiangVien = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.edtLuong.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cbbHocVi.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cbbMail.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nmrThamNien)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dateEdtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dateEdtNgaySinh.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtHoTen.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtMaGV.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcGiangVien)).BeginInit();
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
            this.btnThemGV,
            this.btnXoaGV,
            this.btnSuaGV,
            this.btnLuuGV,
            this.btnLammoiGV,
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
         this.bar2.FloatLocation = new System.Drawing.Point(214, 137);
         this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemGV, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaGV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaGV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuGV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLammoiGV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // btnThemGV
         // 
         this.btnThemGV.Caption = "Thêm";
         this.btnThemGV.Id = 0;
         this.btnThemGV.ImageOptions.Image = global::QLTTTA.Properties.Resources.add;
         this.btnThemGV.ImageOptions.LargeImage = global::QLTTTA.Properties.Resources.add;
         this.btnThemGV.Name = "btnThemGV";
         this.btnThemGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemGV_ItemClick);
         // 
         // btnSuaGV
         // 
         this.btnSuaGV.Caption = "Sửa";
         this.btnSuaGV.Id = 2;
         this.btnSuaGV.ImageOptions.Image = global::QLTTTA.Properties.Resources.Pencil_icon;
         this.btnSuaGV.Name = "btnSuaGV";
         this.btnSuaGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaGV_ItemClick);
         // 
         // btnXoaGV
         // 
         this.btnXoaGV.Caption = "Xóa";
         this.btnXoaGV.Id = 1;
         this.btnXoaGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaGV.ImageOptions.Image")));
         this.btnXoaGV.Name = "btnXoaGV";
         this.btnXoaGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaGV_ItemClick);
         // 
         // btnLuuGV
         // 
         this.btnLuuGV.Caption = "Lưu lại";
         this.btnLuuGV.Id = 3;
         this.btnLuuGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuGV.ImageOptions.Image")));
         this.btnLuuGV.Name = "btnLuuGV";
         this.btnLuuGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuGV_ItemClick);
         // 
         // btnLammoiGV
         // 
         this.btnLammoiGV.Caption = "Làm mới";
         this.btnLammoiGV.Id = 4;
         this.btnLammoiGV.ImageOptions.Image = global::QLTTTA.Properties.Resources.refresh;
         this.btnLammoiGV.Name = "btnLammoiGV";
         this.btnLammoiGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoiGV_ItemClick);
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "Xuất Excel";
         this.barButtonItem1.Id = 5;
         this.barButtonItem1.ImageOptions.Image = global::QLTTTA.Properties.Resources.Excel_2_icon;
         this.barButtonItem1.Name = "barButtonItem1";
         this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
         this.layoutControl1.Controls.Add(this.edtLuong);
         this.layoutControl1.Controls.Add(this.cbbHocVi);
         this.layoutControl1.Controls.Add(this.cbbMail);
         this.layoutControl1.Controls.Add(this.nmrThamNien);
         this.layoutControl1.Controls.Add(this.dateEdtNgaySinh);
         this.layoutControl1.Controls.Add(this.edtHoTen);
         this.layoutControl1.Controls.Add(this.edtMaGV);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.layoutControl1.Location = new System.Drawing.Point(0, 40);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(766, 41, 450, 400);
         this.layoutControl1.Root = this.layoutControlGroup1;
         this.layoutControl1.Size = new System.Drawing.Size(590, 120);
         this.layoutControl1.TabIndex = 4;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // edtLuong
         // 
         this.edtLuong.Enabled = false;
         this.edtLuong.Location = new System.Drawing.Point(390, 84);
         this.edtLuong.MenuManager = this.barManager1;
         this.edtLuong.Name = "edtLuong";
         this.edtLuong.Size = new System.Drawing.Size(188, 20);
         this.edtLuong.StyleController = this.layoutControl1;
         this.edtLuong.TabIndex = 12;
         // 
         // cbbHocVi
         // 
         this.cbbHocVi.Enabled = false;
         this.cbbHocVi.Location = new System.Drawing.Point(95, 84);
         this.cbbHocVi.MenuManager = this.barManager1;
         this.cbbHocVi.Name = "cbbHocVi";
         this.cbbHocVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.cbbHocVi.Properties.Items.AddRange(new object[] {
            "Cu Nhan",
            "Thac Si",
            "Tien Si"});
         this.cbbHocVi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
         this.cbbHocVi.Size = new System.Drawing.Size(208, 20);
         this.cbbHocVi.StyleController = this.layoutControl1;
         this.cbbHocVi.TabIndex = 11;
         // 
         // cbbMail
         // 
         this.cbbMail.Enabled = false;
         this.cbbMail.Location = new System.Drawing.Point(95, 60);
         this.cbbMail.MenuManager = this.barManager1;
         this.cbbMail.Name = "cbbMail";
         this.cbbMail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.cbbMail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
         this.cbbMail.Size = new System.Drawing.Size(483, 20);
         this.cbbMail.StyleController = this.layoutControl1;
         this.cbbMail.TabIndex = 10;
         // 
         // nmrThamNien
         // 
         this.nmrThamNien.Enabled = false;
         this.nmrThamNien.Location = new System.Drawing.Point(392, 36);
         this.nmrThamNien.Name = "nmrThamNien";
         this.nmrThamNien.Size = new System.Drawing.Size(186, 20);
         this.nmrThamNien.TabIndex = 9;
         // 
         // dateEdtNgaySinh
         // 
         this.dateEdtNgaySinh.EditValue = null;
         this.dateEdtNgaySinh.Enabled = false;
         this.dateEdtNgaySinh.Location = new System.Drawing.Point(95, 36);
         this.dateEdtNgaySinh.MenuManager = this.barManager1;
         this.dateEdtNgaySinh.Name = "dateEdtNgaySinh";
         this.dateEdtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dateEdtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dateEdtNgaySinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
         this.dateEdtNgaySinh.Size = new System.Drawing.Size(210, 20);
         this.dateEdtNgaySinh.StyleController = this.layoutControl1;
         this.dateEdtNgaySinh.TabIndex = 8;
         // 
         // edtHoTen
         // 
         this.edtHoTen.Enabled = false;
         this.edtHoTen.Location = new System.Drawing.Point(390, 12);
         this.edtHoTen.MenuManager = this.barManager1;
         this.edtHoTen.Name = "edtHoTen";
         this.edtHoTen.Size = new System.Drawing.Size(188, 20);
         this.edtHoTen.StyleController = this.layoutControl1;
         this.edtHoTen.TabIndex = 6;
         // 
         // edtMaGV
         // 
         this.edtMaGV.Enabled = false;
         this.edtMaGV.Location = new System.Drawing.Point(95, 12);
         this.edtMaGV.MenuManager = this.barManager1;
         this.edtMaGV.Name = "edtMaGV";
         this.edtMaGV.Size = new System.Drawing.Size(208, 20);
         this.edtMaGV.StyleController = this.layoutControl1;
         this.edtMaGV.TabIndex = 4;
         // 
         // layoutControlGroup1
         // 
         this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.layoutControlGroup1.GroupBordersVisible = false;
         this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem2});
         this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlGroup1.Name = "Root";
         this.layoutControlGroup1.Size = new System.Drawing.Size(590, 120);
         this.layoutControlGroup1.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.edtMaGV;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(295, 24);
         this.layoutControlItem1.Text = "Mã giảng viên";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 13);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.edtHoTen;
         this.layoutControlItem3.Location = new System.Drawing.Point(295, 0);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(275, 24);
         this.layoutControlItem3.Text = "Họ tên";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 13);
         // 
         // layoutControlItem5
         // 
         this.layoutControlItem5.Control = this.dateEdtNgaySinh;
         this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
         this.layoutControlItem5.Name = "layoutControlItem5";
         this.layoutControlItem5.Size = new System.Drawing.Size(297, 24);
         this.layoutControlItem5.Text = "Ngày sinh";
         this.layoutControlItem5.TextSize = new System.Drawing.Size(80, 13);
         // 
         // layoutControlItem6
         // 
         this.layoutControlItem6.Control = this.nmrThamNien;
         this.layoutControlItem6.Location = new System.Drawing.Point(297, 24);
         this.layoutControlItem6.Name = "layoutControlItem6";
         this.layoutControlItem6.Size = new System.Drawing.Size(273, 24);
         this.layoutControlItem6.Text = "Thâm niên (năm)";
         this.layoutControlItem6.TextSize = new System.Drawing.Size(80, 13);
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.cbbMail;
         this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(570, 24);
         this.layoutControlItem4.Text = "Mail";
         this.layoutControlItem4.TextSize = new System.Drawing.Size(80, 13);
         // 
         // layoutControlItem7
         // 
         this.layoutControlItem7.Control = this.cbbHocVi;
         this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
         this.layoutControlItem7.Name = "layoutControlItem7";
         this.layoutControlItem7.Size = new System.Drawing.Size(295, 28);
         this.layoutControlItem7.Text = "Học vị";
         this.layoutControlItem7.TextSize = new System.Drawing.Size(80, 13);
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.edtLuong;
         this.layoutControlItem2.Location = new System.Drawing.Point(295, 72);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(275, 28);
         this.layoutControlItem2.Text = "Lương";
         this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
         // 
         // gcGiangVien
         // 
         this.gcGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcGiangVien.Location = new System.Drawing.Point(0, 160);
         this.gcGiangVien.MainView = this.gridView1;
         this.gcGiangVien.MenuManager = this.barManager1;
         this.gcGiangVien.Name = "gcGiangVien";
         this.gcGiangVien.Size = new System.Drawing.Size(590, 192);
         this.gcGiangVien.TabIndex = 5;
         this.gcGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn6,
            this.gridColumn7});
         this.gridView1.GridControl = this.gcGiangVien;
         this.gridView1.Name = "gridView1";
         this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
         // 
         // gridColumn1
         // 
         this.gridColumn1.Caption = "Mã giảng viên";
         this.gridColumn1.FieldName = "MaGV";
         this.gridColumn1.Name = "gridColumn1";
         this.gridColumn1.OptionsColumn.AllowEdit = false;
         this.gridColumn1.OptionsColumn.AllowFocus = false;
         this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn1.Visible = true;
         this.gridColumn1.VisibleIndex = 0;
         // 
         // gridColumn2
         // 
         this.gridColumn2.Caption = "Tên giảng viên";
         this.gridColumn2.FieldName = "TenGV";
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
         this.gridColumn4.Caption = "Thâm niên";
         this.gridColumn4.FieldName = "ThamNien";
         this.gridColumn4.Name = "gridColumn4";
         this.gridColumn4.OptionsColumn.AllowEdit = false;
         this.gridColumn4.OptionsColumn.AllowFocus = false;
         this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn4.Visible = true;
         this.gridColumn4.VisibleIndex = 3;
         // 
         // gridColumn5
         // 
         this.gridColumn5.Caption = "Học vị";
         this.gridColumn5.FieldName = "HocVi";
         this.gridColumn5.Name = "gridColumn5";
         this.gridColumn5.OptionsColumn.AllowEdit = false;
         this.gridColumn5.OptionsColumn.AllowFocus = false;
         this.gridColumn5.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn5.Visible = true;
         this.gridColumn5.VisibleIndex = 4;
         // 
         // gridColumn6
         // 
         this.gridColumn6.Caption = "Lương";
         this.gridColumn6.FieldName = "Luong";
         this.gridColumn6.Name = "gridColumn6";
         this.gridColumn6.OptionsColumn.AllowEdit = false;
         this.gridColumn6.OptionsColumn.AllowFocus = false;
         this.gridColumn6.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn6.Visible = true;
         this.gridColumn6.VisibleIndex = 5;
         // 
         // gridColumn7
         // 
         this.gridColumn7.Caption = "Mail";
         this.gridColumn7.FieldName = "Mail";
         this.gridColumn7.Name = "gridColumn7";
         this.gridColumn7.OptionsColumn.AllowEdit = false;
         this.gridColumn7.OptionsColumn.AllowFocus = false;
         this.gridColumn7.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn7.Visible = true;
         this.gridColumn7.VisibleIndex = 6;
         // 
         // frmDSGiangVien
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(590, 352);
         this.Controls.Add(this.gcGiangVien);
         this.Controls.Add(this.layoutControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "frmDSGiangVien";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Danh sách giảng viên";
         this.Load += new System.EventHandler(this.frmDSGiangVien_Load);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.edtLuong.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cbbHocVi.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cbbMail.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nmrThamNien)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dateEdtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dateEdtNgaySinh.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtHoTen.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtMaGV.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcGiangVien)).EndInit();
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
      private DevExpress.XtraBars.BarButtonItem btnThemGV;
      private DevExpress.XtraBars.BarButtonItem btnXoaGV;
      private DevExpress.XtraBars.BarButtonItem btnSuaGV;
      private DevExpress.XtraBars.BarButtonItem btnLuuGV;
      private DevExpress.XtraBars.BarButtonItem btnLammoiGV;
      private DevExpress.XtraGrid.GridControl gcGiangVien;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraEditors.TextEdit edtHoTen;
      private DevExpress.XtraEditors.TextEdit edtMaGV;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraEditors.DateEdit dateEdtNgaySinh;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
      private DevExpress.XtraEditors.ComboBoxEdit cbbHocVi;
      private DevExpress.XtraEditors.ComboBoxEdit cbbMail;
      private System.Windows.Forms.NumericUpDown nmrThamNien;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
      private DevExpress.XtraEditors.TextEdit edtLuong;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
   }
}