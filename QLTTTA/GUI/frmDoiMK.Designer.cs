namespace QLTTTA.GUI
{
   partial class frmDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMK));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLuuDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnLammoiDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThemMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaMH = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.edtMKXacNhan = new DevExpress.XtraEditors.TextEdit();
            this.edtMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.edtMKHienTai = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMKXacNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMKHienTai.Properties)).BeginInit();
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
            this.btnThemMH,
            this.btnXoaMH,
            this.btnSuaMH,
            this.btnLuuDoiMK,
            this.btnLammoiDoiMK});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuDoiMK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLammoiDoiMK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLuuDoiMK
            // 
            this.btnLuuDoiMK.Caption = "Lưu lại";
            this.btnLuuDoiMK.Id = 3;
            this.btnLuuDoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDoiMK.ImageOptions.Image")));
            this.btnLuuDoiMK.Name = "btnLuuDoiMK";
            this.btnLuuDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuDoiMK_ItemClick);
            // 
            // btnLammoiDoiMK
            // 
            this.btnLammoiDoiMK.Caption = "Làm mới";
            this.btnLammoiDoiMK.Id = 4;
            this.btnLammoiDoiMK.ImageOptions.Image = global::QLTTTA.Properties.Resources.refresh;
            this.btnLammoiDoiMK.Name = "btnLammoiDoiMK";
            this.btnLammoiDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoiDoiMK_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(647, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 192);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(647, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 142);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(647, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 142);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Caption = "Thêm";
            this.btnThemMH.Id = 0;
            this.btnThemMH.ImageOptions.Image = global::QLTTTA.Properties.Resources.add;
            this.btnThemMH.ImageOptions.LargeImage = global::QLTTTA.Properties.Resources.add;
            this.btnThemMH.Name = "btnThemMH";
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Caption = "Xóa";
            this.btnXoaMH.Id = 1;
            this.btnXoaMH.Name = "btnXoaMH";
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Caption = "Sửa";
            this.btnSuaMH.Id = 2;
            this.btnSuaMH.ImageOptions.Image = global::QLTTTA.Properties.Resources.Pencil_icon;
            this.btnSuaMH.Name = "btnSuaMH";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.edtMKXacNhan);
            this.layoutControl1.Controls.Add(this.edtMKMoi);
            this.layoutControl1.Controls.Add(this.edtMKHienTai);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 50);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(766, 41, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(647, 148);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // edtMKXacNhan
            // 
            this.edtMKXacNhan.Location = new System.Drawing.Point(138, 72);
            this.edtMKXacNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtMKXacNhan.MenuManager = this.barManager1;
            this.edtMKXacNhan.Name = "edtMKXacNhan";
            this.edtMKXacNhan.Properties.PasswordChar = '*';
            this.edtMKXacNhan.Size = new System.Drawing.Size(493, 22);
            this.edtMKXacNhan.StyleController = this.layoutControl1;
            this.edtMKXacNhan.TabIndex = 3;
            // 
            // edtMKMoi
            // 
            this.edtMKMoi.Location = new System.Drawing.Point(138, 44);
            this.edtMKMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtMKMoi.MenuManager = this.barManager1;
            this.edtMKMoi.Name = "edtMKMoi";
            this.edtMKMoi.Properties.PasswordChar = '*';
            this.edtMKMoi.Size = new System.Drawing.Size(493, 22);
            this.edtMKMoi.StyleController = this.layoutControl1;
            this.edtMKMoi.TabIndex = 2;
            // 
            // edtMKHienTai
            // 
            this.edtMKHienTai.Location = new System.Drawing.Point(138, 16);
            this.edtMKHienTai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtMKHienTai.MenuManager = this.barManager1;
            this.edtMKHienTai.Name = "edtMKHienTai";
            this.edtMKHienTai.Properties.PasswordChar = '*';
            this.edtMKHienTai.Size = new System.Drawing.Size(493, 22);
            this.edtMKHienTai.StyleController = this.layoutControl1;
            this.edtMKHienTai.TabIndex = 0;
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
            this.layoutControlItem1.Control = this.edtMKHienTai;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(621, 28);
            this.layoutControlItem1.Text = "Mật khẩu hiện tại";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.edtMKMoi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(621, 28);
            this.layoutControlItem3.Text = "Mật khẩu mới";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtMKXacNhan;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(621, 66);
            this.layoutControlItem4.Text = "Xác nhận mật khẩu";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(119, 17);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 192);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtMKXacNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMKHienTai.Properties)).EndInit();
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
      private DevExpress.XtraBars.BarButtonItem btnThemMH;
      private DevExpress.XtraBars.BarButtonItem btnXoaMH;
      private DevExpress.XtraBars.BarButtonItem btnSuaMH;
      private DevExpress.XtraBars.BarButtonItem btnLuuDoiMK;
      private DevExpress.XtraBars.BarButtonItem btnLammoiDoiMK;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraEditors.TextEdit edtMKXacNhan;
      private DevExpress.XtraEditors.TextEdit edtMKMoi;
      private DevExpress.XtraEditors.TextEdit edtMKHienTai;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
   }
}