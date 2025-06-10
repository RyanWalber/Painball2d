using UnityEngine;

public class FimDeJogo : MonoBehaviour
{
    public string tagDaBola = "Bola";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tagDaBola))
        {
            ReiniciarBola(collision.gameObject);
        }
    }

    void ReiniciarBola(GameObject bola)
    {
        Rigidbody2D rb = bola.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            bola.transform.position = new Vector2(5.89f, 63f);
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
        }
    }
}
