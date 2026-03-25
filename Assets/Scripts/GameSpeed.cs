using UnityEngine;

public class GameSpeed : MonoBehaviour
{
    public static float velocidadeAtual = 3f;
    public float aumentoPorSegundo = 0.2f;

    void Update()
    {
        velocidadeAtual += aumentoPorSegundo * Time.deltaTime;
    }
}
