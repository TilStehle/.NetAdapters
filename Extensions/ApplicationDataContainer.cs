using DE.Myparcelservice.App.OSAPIInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace CSharpJavaAdaptation.extensions
{

    static class ApplicationDataContainer
    {

        public static void editValue(this ApplicationDataContainer self, string key, object value)
        {

            self.Values[key] = value;
        }
		
        private static object getValue(this ApplicationDataContainer self, string key, object defaultValue)
        {
            object value;
            if (!self.Values.TryGetValue(key, out value))
            {
                return defaultValue;
            }
            else return value;
        }

        public static void EditValue(this ApplicationDataContainer self, string key, int value)
        {
            self.editValue(key, value);
        }

        public static void EditValue(this ApplicationDataContainer self, string key, float value)
        {
            self.editValue(key, value);
        }

        public static float GetFloat(this ApplicationDataContainer self, string key, float defaultValue)
        {
            return (float)self.getValue(key, defaultValue);
        }

        public static int GetInt(this ApplicationDataContainer self, string key, int defaultValue)
        {
            return (int)self.getValue(key, defaultValue);
        }

        public static bool GetBoolean(this ApplicationDataContainer self, string key, bool defaultValue)
        {
            return (bool)self.getValue(key, defaultValue);
        }

        public static void EditValue(this ApplicationDataContainer self, string key, bool value)
        {
            self.editValue(key, value);
        }


        public static void Remove(this ApplicationDataContainer self, string key)
        {
            self.Values.Remove(key);
        }
    }
}
