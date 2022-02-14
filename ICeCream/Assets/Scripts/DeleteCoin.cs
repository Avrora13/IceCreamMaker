using UnityEngine;

public class DeleteCoin : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
