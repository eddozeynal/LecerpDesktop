﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public static class ExtensionMethods
    {
        public static DateTime GetDateFromFormattedString(this string FormattedString)
        {
            int year = Convert.ToInt32(FormattedString.Substring(0, 4));
            int month = Convert.ToInt32(FormattedString.Substring(4, 2));
            int day = Convert.ToInt32(FormattedString.Substring(6, 2));
            int hour = Convert.ToInt32(FormattedString.Substring(8, 2));
            int minute = Convert.ToInt32(FormattedString.Substring(10, 2));
            int second = Convert.ToInt32(FormattedString.Substring(12, 2));
            return new DateTime(year, month, day, hour, minute, second);
        }
        public static string GetFormattedStringFromDate(this DateTime Date)
        {
            string retval = "";
            retval += Date.Year.ToString();
            if (Date.Month < 10) retval += "0";
            retval += Date.Month.ToString();
            if (Date.Day < 10) retval += "0";
            retval += Date.Day.ToString();
            if (Date.Hour < 10) retval += "0";
            retval += Date.Hour.ToString();
            if (Date.Minute < 10) retval += "0";
            retval += Date.Minute.ToString();
            if (Date.Second < 10) retval += "0";
            retval += Date.Second.ToString();
            return retval;
        }

        public static T GetEligibleOjbect<T>(this object Value)
        {
            string SerializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(Value);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(SerializedObject);
        }

        public static List<T> GetSelectedRows<T>(this DevExpress.XtraGrid.Views.Grid.GridView GridView)
        {
            List<T> list = new List<T>();
            foreach (int i in GridView.GetSelectedRows())
            {
                T item = (T)GridView.GetRow(i);
                list.Add(item);
            }
            return list;
        }

        public static T DeepClone<T>(this T t)
        {
            string ser = Newtonsoft.Json.JsonConvert.SerializeObject(t);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(ser);
        }
    }
}
