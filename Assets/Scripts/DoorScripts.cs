using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScripts : MonoBehaviour
{
    bool _isColliding = false;
    private void Update()
    {
        if (CollectableItem.contador == 4 && _isColliding )
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("Game2");

        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IStatusPlayer status))
        {
            _isColliding = true;
        }
    }
}