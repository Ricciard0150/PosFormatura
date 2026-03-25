using UnityEngine;

public class WinCondtiion : MonoBehaviour
{

    public GameObject telaVitoria;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish1"))
        {
            Time.timeScale = 0f;
            telaVitoria.SetActive(true);
        }
    }
}

