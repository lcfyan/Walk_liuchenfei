using UnityEngine;

public class WallController : MonoBehaviour
{
    public PlayerController playerController;  // 引用PlayerController脚本

    private Collider2D wallCollider;

    void Start()
    {
        // 获取墙上的Collider2D组件
        wallCollider = GetComponent<Collider2D>();

        // 初始化为非触发器状态（碰撞器激活）
        wallCollider.isTrigger = false;

        // 获取PlayerController脚本
        playerController = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (playerController != null && playerController.controlledBall != null)
        {
            // 获取controlledBall的速度
            float ballVelocity = playerController.controlledBall.GetComponent<Rigidbody2D>().velocity.x;

            // 根据controlledBall速度决定是否将墙的Collider2D设为触发器
            if (ballVelocity < 0)
            {
                // controlledBall从右到左运动，关闭墙的Collider2D（非触发器状态）
                wallCollider.isTrigger = false;
            }
            else
            {
                // controlledBall从左到右运动，打开墙的Collider2D（触发器状态）
                wallCollider.isTrigger = true;
            }
        }
    }
}
