using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLNhaSach.Modules;

namespace QLNhaSach
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //Variable Gobal
        public string maNV;
        frmDoiMatKhau fDoiMatKhau;
        //XU ly phan quyen
        public void enableControl(int maLTK)
        {
            switch(maLTK)
            {
                case 1://admin
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = true;
                    break;
                case 2: //Nhan vien ban hang
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = false;
                    btnSanPham.Enabled = false;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = false;
                    break;
                case 3: //Nhan vien quan ly kho
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = false;
                    btnTaoHoaDon.Enabled = false;
                    btnThongKe.Enabled = false;
                    break;
                default:
                    btnDangXuat.Enabled = false;
                    btnDoiMK.Enabled = false;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = false;
                    btnTaoHoaDon.Enabled = false;
                    btnThongKe.Enabled = false;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Xu ly dong tat ca form con
            foreach (Form f in this.MdiChildren)
            {
                this.Close();
            }
            frmMain_Load(sender, e);
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fDoiMatKhau == null)
            {
                fDoiMatKhau = new frmDoiMatKhau();
                fDoiMatKhau.MdiParent = this;
                fDoiMatKhau.WindowState = FormWindowState.Maximized;
                fDoiMatKhau.Show();
            }
            else 
            {
                fDoiMatKhau.Activate();
                fDoiMatKhau.Show();
            }
        }
    }
}