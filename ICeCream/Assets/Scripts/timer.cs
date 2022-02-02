using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text text;
    public GameObject client;

    public void SetTime(int time)
    {
        text.text = time + "";
        if (time == 40)
        {
            Destroy(client);
        }
    }

    public void destroyClient()
    {
        Destroy(client);
    }
}
