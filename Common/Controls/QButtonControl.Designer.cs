using System.Drawing;

namespace Common.Controls
{
    partial class QButtonControl : DevExpress.XtraEditors.SimpleButton
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
        private void InitializeComponent(){
            components = new System.ComponentModel.Container();
            Font = new Font("Segoe UI", 11.0f);
            Size = new Size(120,30);
        }

        #endregion
    }
}
