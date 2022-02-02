using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orders : MonoBehaviour
{
    public List<string> berryICText;
    public List<string> chocolateICText;
    public List<string> creamICText;
    public List<string> strawberryICText;
    public List<string> pistachioICText;
    public List<string> kiwiICText;
    public List<Text> Texts; // [0] - count; [1] - firstTextIc; [2] - secondTextIC; [3] - thirdTextIC;
    public int firstIC;
    public int secondIC;
    public int thirdIC;
    public createIceCream createIceCream;
    public LocalizationManager manager;

    public void buyIC()
    {
        secondIC = -1;
        thirdIC = -1;
        for (int i = 1; i < Texts.Count; i++)
        {
            Texts[i].text = " ";
        }
        int count = Random.Range(1, 4);
        switch (manager.intLanguage)
        {
            case 0:
                Texts[0].text = count + Texts[0].GetComponent<LocalizationText>().ru_RU;
                break;
            case 1:
                Texts[0].text = count + Texts[0].GetComponent<LocalizationText>().en_US;
                break;
            case 2:
                Texts[0].text = count + Texts[0].GetComponent<LocalizationText>().de_DE;
                break;
        }
        switch (count)
        {
            case 1:
                firstIC = Random.Range(0, 6);
                break;
            case 2:
                firstIC = Random.Range(0, 6);
                secondIC = Random.Range(0, 6);
                break;
            case 3:
                firstIC = Random.Range(0, 6);
                secondIC = Random.Range(0, 6);
                thirdIC = Random.Range(0, 6);
                break;
        }
        switch (firstIC)
        {
            case 0:
                Texts[1].text = berryICText[manager.intLanguage];
                break;
            case 1:
                Texts[1].text = chocolateICText[manager.intLanguage];
                break;
            case 2:
                Texts[1].text = creamICText[manager.intLanguage];
                break;
            case 3:
                Texts[1].text = strawberryICText[manager.intLanguage];
                break;
            case 4:
                Texts[1].text = pistachioICText[manager.intLanguage];
                break;
            case 5:
                Texts[1].text = kiwiICText[manager.intLanguage];
                break;
        }
        if (secondIC != -1)
        {
            switch (secondIC)
            {
                case 0:
                    Texts[2].text = berryICText[manager.intLanguage];
                    break;
                case 1:
                    Texts[2].text = chocolateICText[manager.intLanguage];
                    break;
                case 2:
                    Texts[2].text = creamICText[manager.intLanguage];
                    break;
                case 3:
                    Texts[2].text = strawberryICText[manager.intLanguage];
                    break;
                case 4:
                    Texts[2].text = pistachioICText[manager.intLanguage];
                    break;
                case 5:
                    Texts[2].text = kiwiICText[manager.intLanguage];
                    break;
            }
        }
        if (thirdIC != -1)
        {
            switch (thirdIC)
            {
                case 0:
                    Texts[3].text = berryICText[manager.intLanguage];
                    break;
                case 1:
                    Texts[3].text = chocolateICText[manager.intLanguage];
                    break;
                case 2:
                    Texts[3].text = creamICText[manager.intLanguage];
                    break;
                case 3:
                    Texts[3].text = strawberryICText[manager.intLanguage];
                    break;
                case 4:
                    Texts[3].text = pistachioICText[manager.intLanguage];
                    break;
                case 5:
                    Texts[3].text = kiwiICText[manager.intLanguage];
                    break;
            }
        }
    }

    public void setOrder()
    {
        createIceCream.countTrueIC = 0;
        createIceCream.IC[0] = firstIC;
        createIceCream.IC[1]= secondIC;
        createIceCream.IC[2] = thirdIC;
    }
}
