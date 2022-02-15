using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public int money;
    public List<GameObject> objects; // [0] - money; [1] - berryCountText; [2] - chocolateCountText; [3] - creamCountText; [4] - srawberryCounText; [5] - pistachioCountText;
    public List<int> countIceCream; // [0] - berryCount; [1] - chocolateCount; [2] - creamCount; [3] - strawberryCount; [4] - pistachioCount;
    public List<int> priceIC; // [0] - berry; [1] - chocolate; [2] - cream; [3] - strawberry; [4] - pistachio
    public List<GameObject> shopPrice;
    public List<Text> shopCount;
    public GameObject emptyMoney;
    public int ratingMarket;
    public int countClients;
    public List<bool> placeClients;

    private void Update()
    {
        objects[0].GetComponent<Text>().text = money + "$";
        for (int i = 1; i < objects.Count;i++)
        {
            objects[i].GetComponent<Text>().text = "x" + countIceCream[i-1];
        }
        for (int i = 0; i < shopPrice.Count; i++)
        {
            shopPrice[i].GetComponent<Text>().text = priceIC[i] + "$";
            shopCount[i].text = "x" + countIceCream[i];
        }
    }

    public void BuyIC(int IC)
    {
        if (money >= priceIC[IC])
        {
            money -= priceIC[IC];
            countIceCream[IC]++;
        }
        else
        {
            emptyMoney.SetActive(true);
        }
    }
}
