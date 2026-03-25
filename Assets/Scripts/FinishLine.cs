using UnityEngine;

public class FinishMove : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.down * GameSpeed.velocidadeAtual * Time.deltaTime);
    }
}
