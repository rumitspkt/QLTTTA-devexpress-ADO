namespace QLTTTA.GUI
{
   partial class frmDangKyMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyMonHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThemGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLammoiGV = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbHocVien = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbLopHoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbKhoaHoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLopHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.btnDangKy,
            this.btnLammoiGV});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(214, 137);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDangKy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng ký";
            this.btnDangKy.Id = 3;
            this.btnDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKy.ImageOptions.Image")));
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(647, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 196);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(647, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 146);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(647, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 146);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Caption = "Thêm";
            this.btnThemGV.Id = 0;
            this.btnThemGV.ImageOptions.Image = global::QLTTTA.Properties.Resources.add;
            this.btnThemGV.ImageOptions.LargeImage = global::QLTTTA.Properties.Resources.add;
            this.btnThemGV.Name = "btnThemGV";
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Caption = "Xóa";
            this.btnXoaGV.Id = 1;
            this.btnXoaGV.Name = "btnXoaGV";
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Caption = "Sửa";
            this.btnSuaGV.Id = 2;
            this.btnSuaGV.ImageOptions.Image = global::QLTTTA.Properties.Resources.Pencil_icon;
            this.btnSuaGV.Name = "btnSuaGV";
            // 
            // btnLammoiGV
            // 
            this.btnLammoiGV.Caption = "Làm mới";
            this.btnLammoiGV.Id = 4;
            this.btnLammoiGV.ImageOptions.Image = global::QLTTTA.Properties.Resources.refresh;
            this.btnLammoiGV.Name = "btnLammoiGV";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbHocVien);
            this.layoutControl1.Controls.Add(this.cbbLopHoc);
            this.layoutControl1.Controls.Add(this.cbbKhoaHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 50);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(766, 41, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(647, 148);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbHocVien
            // 
            this.cbbHocVien.Location = new System.Drawing.Point(146, 16);
            this.cbbHocVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbbHocVien.MenuManager = this.barManager1;
            this.cbbHocVien.Name = "cbbHocVien";
            this.cbbHocVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbHocVien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbHocVien.Size = new System.Drawing.Size(485, 22);
            this.cbbHocVien.StyleController = this.layoutControl1;
            this.cbbHocVien.TabIndex = 12;
            // 
            // cbbLopHoc
            // 
            this.cbbLopHoc.Location = new System.Drawing.Point(146, 72);
            this.cbbLopHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLopHoc.MenuManager = this.barManager1;
            this.cbbLopHoc.Name = "cbbLopHoc";
            this.cbbLopHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLopHoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbLopHoc.Size = new System.Drawing.Size(485, 22);
            this.cbbLopHoc.StyleController = this.layoutControl1;
            this.cbbLopHoc.TabIndex = 11;
            // 
            // cbbKhoaHoc
            // 
            this.cbbKhoaHoc.Location = new System.Drawing.Point(146, 44);
            this.cbbKhoaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKhoaHoc.MenuManager = this.barManager1;
            this.cbbKhoaHoc.Name = "cbbKhoaHoc";
            this.cbbKhoaHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbKhoaHoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbKhoaHoc.Size = new System.Drawing.Size(485, 22);
            this.cbbKhoaHoc.StyleController = this.layoutControl1;
            this.cbbKhoaHoc.TabIndex = 9;
            this.cbbKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbbKhoaHoc_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(647, 148);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbKhoaHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(621, 28);
            this.layoutControlItem1.Text = "Mã - Tên khóa học";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(127, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbbLopHoc;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(621, 66);
            this.layoutControlItem3.Text = "Mã - Tên lớp học";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(127, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbHocVien;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(621, 28);
            this.layoutControlItem4.Text = "Mã - Họ tên học viên";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(127, 17);
            // 
            // frmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 196);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký môn học";
            this.Load += new System.EventHandler(this.frmDangKyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLopHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
      private DevExpress.XtraBars.BarButtonItem btnDangKy;
      private DevExpress.XtraBars.BarButtonItem btnLammoiGV;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
      private DevExpress.XtraEditors.ComboBoxEdit cbbLopHoc;
      private DevExpress.XtraEditors.ComboBoxEdit cbbKhoaHoc;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraEditors.ComboBoxEdit cbbHocVien;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
   }
}