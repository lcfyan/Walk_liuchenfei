// Move2 脚本
using Unity.VisualScripting;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    private float moveSpeed; // 移动速度
    private bool canMove = true;

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
        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) && gameObject == playerController.controlledBall)
        {
            canMove = false;
        }

    }

    // 设置移动速度的公共方法
    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed+5f;
        Debug.Log("v3: " + moveSpeed);
    }
    
}
