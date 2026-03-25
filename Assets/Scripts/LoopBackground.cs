using UnityEngine;

public class LoopBackground : MonoBehaviour
{
    public float altura = 10f;

    void Update()
    {
        transform.Translate(Vector2.down * GameSpeed.velocidadeAtual * Time.deltaTime);

        if (transform.position.y <= -altura)
        {
            transform.position += new Vector3(0, altura * 2, 0);
        }
    }
}
