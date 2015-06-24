﻿using System;
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

        #endregion
    }
}