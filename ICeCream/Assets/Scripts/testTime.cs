using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testTime : MonoBehaviour
{
    public Text text;
    public int hours = 8;
    public GameObject client;
    public GameObject canvas;
    public Info info;
    public List<GameObject> Clients;
    public List<Sprite> clientsSprites;
    public Text second;
    public Text minutes;
    public Text hour;
    public float param;
    public float second1;
    public float minuta1;
    public int day = 0;
    public Text daytext;
    public int procentSpawn;
    public GameObject panelND;
    public float hours1 = 8;
    public GameObject time;
    public GameObject coin;
    void Update()
    {
        param -= 2f * Time.deltaTime;
        if (param <= 0)
        {
            param = 1;
            minuta1 = minuta1 + 1;
            if (Random.Range(0, 101) <= 5)
            {
                for (int i = 0; i < Random.Range(1, 3); i++)
                {
                    SpawnClients();
                }
            }
        }

        if (minuta1 >= 60)
        {
            hours1 = hours1 + 1;
            minuta1 = 0;
            if (Random.Range(0, 101) <= 60)
            {
                GameObject newCoin = Instantiate<GameObject>(coin, new Vector3(Random.Range(-490, 490), 1010, 0), Quaternion.identity) as GameObject;
                newCoin.transform.SetParent(canvas.transform, false);
                newCoin.SetActive(true);
            }
        }

        if (hours1 == 16)
        {
            for (int i = 0;i < Clients.Count; i++)
            {
                Clients[i] = null;
            }
            time.SetActive(false);
            panelND.SetActive(true);
            panelND.GetComponent<profitday>().SetNewProfit();
            panelND.GetComponent<profitday>().dayCount += 1;
        }
        if (minuta1 < 10)
        {
            minutes.text = "0" + minuta1 + "  :";
        }
        else
        {
            minutes.text = "" + minuta1 + "  :";
        }
        hour.text = "" + hours1 + "  :";
    }

    private void Start()
    {
        SpawnClients();
    }

    public void SetNewDay()
    {
        day += 1;
        daytext.text = day + "";
        hours1 = 8;
        minuta1 = 0;
        panelND.SetActive(false);
        time.SetActive(true);
        for (int i = 0; i < info.priceIC.Count; i++)
        {
            info.priceIC[i] = Random.Range((info.priceIC[i] - 10), (info.priceIC[i] + 10));
        }
    }

    public void SpawnClients()
    {
        if (Clients[0] == null)
        {
            GameObject newClient = Instantiate<GameObject>(client, new Vector3(-308, -389, 0), Quaternion.identity) as GameObject;
            newClient.transform.SetParent(canvas.transform, false);
            newClient.GetComponent<Image>().sprite = clientsSprites[Random.Range(0, clientsSprites.Count)];
            newClient.SetActive(true);
            Clients[0] = newClient;
        }
        else if (Clients[1] == null)
        {
            GameObject newClient = Instantiate<GameObject>(client, new Vector3(-161, -389, 0), Quaternion.identity) as GameObject;
            newClient.transform.SetParent(canvas.transform, false);
            newClient.GetComponent<Image>().sprite = clientsSprites[Random.Range(0, clientsSprites.Count)];
            newClient.SetActive(true);
            Clients[1] = newClient;
        }
        else if (Clients[2] == null)
        {
            GameObject newClient = Instantiate<GameObject>(client, new Vector3(-15, -389, 0), Quaternion.identity) as GameObject;
            newClient.transform.SetParent(canvas.transform, false);
            newClient.GetComponent<Image>().sprite = clientsSprites[Random.Range(0, clientsSprites.Count)];
            newClient.SetActive(true);
            Clients[2] = newClient;
        }
        else if (Clients[3] == null)
        {
            GameObject newClient = Instantiate<GameObject>(client, new Vector3(132, -389, 0), Quaternion.identity) as GameObject;
            newClient.transform.SetParent(canvas.transform, false);
            newClient.GetComponent<Image>().sprite = clientsSprites[Random.Range(0, clientsSprites.Count)];
            newClient.SetActive(true);
            Clients[3] = newClient;
        }
        else if (Clients[4] == null)
        {
            GameObject newClient = Instantiate<GameObject>(client, new Vector3(279, -389, 0), Quaternion.identity) as GameObject;
            newClient.transform.SetParent(canvas.transform, false);
            newClient.GetComponent<Image>().sprite = clientsSprites[Random.Range(0, clientsSprites.Count)];
            newClient.SetActive(true);
            Clients[4] = newClient;
        }
        else { }
    }
}
