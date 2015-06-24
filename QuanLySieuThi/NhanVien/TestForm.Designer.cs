using Common.Forms;

namespace QuanLySieuThi.NhanVien
{
    partial class TestForm : QuanLySieuThiForm
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
            this.TextTextBox = new Common.Controls.QTextBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.TextTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(96, 62);
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TextTextBox.Properties.Appearance.Options.UseFont = true;
            this.TextTextBox.Size = new System.Drawing.Size(100, 26);
            this.TextTextBox.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TextTextBox);
            this.Name = "TestForm";
            this.Text = "TestForm";((System.ComponentModel.ISupportInitialize)(this.TextTextBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Controls.QTextBoxControl TextTextBox;
    }
}