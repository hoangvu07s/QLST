using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Common.Forms;
using Helper;

namespace QuanLySieuThi.HeThong
{
    public partial class KhoiPhucDuLieuForm : QuanLySieuThiForm
    {
        public KhoiPhucDuLieuForm()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new OpenFileDialog
                {
                    Filter = @"Backup Files(*.bak)|*.bak|All Files(*.*)|*.*",
                    FilterIndex = 0
                };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FileTextBox.Text = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void RestoreDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FileTextBox.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn file.", @"Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SaoLuuDuLieuConnetionString"].ConnectionString;
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    var sql = "Alter Database QuanLySieuThi  SET Single_User WITH Rollback Immediate ";
                    sql += string.Format("Restore Database QuanLySieuThi From Disk = '{0}' WITH REPLACE ",
                        FileTextBox.Text);
                    sql += "ALTER DATABASE QuanLySieuThi SET Multi_User";

                    var command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show(@"Khôi phục dữ liệu thành công.", @"Thông Báo", MessageBoxButtons.OK);

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
    }
}
