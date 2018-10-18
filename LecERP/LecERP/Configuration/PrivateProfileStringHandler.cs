using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
	public static class PrivateProfileStringHandler
	{
		[DllImport("kernel32")]
		private static extern bool WritePrivateProfileString(string AppName, string KeyName, string IpString, string FileName);


		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string AppName, string KeyName, string lpDefault, StringBuilder ReturnedString, int Size, string FileName);

		public static string ReadPrivateProfileString(string Key)
		{
			string retval = "";
			try
			{
				if (!Directory.Exists(string.Format(StaticData.LogDataFolder, Environment.UserName)))
					Directory.CreateDirectory(string.Format(StaticData.LogDataFolder, Environment.UserName));
				if (!File.Exists(string.Format(StaticData.LogDataFileName, Environment.UserName)))
					File.Create(string.Format(StaticData.LogDataFileName, Environment.UserName));
				StringBuilder username = new StringBuilder(100);
				GetPrivateProfileString(StaticData.AppName, "USERNAME", "", username, 100, string.Format(StaticData.LogDataFileName, Environment.UserName));
				retval = username.ToString();
			}
			catch { }
			return retval;
		}
		public static void SetPrivateProfileString(string Key,string Value)
		{
				try
				{
					WritePrivateProfileString(StaticData.AppName, Key, Value, string.Format(StaticData.LogDataFileName));
				}
				catch { }
		}
	}
}
