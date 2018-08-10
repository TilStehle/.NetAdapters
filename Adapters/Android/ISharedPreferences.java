package de.myparcelservice.app.OSAPIInterfaces;

/**
 * Created by Tilmann Stehle on 02.04.2015.
 */
public interface ISharedPreferences {
    void editValue(String key, String value);

    void editValue(String key, int value);

    void editValue(String key, float value);

    String getString(String key, String defaultValue);

    float getFloat(String key, Float defaultValue);
    int getInt(String key, int defaultValue);

    boolean getBoolean(String key, boolean defaultValue);

    void editValue(String hasBoxesKey, boolean hasBoxes);

    void remove(String key);
}
