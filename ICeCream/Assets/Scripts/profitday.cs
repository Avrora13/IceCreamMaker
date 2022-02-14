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
        LoadDay();
    }

    public void SaveDay()
    {
        PlayerPrefs.SetInt("SavedMoney", info.money);
        PlayerPrefs.SetInt("SavedPrestige", info.ratingMarket);
        PlayerPrefs.SetInt("SavedDays", dayCount);
        PlayerPrefs.Save();
    }
    public void LoadDay()
    {
        if(PlayerPrefs.HasKey("SavedMoney"))
        {
            info.money = PlayerPrefs.GetInt("SavedMoney");
            info.ratingMarket = PlayerPrefs.GetInt("SavedPrestige");
            dayCount = PlayerPrefs.GetInt("SavedDays");
        }
        ShowStats();
    }
    public void ShowStats()
    {
        text[0].text = info.money + "";
        text[1].text = info.ratingMarket + "";
        text[2].text = dayCount + "";
    }
}
