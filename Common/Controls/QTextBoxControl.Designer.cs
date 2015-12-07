using System;
using System.Drawing;
using System.Windows.Forms;

namespace Common.Controls
{
    partial class QTextBoxControl : DevExpress.XtraEditors.TextEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Font = new Font("Times New Roman", 11.0F);
        }

        protected override void OnEditorLeave(EventArgs e)
        {
            base.OnEditorLeave(e);

            if (string.IsNullOrWhiteSpace(Text))
            {
                MessageBox.Show(@"Vui lòng không nhập ký tự trống", @"Thông Báo", MessageBoxButtons.OK);
                Text = string.Empty;
            }
            else
            {
                Text = Text.Trim();
            }
        }

        #endregion
    }
}
