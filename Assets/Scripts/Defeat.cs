using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject telaDerrota;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Time.timeScale = 0f; // pausa o jogo
            telaDerrota.SetActive(true); // mostra tela
        }
    }
}