using UnityEngine;

public class AutoCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("auto")) // 碰撞对象是tag为"auto"的物体
        {
            // 小球消失
            Destroy(gameObject);
        }
    }
}
