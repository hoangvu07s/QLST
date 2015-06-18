using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Helper;
using Model;

namespace Common.Forms
{
    public enum FormMode
    {
        Add,
        Edit,
        View
    }

    public partial class QuanLySieuThiForm
    {
        #region Properties
        private bool _canceled;
        public bool IsFromProcessing = false;
        public bool IsFormLoading = false;

        private QuanLySieuThiEntities _entities;

        public QuanLySieuThiEntities Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = new QuanLySieuThiEntities();
                }
                return _entities;
            }
            set { _entities = value; }
        }
        public static Dictionary<string, Form> ListForms = new Dictionary<string, Form>();
        public object Entity { get; set; }
        public string EntityId;
        public long? CurrentUserId { get; set; }
        public FormMode FormMode = FormMode.Add;

        private int _minimumSizeWidth;

        public int MinimumSizeWidth
        {
            get { return _minimumSizeWidth; }
            set { _minimumSizeWidth = value; }
        }

        private int _minimumSizeHeight;

        public int MinimumSizeHeight
        {
            get { return _minimumSizeHeight; }
            set { _minimumSizeHeight = value; }
        }

        private string _parentName = string.Empty;

        public string ParentName
        {
            get { return _parentName; }
            set { _parentName = value; }
        }


        public QuanLySieuThiForm()
        {
            InitializeComponent();
            Entity = new object();
        }

        #endregion

        #region Override methods
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                IsFormLoading = true;
                MinimumSize = new Size(MinimumSizeWidth, MinimumSizeHeight);
                LoadData(e);
                BindData(e);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
            finally
            {
                IsFormLoading = false;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            try
            {
                if (!_canceled)
                {
                    CollectInput(e);
                    if (ValidateInput(e))
                    {
                        SaveData(e);
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            try
            {
                Entities.Dispose();
                _entities = null;
                ListForms.Remove(ParentName);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        #endregion

        #region User define mothods
        public virtual void LoadData(EventArgs e)
        {

        }

        public virtual void BindData(EventArgs e)
        {

        }

        public virtual void CollectInput(EventArgs e)
        {

        }

        public virtual bool ValidateInput(EventArgs e)
        {
            return true;
        }

        public virtual void SaveData(EventArgs e)
        {

        }

        public virtual void Cancel()
        {
            DialogResult = DialogResult.OK;
            _canceled = true;
            Close();
        }

        public virtual void AcceptAndSavechange()
        {
            DialogResult = DialogResult.OK;
            _canceled = false;
            Close();
        }

        public void ShowForm(string parentName = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(parentName) && !ListForms.ContainsKey(parentName))
                {
                    _parentName = parentName;
                    ListForms.Add(parentName, this);
                    Show();
                }

                Form form = null;
                if (parentName != null) ListForms.TryGetValue(parentName, out form);
                if (form != null) form.Activate();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public void ResetEntities()
        {
            try
            {
                _entities = null;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
        #endregion
        
    }
}
