using UnityEngine;

public class spawnClients : MonoBehaviour
{
    public GameObject client;
    public GameObject canvas;

    public void SpawnClient()
    {
        GameObject newClient = Instantiate<GameObject>(client, new Vector3(-278,91,0),Quaternion.identity) as GameObject;
        newClient.transform.SetParent(canvas.transform, false);
        newClient.SetActive(true);
    }
}
