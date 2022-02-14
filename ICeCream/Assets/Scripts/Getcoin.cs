using UnityEngine;

public class Getcoin : MonoBehaviour
{
    public Info info;
    public void GetCoin()
    {
        info.money += Random.Range(15, 35);
        Destroy(gameObject);
    }
}
