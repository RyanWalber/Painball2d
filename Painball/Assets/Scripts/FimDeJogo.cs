using UnityEngine;

public class FimDeJogo : MonoBehaviour
{
    public string tagDaBola = "Bola";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tagDaBola))
        {
            EncerrarJogo();
        }
    }

    void EncerrarJogo()
    {
        Debug.Log("Fim de jogo!");

#if UNITY_EDITOR
        // Para parar o jogo no Editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Para fechar o jogo no build
        Application.Quit();
#endif
    }
}
