using UnityEngine;

public class Animmm
    : MonoBehaviour
{
    public Sprite[] walkDown;
    public Sprite[] walkUp;
    public Sprite[] walkLeft;
    public Sprite[] walkRight;

    public Sprite idleDown;
    public Sprite idleUp;
    public Sprite idleLeft;
    public Sprite idleRight;

    public float animationSpeed = 10f;

    private SpriteRenderer sr;
    private float timer;
    private int frame;
    private string lastDirection = "down";

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Sprite[] currentAnim = null;

        if (y < 0)
        {
            currentAnim = walkDown;
            lastDirection = "down";
        }
        else if (y > 0)
        {
            currentAnim = walkUp;
            lastDirection = "up";
        }
        else if (x < 0)
        {
            currentAnim = walkLeft;
            lastDirection = "left";
        }
        else if (x > 0)
        {
            currentAnim = walkRight;
            lastDirection = "right";
        }

        // ANDANDO
        if (currentAnim != null && currentAnim.Length > 0)
        {
            timer += Time.deltaTime;

            if (timer >= 1f / animationSpeed)
            {
                timer = 0f;
                frame++;

                if (frame >= currentAnim.Length)
                    frame = 0;

                sr.sprite = currentAnim[frame];
            }
        }
        // IDLE
        else
        {
            frame = 0;

            switch (lastDirection)
            {
                case "down":
                    sr.sprite = idleDown;
                    break;

                case "up":
                    sr.sprite = idleUp;
                    break;

                case "left":
                    sr.sprite = idleLeft;
                    break;

                case "right":
                    sr.sprite = idleRight;
                    break;
            }
        }
    }
}