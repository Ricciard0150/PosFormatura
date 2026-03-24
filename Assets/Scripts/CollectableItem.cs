using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public Transform carId;
    public Transform maoPlayer;
    bool playerPerto = false;
    bool sendoSegurado = false;

    int contador = 0;

    void Update()
    {
        if (playerPerto && Input.GetKeyDown(KeyCode.E) && !sendoSegurado)
        {
            Pegar();
        }

        if (sendoSegurado && Input.GetKeyDown(KeyCode.Q))
        {
            Dropar();
        }
    }
    public void LoadAnotherPart()
    {
        if (contador >= 4)
        {
            Debug.Log("gaga");
        }
    }
    void Pegar()
    {
        Debug.Log("lalala");
        sendoSegurado = true;
        transform.SetParent(maoPlayer);
        transform.localPosition = Vector3.zero;
    }

    void Dropar()
    {
        sendoSegurado = false;
        transform.SetParent(null);
    }
    void OnMoveCar()
    {
        Debug.Log("gaga");
        transform.SetParent(carId);
        transform.position = carId.position;
        contador++;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IStatusPlayer status))
        {
            playerPerto = true;
            
        }
        if(collision.CompareTag("Car"))
        {
            OnMoveCar();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IStatusPlayer status))
        {
            playerPerto = false;
        }
    }
}