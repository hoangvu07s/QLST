using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Common.Forms;
using Helper;

namespace QuanLySieuThi.HeThong
{
    public partial class SaoLuuDuLieuForm : QuanLySieuThiForm
    {
        public SaoLuuDuLieuForm()
        {
            InitializeComponent();
        }

        private void SelectThuMucButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ThuMucTextBox.Text = dlg.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void CopyDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ThuMucTextBox.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn đường dẫn đến thư mục sao lưu dữ liệu.", @"Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SaoLuuDuLieuConnetionString"].ConnectionString;
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    var sql = string.Format("BACKUP DATABASE QuanLySieuThi TO DISK = '{0}\\QuanLySieuThi_{1}.bak'",
                        ThuMucTextBox.Text, DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss"));
                    var command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show(@"Sao lưu dữ liệu thành công.", @"Thông Báo", MessageBoxButtons.OK);

                    connection.Close();
                    connection.Dispose();

                    Close();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
