using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.down * GameSpeed.velocidadeAtual * Time.deltaTime);

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
