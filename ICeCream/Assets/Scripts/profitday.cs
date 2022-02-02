using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profitday : MonoBehaviour
{
    public Info info;
    public int moneyCount;
    public int prestigeCount;
    public int dayCount;
    public int newDayMoney;
    public int newDayPrestige;
    public List<Text> text; // [0] - money; [1] - prestige; [2] - day;

    public void Start()
    {
        SetNewProfit();
    }

    public void SetNewProfit()
    {
        PlayerPrefs.SetInt("newDayMoney", info.money);
        text[0].text = PlayerPrefs.GetInt("newDayMoney") + "(" + (PlayerPrefs.GetInt("newDayMoney") - moneyCount) + ")";
        moneyCount = PlayerPrefs.GetInt("newDayMoney");
        PlayerPrefs.SetInt("newDayPrestige", info.ratingMarket);
        text[1].text = PlayerPrefs.GetInt("newDayPrestige") + "(" + (PlayerPrefs.GetInt("newDayPrestige") - prestigeCount) + ")";
        prestigeCount = PlayerPrefs.GetInt("newDayPrestige");
        PlayerPrefs.SetInt("Day", dayCount);
        text[2].text = PlayerPrefs.GetInt("Day") + "";
        PlayerPrefs.Save();
    }
}
