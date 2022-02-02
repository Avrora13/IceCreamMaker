using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createIceCream : MonoBehaviour
{
    public List<Sprite> iceCreamSprites;
    public List<GameObject> iceCreamObjects;
    private int iceCreamInt = 0;
    public Info info;
    public GameObject emptyPanel;
    public List<int> IC;
    private int selectedFirstIC;
    private int selectedSecondIC;
    private int selectedThirdIC;
    public int countTrueIC;

    public void SelectIceCream(int iceCream)
    {
        if (iceCreamInt != 3)
        {
            if (info.countIceCream[iceCream] > 0)
            {
                iceCreamObjects[iceCreamInt].SetActive(true);
                iceCreamObjects[iceCreamInt].GetComponent<Image>().sprite = iceCreamSprites[iceCream];
                switch (iceCreamInt)
                {
                    case 0:
                        selectedFirstIC = iceCream;
                        break;
                    case 1:
                        selectedSecondIC = iceCream;
                        break;
                    case 2:
                        selectedThirdIC = iceCream;
                        break;
                }
                iceCreamInt++;
                info.countIceCream[iceCream] -= 1;
            }
            else
            {
                emptyPanel.SetActive(true);
            }
        }
    }

    public void closeOrder()
    {
        for (int i = 0;i < IC.Count;i++)
        {
            if (IC[i] == selectedFirstIC)
            {
                countTrueIC += 1;
                IC[i] = -1;
                selectedFirstIC = -2;
            }
            else if (IC[i] == selectedSecondIC)
            {
                countTrueIC += 1;
                IC[i] = -1;
                selectedSecondIC = -2;
            }
            else if (IC[i] == selectedThirdIC)
            {
                countTrueIC += 1;
                IC[i] = -1;
                selectedThirdIC = -2;
            }
        }
        switch (countTrueIC)
        {
            case 0:
                info.ratingMarket -= 25;
                break;
            case 1:
                info.ratingMarket -= Random.Range(-10,-5);
                info.money += 8;
                break;
            case 2:
                info.ratingMarket += Random.Range(0,5);
                info.money += Random.Range(10, 20);
                break;
            case 3:
                info.ratingMarket += Random.Range(5, 25);
                info.money += Random.Range(15, 35);
                break;
        }
        iceCreamInt = 0;
        for (int i = 0; i < iceCreamObjects.Count; i++)
        {
            iceCreamObjects[i].SetActive(false);
        }
    }

    public void clearIC()
    {
        iceCreamInt = 0;
        for(int i = 0;i < iceCreamObjects.Count;i++)
        {
            iceCreamObjects[i].SetActive(false);
        }
    }
}
