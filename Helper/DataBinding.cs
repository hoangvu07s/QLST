using System;
using DevExpress.XtraEditors;

namespace Helper
{
    public static class DataBinding
    {
        public static void BindEditor(BaseControl control, string propertyName, Object dataSource, string filedName)
        {
            try
            {
                control.DataBindings.Clear();
                control.DataBindings.Add(propertyName, dataSource, filedName, true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public static void BindLookupEdit(LookUpEdit control, string propertyName, Object entity, Object dataSource,
            string fieldName, string displayMember, string valueMember)
        {
            try
            {
                control.DataBindings.Clear();
                control.DataBindings.Add(propertyName, entity, fieldName, true);
                control.Properties.DataSource = dataSource;
                control.Properties.ValueMember = valueMember;
                control.Properties.DisplayMember = displayMember;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
