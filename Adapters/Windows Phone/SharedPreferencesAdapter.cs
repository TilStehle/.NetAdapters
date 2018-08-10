using DE.Myparcelservice.App.OSAPIInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ParcelservicePricing.OSAPIAdapters
{

    public class SharedPreferencesAdapter : ISharedPreferences
    {
        ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

// Create a simple setting

        public void editValue(string key, object value)
        {

            localSettings.Values[key] = value;
        }
        public void EditValue(string key, string value)
        {

            editValue(key, value);
        }

        public string GetString(string key, string defaultValue)
        {
            return (string)getValue(key, defaultValue);
        }

        private object getValue(string key, object defaultValue)
        {
            object value;
            if (!localSettings.Values.TryGetValue(key, out value))
            {
                return defaultValue;
            }
            else return value;
        }

        public void EditValue(string key, int value)
        {
            editValue(key, value);
        }

        public void EditValue(string key, float value)
        {
            editValue(key, value);
        }

        public float GetFloat(string key, float defaultValue)
        {
            return (float)getValue(key, defaultValue);
        }

        public int GetInt(string key, int defaultValue)
        {
            return (int)getValue(key, defaultValue);
        }

        public bool GetBoolean(string key, bool defaultValue)
        {
            return (bool)getValue(key, defaultValue);
        }

        public void EditValue(string key, bool value)
        {
            editValue(key, value);
        }


        public void Remove(string key)
        {
            localSettings.Values.Remove(key);
        }
    }
}
