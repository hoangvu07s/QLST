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
    }
}
