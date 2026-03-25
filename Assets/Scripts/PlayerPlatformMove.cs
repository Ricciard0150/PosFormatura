using UnityEngine;

public class PlayerPlatformMove : MonoBehaviour
{
    public float velocidade = 5f;
    public float limiteX = 2.5f;

    void Update()
    {
        float movimento = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * movimento * velocidade * Time.deltaTime);

        // trava o player dentro da tela
        float posX = Mathf.Clamp(transform.position.x, -limiteX, limiteX);
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
