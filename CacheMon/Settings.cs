using System;
using System.Configuration;
using System.Windows.Forms;

namespace CacheMon
{
    public static partial class Runtime
    {

        public static class Settings
        {

            public static int FreeMemTriggerLimit {
                get
                {
                    int _parsed;
                    bool _success = int.TryParse(_FreeMemTriggerLimit, out _parsed);
                    if (_success)
                    {
                        if (_parsed > 2147483520) return 2147483520;
                        if (_parsed < 128) return 128;
                        return _parsed;
                    }
                    return 512;

                }

                set
                {
                    if (value > 32768) value = 32768;
                    if (value < 128) value = 128;
                    _FreeMemTriggerLimit = value.ToString();
                }
            }

            public static int StandbyListMinLimit { 
                get
                {
                    int _parsed;
                    bool _success = int.TryParse(_StandbyListMinLimit, out _parsed);
                    if (_success)
                    {
                        if (_parsed > 2147483520) return 2147483520;
                        if (_parsed < 512) return 512;
                        return _parsed;
                    }
                    return 2048;
                } 
                
                set
                {
                    if (value > 2147483520) value = 2147483520;
                    if (value < 512) value = 512;
                    _StandbyListMinLimit = value.ToString();
                } 
            }

            public static int PollInterval {
                get 
                {
                    // min 2000 (2sec), max 3600000 (60mins)
                    int _parsed;
                    bool _success = int.TryParse(_PollInterval, out _parsed);
                    if (_success)
                    {
                        if (_parsed < 2000) return 2000;
                        if (_parsed > (1000 * 60 * 60)) return 3600000;
                        return _parsed;
                    }
                    return 2000;

                }

                set
                {
                    if (value < 2000) value = 2000;
                    if (value > 3600000) value = 3600000;
                    _PollInterval = value.ToString();
                }
            }

            public static bool AggressiveMode { 
                
                get 
                {
                    
                    if (_AggressiveMode == "true")
                    {
                        return true;
                    }
                    return false;

                } 

                set 
                {
                    if (value)
                    {
                        _AggressiveMode = "true";
                    }
                    else
                    {
                        _AggressiveMode = "false";
                    }
                }

            }



            private static string _FreeMemTriggerLimit
            {
                get
                {
                    return GetSetting("FreeMemTriggerLimit");
                }
                set
                {
                    SetSetting("FreeMemTriggerLimit", value);
                }
            }

            private static string _StandbyListMinLimit
            {
                get
                {
                    return GetSetting("StandbyListMinLimit");
                }
                set
                {
                    SetSetting("StandbyListMinLimit", value);
                }
            }

            private static string _PollInterval
            {
                get
                {
                    return GetSetting("PollInterval");
                }
                set
                {
                    SetSetting("PollInterval", value);
                }
            }

            private static string _AggressiveMode
            {
                get
                {
                    return GetSetting("AggressiveMode");
                    
                }
                set
                {
                    SetSetting("AggressiveMode", value);
                }
            }


            private static void SetSetting(string Name, string Value)
            {
                Configuration _appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection _appSettings = _appConfig.AppSettings.Settings;

                if (_appSettings[Name] == null)
                {
                    _appSettings.Add(Name, Value);
                }
                else
                {
                    _appSettings[Name].Value = Value;                    
                }

                _appConfig.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(_appConfig.AppSettings.SectionInformation.Name);

            }

            private static string GetSetting(string Name)
            {                
                return ConfigurationManager.AppSettings.Get(Name);
            }

           


        }
    }
}
