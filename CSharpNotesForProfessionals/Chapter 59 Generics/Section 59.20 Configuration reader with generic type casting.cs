
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_59_Generics_Section_59_20
{
    /// <summary>
    /// Read configuration values from app.config and convert
    /// specified types
    /// </summary>
    public static class ConfigurationReader
    {

        /// <summary>
        /// Get value from AppString by key, convert to type of default value typeparam T and return
        /// </summary>
        /// <typeparam name="T">typeparm is the type in which value will be returned, it could be
        /// any type eg. int, string, bool, decimal etc.</typeparam>
        /// <param name="strkey">key to find value from AppStrings</param>
        /// <param name="defaultValue">defaultValue will be returned in case of value is only or any exception occures</param>
        /// <returns>AppSetting value against key is returned in type of default value or given as typeparam T</returns>

        public static T GetConfigKeyValue<T>(string strkey, T defaultValue)
        {
            var result = defaultValue;
            try
            {
                if (ConfigurationManager.AppSettings[strkey] != null)
                {
                    result = (T)Convert.ChangeType(ConfigurationManager.AppSettings[strkey] ?? "",
                        typeof(T));
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());
            }

            return result;
        }

        public static T GetConfigKeyValue<T>(string strkey)
        {
            return GetConfigKeyValue(strkey, default(T));
        }
    }
}
