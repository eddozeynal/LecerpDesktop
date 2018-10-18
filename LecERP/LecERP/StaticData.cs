﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LecERP.Configuration;
using LecERP.ServiceGates;

namespace LecERP
{
	public static class StaticData
	{
        public static IConfigManager ConfigManager = new ConfigFileManager();
        static Dictionary<string, object> _ConfigSettings = null;
        public static Dictionary<string, object> ConfigSettings
        {
            get
            {
                if (_ConfigSettings == null) _ConfigSettings = ConfigManager.ReadConfigSettings().Value;
                return _ConfigSettings;
            }
        }
        
		public static int CurrentUserId { get { return CurrentUser.BaseUser.Id; } }
		public static string AppName { get { return ""; } }

        private static List<ConnectionConfiguration> _ConnectionConfigurations;
        public static List<ConnectionConfiguration> ConnectionConfigurations
        {
            get
            {
                if (_ConnectionConfigurations == null)
                {
                    if (ConfigSettings != null)
                    {
                        _ConnectionConfigurations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ConnectionConfiguration>>(ConfigSettings["Connections"].ToString());
                    }
                }
                return _ConnectionConfigurations;
            }
        }
        public static ConnectionConfiguration CurrentConnectionConfiguration { get; set; } = ConnectionConfigurations[0];


        public static string LogDataFolder { get { return System.Windows.Forms.Application.UserAppDataPath; } }
		public static string LogDataFileName { get { return LogDataFolder + @"erpconfig.ini"; } }
        public static List<Parameter> BaseSettings { get;set;}
        public static void RetrieveAppSettings()
        {
            try
            {
                BaseSettings = OperationHandler.GetParameters().Value;
                if (BaseSettings == null) return;
                AppSettings.CompanyName = BaseSettings.Where(x => x.ParameterKey == "Company.Name").First().ParameterValue;
                AppSettings.DBVersion = Convert.ToInt32(BaseSettings.Where(x => x.ParameterKey == "DB.Version").First().ParameterValue);
                AppSettings.UnitsDefaultName = BaseSettings.Where(x => x.ParameterKey == "Units.Default.Name").First().ParameterValue;
                AppSettings.UnitsUseDefault = Convert.ToBoolean(BaseSettings.Where(x => x.ParameterKey == "Units.UseDefault").First().ParameterValue);
            }
            catch { }
        }

        public static decimal CalculateItemTotal(byte PriceCalType, decimal ItemPrice, decimal Quantity,decimal Width, decimal Lenght, decimal Height)
        {
            if (PriceCalType == 1) return ItemPrice * Quantity;
            if (PriceCalType == 2)
            {
                return ItemPrice * Quantity * Width * Lenght / 1000000;
            }
            if (PriceCalType == 2)
            {
                return ItemPrice * Quantity * Width * Lenght * Height/1000000000;
            }
            return ItemPrice * Quantity;
        }

        public static User CurrentUser { get; set; }

        public static bool IsPermitted(int PermissionId)
        {
            if (CurrentUser.BaseUser.IsAdmin) return true;
            return CurrentUser.PermissionDetails.Select(x => x.PermissionId).Contains(PermissionId);
        }

        private static readonly string EncryptionKey = "D8903F7F075E4877A6C5F62EC68A2018";
        private static readonly byte[] InitVector = (new char[] { '1', 'c', 'b', '2', 'a', '8', '0', 'f', '4', '3', '9', 'j', '7', '3', '9', 't' }).Select(c => (byte)c).ToArray();

        private static ICryptor _Cryptor = null;

        public static ICryptor Cryptor
        {
            get
            {
                if (_Cryptor == null)
                {
                    _Cryptor = new RijndaelCrypt(EncryptionKey, InitVector);
                   
                }
                return _Cryptor;
            }
        }
    }
}
