package de.myparcelservice.app.AndroidOSAPIAdapters;

import android.content.Context;
import android.content.SharedPreferences;

/**
 * Created by Tilmann Stehle on 30.03.2015.
 */
public class SharedPreferencesAdapter implements de.myparcelservice.app.OSAPIInterfaces.ISharedPreferences {
    private SharedPreferences preferences;

    public SharedPreferencesAdapter(Context context)
    {
        preferences=context.getSharedPreferences(getClass().getName(), Context.MODE_PRIVATE);
    }
    @Override
    public void editValue(String key, String value)
    {
        SharedPreferences.Editor editor = preferences.edit();
        editor.putString(key, value);
        editor.apply();
    }
    @Override
    public void editValue(String key, int value)
    {
        SharedPreferences.Editor editor = preferences.edit();
        editor.putInt(key, value);
        editor.apply();
    }
    @Override
    public void editValue(String key, float value)
    {
        SharedPreferences.Editor editor = preferences.edit();
        editor.putFloat(key, value);
        editor.apply();
    }

    @Override
    public String getString(String key, String defaultValue) {
       return preferences.getString(key,defaultValue);
    }

    @Override
    public float getFloat(String key, Float defaultValue)
    {
        return preferences.getFloat(key, defaultValue);
    }

    @Override
    public int getInt(String key, int defaultValue)
    {
        return preferences.getInt(key, defaultValue);
    }

    @Override
    public boolean getBoolean(String key, boolean defaultValue)
    {
        return preferences.getBoolean(key, defaultValue);
    }

    @Override
    public void editValue(String key, boolean defaultValue)
    {
        SharedPreferences.Editor editor = preferences.edit();
        editor.putBoolean(key, defaultValue);
        editor.apply();
    }

    @Override
    public void remove(String key)
    {
        SharedPreferences.Editor editor = preferences.edit();
        editor.remove(key);
        editor.apply();
    }
}
