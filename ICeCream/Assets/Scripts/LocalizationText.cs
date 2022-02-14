using UnityEngine;
using UnityEngine.UI;

public class LocalizationText : MonoBehaviour
{
    public string ru_RU;
    public string en_US;
    public string de_DE;
    public LocalizationManager manager;
    public void Start()
    {
        if (manager.currentLanguage == "ru_RU")
        {
            this.GetComponent<Text>().text = ru_RU;
        }
        else if (manager.currentLanguage == "de_DE")
        {
            this.GetComponent<Text>().text = de_DE;
        }
        else
        {
            this.GetComponent<Text>().text = en_US;
        }
    }
}
