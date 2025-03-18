using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("NPC"))
        {
            Destroy(collision.gameObject);
        }
    }
}
