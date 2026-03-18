using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Vector2 _movement;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //botao 
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    private void FixedUpdate() =>
        //fisica
        _rb.linearVelocity = _movement * speed;
}

