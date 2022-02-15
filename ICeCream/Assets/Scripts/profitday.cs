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
        PlayerPrefs.SetInt("ICCount0", info.countIceCream[0]);
        PlayerPrefs.SetInt("ICCount1", info.countIceCream[1]);
        PlayerPrefs.SetInt("ICCount2", info.countIceCream[2]);
        PlayerPrefs.SetInt("ICCount3", info.countIceCream[3]);
        PlayerPrefs.SetInt("ICCount4", info.countIceCream[4]);
        PlayerPrefs.SetInt("ICCount5", info.countIceCream[5]);
        PlayerPrefs.Save();
    }
    public void LoadDay()
    {
        if(PlayerPrefs.HasKey("SavedMoney"))
        {
            info.money = PlayerPrefs.GetInt("SavedMoney");
            info.ratingMarket = PlayerPrefs.GetInt("SavedPrestige");
            dayCount = PlayerPrefs.GetInt("SavedDays");
            info.countIceCream[0] = PlayerPrefs.GetInt("ICCount0");
            info.countIceCream[1] = PlayerPrefs.GetInt("ICCount1");
            info.countIceCream[2] = PlayerPrefs.GetInt("ICCount2");
            info.countIceCream[3] = PlayerPrefs.GetInt("ICCount3");
            info.countIceCream[4] = PlayerPrefs.GetInt("ICCount4");
            info.countIceCream[5] = PlayerPrefs.GetInt("ICCount5");
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
