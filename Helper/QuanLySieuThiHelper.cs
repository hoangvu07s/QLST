using System;
using System.Diagnostics;

namespace Helper
{
    public static class QuanLySieuThiHelper
    {
        public static string NextId()
        {
            return Guid.NewGuid().ToString();
        }

        public static void LogError(Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }

        #region Extension method

        public static long ToLong(this string value)
        {
            return Convert.ToInt64(value);
        }

        public static decimal ToDecimal(this string value)
        {
            return Convert.ToDecimal(value);
        }

        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value);
        }

        #endregion
    }
}
