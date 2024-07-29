using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageManager : MonoBehaviour
{
    private string playerPrefsKey = "locale";
    private Locale activeLocale = LocalizationSettings.Instance.GetSelectedLocale();

    private int currentLocale = 0;
    void Start()
    {
        // Mostrar la localización activa al inicio
        Debug.Log("Localización activa al inicio: " + activeLocale.Identifier);

        // Cambiar la localización a español después de 5 segundos
        // Invoke("ChangeLocale", 5f);
    }
    public void ChangeLocale()
    {
        LocalizationSettings settings = LocalizationSettings.Instance;
        List<Locale> availableLocales = settings.GetAvailableLocales().Locales;

        if (!PlayerPrefs.HasKey(playerPrefsKey))
        {
            PlayerPrefs.SetString(playerPrefsKey, activeLocale.Identifier.Code);
        }

        if (PlayerPrefs.HasKey(playerPrefsKey))
        {
            string localeCode = PlayerPrefs.GetString(playerPrefsKey);
            Locale savedLocale = availableLocales.Find(l => l.Identifier.Code == localeCode);

            if (savedLocale != null)
            {
                LocalizationSettings.SelectedLocale = savedLocale;
            }
        }
    }

    public void ChangeLocale(string localeCode)
    {
        LocalizationSettings settings = LocalizationSettings.Instance;
        List<Locale> availableLocales = settings.GetAvailableLocales().Locales;

        if (!PlayerPrefs.HasKey(playerPrefsKey))
        {
            PlayerPrefs.SetString(playerPrefsKey, activeLocale.Identifier.Code);
        }

        if (PlayerPrefs.HasKey(playerPrefsKey))
        {
            Locale savedLocale = availableLocales.Find(l => l.Identifier.Code == localeCode);

            if (savedLocale != null)
            {
                LocalizationSettings.SelectedLocale = savedLocale;
            }
        }
    }
}
