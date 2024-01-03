// Move2 脚本
using UnityEngine;

public class Move2 : MonoBehaviour
{
    private float moveSpeed; // 移动速度

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
            // 施加力
            Vector2 movement = new Vector2(horizontalInput, 0f);
            rb.AddForce(movement * moveSpeed);
        }
    }

    // 设置移动速度的公共方法
    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed+5f;
        Debug.Log("v3: " + moveSpeed);
    }
    
}
