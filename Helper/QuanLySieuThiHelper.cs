using System;
using System.Diagnostics;
using AutoMapper;

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

        public static T DeepCopy<T>(this T instance)
        {
            Mapper.CreateMap<T, T>();
            return Mapper.Map<T>(instance);
        }

        public static bool IsEncrypted(string stringValue)
        {
            try
            {
                stringValue.Decrypt();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
