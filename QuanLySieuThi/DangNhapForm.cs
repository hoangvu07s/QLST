using System;
using System.Windows.Forms;
using Helper;
using Service;

namespace QuanLySieuThi
{
    public partial class DangNhapForm
    {
        private readonly NhanVienService _nhanVienService;

        public DangNhapForm()
        {
            InitializeComponent();
            _nhanVienService = new NhanVienService(Entities);
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {                
                Hide();
                var mainForm = new MainForm();
                mainForm.Show();

                mainForm.FormClosed += MainFormOnFormClosed;
            }
        }

        private void MainFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            Close();
        }

        private bool ValidateInput()
        {
            try
            {
                var tenDangNhap = TenDangNhapTextBox.Text;
                var matKhau = MatKhauTextBox.Text;

                if (string.IsNullOrEmpty(tenDangNhap))
                {
                    MessageBox.Show(
                                @"Vui lòng nhập Tên Đăng Nhập",
                                @"Thông Báo", MessageBoxButtons.OK);

                    return false;
                }

                if (string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show(
                                @"Vui lòng nhập Mật Khẩu",
                                @"Thông Báo", MessageBoxButtons.OK);

                    return false;
                }

                var nhanVien = _nhanVienService.GetByTenDangNhap(tenDangNhap);

                if (nhanVien == null)
                {
                    MessageBox.Show(
                                @"Tên Đăng Nhập không tồn tại",
                                @"Thông Báo", MessageBoxButtons.OK);

                    return false;
                }

                if (nhanVien.MatKhau.Decrypt() != matKhau)
                {
                    MessageBox.Show(
                        @"Mật Khẩu không đúng. Vui lòng kiểm tra lại Mật Khẩu",
                        @"Thông Báo", MessageBoxButtons.OK);

                    return false;
                }

                CurrentFormInfo.CurrentUserId = nhanVien.Id;
                return true;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return false;
        }
    }
}
