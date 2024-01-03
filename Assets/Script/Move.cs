using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    public PlayerController playerController;  // 引用PlayerController脚本

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (gameObject == playerController.controlledBall)
        {
            // 仅当当前小球是被控制的小球时应用力
            Vector2 movement = new Vector2(horizontalInput, 0f);
            rb.AddForce(movement * moveSpeed);
        }
    }
}
