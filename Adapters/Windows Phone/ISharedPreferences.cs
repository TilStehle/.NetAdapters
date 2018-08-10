
namespace DE.Myparcelservice.App.OSAPIInterfaces
{
	/// <summary>Created by Tilmann Stehle on 02.04.2015.</summary>
	public interface ISharedPreferences
	{
		void EditValue(string key, string value);

		void EditValue(string key, int value);

		void EditValue(string key, float value);

		string GetString(string key, string defaultValue);

		float GetFloat(string key, float defaultValue);

		int GetInt(string key, int defaultValue);

		bool GetBoolean(string key, bool defaultValue);

		void EditValue(string hasBoxesKey, bool hasBoxes);

		void Remove(string key);
	}
}
