/**********************************************************************************************************/
/**********       Copyright - 2015 Integrated Dynamic Solutions Inc. All Rights Reserved         **********/
/**********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Buisness.DAL
{
    public class DataParser
    {

        /// <summary>
        /// Parses data reader to short integer value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name.</param>
        /// <param name="sDefaultValue">Default value to be returned on error and null.</param>
        /// <returns>Returns value</returns>
        public static short GetSafeShort(IDataReader reader, string strField, short sDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return sDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? sDefaultValue : reader.GetInt16(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return sDefaultValue;
            }
        }

        /// <summary>
        /// Parses data reader to integer value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="iDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static int GetSafeInt(IDataReader reader, string strField, int iDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return iDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? iDefaultValue : reader.GetInt32(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return iDefaultValue;
            }
        }


        /// <summary>
        /// Parses data reader to Int16 value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="iDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static short GetSafeInt16(IDataReader reader, string strField, short sDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return sDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? sDefaultValue : reader.GetInt16(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return sDefaultValue;
            }
        }

        /// <summary>
        /// Parses data reader to long value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="lDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        static public long GetSafeLong(IDataReader reader, string strField, long lDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return lDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? lDefaultValue : reader.GetInt64(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return lDefaultValue;
            }
        }

        /// <summary>
        /// Parses data reader to byte value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="bytDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static byte GetSafeByte(IDataReader reader, string strField, byte bytDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return bytDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? bytDefaultValue : reader.GetByte(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return bytDefaultValue;
            }
        }

        /// <summary>
        /// Parses data reader to byte array.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="bytDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static byte[] GetSafeBytes(IDataReader reader, string strField, byte[] bytDefaultValue)
        {
            byte[] bytImg = null;

            if (reader == null || strField == null || strField.Length == 0)
                return bytDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                if (reader.IsDBNull(iOrdinal))
                {
                    return bytDefaultValue;
                }
                else
                {
                    bytImg = new byte[reader.GetBytes(iOrdinal, 0, bytImg, 0, int.MaxValue)];
                    reader.GetBytes(iOrdinal, 0, bytImg, 0, int.MaxValue);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                return bytDefaultValue;
            }

            return bytImg;
        }

        /// <summary>
        /// Parses data reader to float value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="fDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static float GetSafeFloat(IDataReader reader, string strField, float fDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return fDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? fDefaultValue : reader.GetFloat(iOrdinal));
            }
            catch (IndexOutOfRangeException )
            {
                return fDefaultValue;
            }
        }

        /// <summary>
        /// Parses data reader to double value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="dblDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static double GetSafeDouble(IDataReader reader, string strField, double dblDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return dblDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? dblDefaultValue : reader.GetDouble(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return dblDefaultValue;
            }
        }

        /// <summary>
        /// Parses data reader to decimal value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="decDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static decimal GetSafeDecimal(IDataReader reader, string strField, decimal decDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return decDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? decDefaultValue : reader.GetDecimal(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return decDefaultValue;
            }
        }


        /// <summary>
        /// Parses data reader to bool value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="bDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static bool GetSafeBool(IDataReader reader, string strField, bool bDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return bDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? bDefaultValue : reader.GetBoolean(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return bDefaultValue;
            }
        }


        /// <summary>
        /// Parses data reader to DateTime value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="dtmDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static DateTime GetSafeDateTime(IDataReader reader, string strField, DateTime dtmDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return dtmDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? dtmDefaultValue : reader.GetDateTime(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return dtmDefaultValue;
            }
        }

        /// <summary>
        /// Parses data reader to string value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="strDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static string GetSafeString(IDataReader reader, string strField, string strDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return strDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? strDefaultValue : reader.GetString(iOrdinal));
            }
            catch (IndexOutOfRangeException e)
            {
                return strDefaultValue;
            }
        }

        /// <summary>
        /// Parses data reader to guid value.
        /// </summary>
        /// <param name="reader">IDataReader object.</param>
        /// <param name="strField">Field or Coloumn Name</param>
        /// <param name="guidDefaultValue">Default value to be returned on error and null.</param>
        /// <returns></returns>
        public static Guid GetSafeGuid(IDataReader reader, string strField, Guid guidDefaultValue)
        {
            if (reader == null || strField == null || strField.Length == 0)
                return guidDefaultValue;

            try
            {
                int iOrdinal = reader.GetOrdinal(strField);
                return (reader.IsDBNull(iOrdinal) ? guidDefaultValue : reader.GetGuid(iOrdinal));
            }
            catch (IndexOutOfRangeException)
            {
                return guidDefaultValue;
            }
        }
    }
}
