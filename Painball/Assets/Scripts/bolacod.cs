using UnityEngine;

public class bolacod : MonoBehaviour
{
    private Vector2 posicaoInicial;
    private Rigidbody2D rb;
    private bool lancada = false;

    [Header("Lançamento")]
    public KeyCode teclaLancar = KeyCode.Space;
    public float forcaLancamento = 10f;

    [Header("Acelerador")]
    public float multiplicadorVelocidade = 1.05f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posicaoInicial = transform.position;
        ReiniciarBola();
    }

    void Update()
    {
        if (Input.GetKeyDown(teclaLancar) && !lancada)
        {
            Debug.Log("Lançando bola...");
            rb.velocity = new Vector2(forcaLancamento, 0f);
            lancada = true;
        }

        if (transform.position.y < -90f)
        {
            Debug.Log("Bola caiu, reiniciando...");
            ReiniciarBola();
        }
    }

    void ReiniciarBola()
    {
        transform.position = posicaoInicial;
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        lancada = false;
        Debug.Log("Bola reiniciada.");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (lancada)
        {
            rb.velocity *= multiplicadorVelocidade;
            Debug.Log("Colisão - velocidade aumentada.");
        }
    }
}
