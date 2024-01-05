using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float moveSpeed = 2f; // 移动速度
    public float moveRange = 5f; // 移动范围

    private float initialPositionY; // 初始位置Y
    private bool movingUp = true; // 是否向上移动

    void Start()
    {
        initialPositionY = transform.position.y; // 记录初始位置Y
    }

    void FixedUpdate()
    {
        // 使用Translate方法进行移动
        if (movingUp)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * moveSpeed * Time.fixedDeltaTime);
        }

        // 检查是否达到移动范围的边界，改变移动方向
        if (Mathf.Abs(transform.position.y - initialPositionY) >= moveRange)
        {
            movingUp = !movingUp;
        }
    }
}
