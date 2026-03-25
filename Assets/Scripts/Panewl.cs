using UnityEngine;

public class Panewl : MonoBehaviour
{
    public GameObject panel;
    public KeyCode teclaInteragir = KeyCode.E;
    public KeyCode teclaFechar = KeyCode.Q;

    private bool playerPerto = false;

    void Update()
    {
        // Abrir com E
        if (playerPerto && Input.GetKeyDown(teclaInteragir))
        {
            panel.SetActive(true);
        }

        // Fechar com Q
        if (playerPerto && Input.GetKeyDown(teclaFechar))
        {
            panel.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerPerto = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerPerto = false;
            panel.SetActive(false); // fecha ao sair
        }
    }
}