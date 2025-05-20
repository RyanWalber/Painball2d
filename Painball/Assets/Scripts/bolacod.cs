using UnityEngine;

public class bolacod : MonoBehaviour
{
    private Vector2 posicaoInicial;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posicaoInicial = transform.position;
    }

    void Update()
    {
        // Reinicia a bola se ela cair abaixo da mesa
        if (transform.position.y < -90f)
        {
            ReiniciarBola();
        }
    }

    void ReiniciarBola()
    {
        transform.position = posicaoInicial;
        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;
    }
}
