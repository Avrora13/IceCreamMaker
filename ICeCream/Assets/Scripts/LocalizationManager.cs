using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    public string currentLanguage;
    public int intLanguage;
    
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Language"))
        {
            if (Application.systemLanguage == SystemLanguage.Russian || Application.systemLanguage == SystemLanguage.Ukrainian || Application.systemLanguage == SystemLanguage.Belarusian)
            {
                PlayerPrefs.SetString("Language", "ru_RU");
                intLanguage = 0;
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                PlayerPrefs.SetString("Language", "de_DE");
                intLanguage = 1;
            }
            else
            {
                PlayerPrefs.SetString("Language", "en_US");
                intLanguage = 2;
            }
        }
        currentLanguage = PlayerPrefs.GetString("Language");
    }

    public string CurrentLanguage
    {
        get
        {
            return currentLanguage;
        }
        set
        {
            PlayerPrefs.SetString("Language", value);
            currentLanguage = PlayerPrefs.GetString("Language");
        }
    }
}
