using UnityEngine;

public class bolacod : MonoBehaviour
{
    private Vector2 posicaoInicial;
    private Rigidbody2D rb;
    private bool lancada = false;

    [Header("Lan�amento")]
    public KeyCode teclaLancar = KeyCode.Space;
    public float forcaLancamento = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posicaoInicial = transform.position;
    }

    void Update()
    {
        // Lan�amento ao pressionar tecla
        if (Input.GetKeyDown(teclaLancar) && !lancada)
        {
            rb.linearVelocity = new Vector2(forcaLancamento, 0f); // Lan�a na horizontal
            lancada = true;
        }

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
        lancada = false;
    }
}
