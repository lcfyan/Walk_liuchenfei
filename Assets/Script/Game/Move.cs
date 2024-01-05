using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    public PlayerController playerController;  // 引用PlayerController脚本
    private bool canMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (gameObject == playerController.controlledBall && canMove)
        {
            // 仅当当前小球是被控制的小球且可以移动时应用力
            Vector2 movement = new Vector2(horizontalInput, 0f);
            rb.AddForce(movement * moveSpeed);
        }

        // 检测 "AD" 键是否被松开，如果是，禁止小球再次移动
        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) && gameObject == playerController.controlledBall)

        {
            canMove = false;
        }
    }
}
