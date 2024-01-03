// BallCollider12 脚本
using UnityEngine;

public class BallCollider12 : MonoBehaviour
{
    public PlayerController playerController; // 引用PlayerController脚本

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball2")) // 碰撞对象是小球2
        {
            // 小球1静止
            Rigidbody2D rb1 = GetComponent<Rigidbody2D>();

            // 获取小球1和小球2的质量和速度
            float m1 = rb1.mass;
            float m2 = collision.gameObject.GetComponent<Rigidbody2D>().mass;
            Vector2 v1 = rb1.velocity;
            Vector2 v2 = (m1 * v1) / m2;
            Debug.Log("v1: " + v1);

            // 小球2开始运动，速度由动量守恒计算得出
            Rigidbody2D rb2 = collision.gameObject.GetComponent<Rigidbody2D>();
            rb2.velocity = v2;
            Debug.Log("v2: " + v2);

            // 切换玩家控制的小球，并传递速度信息
            playerController.SwitchControlledBall(v2);

            // 设置 Move2 脚本中的移动速度
            collision.gameObject.GetComponent<Move2>().SetMoveSpeed(v2.x);
        }
    }
}
