// PlayerController 脚本
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ball1; // 小球1
    public GameObject ball2; // 小球2
    public GameObject controlledBall; // 当前受控制的小球

    void Start()
    {
        controlledBall = ball1; // 初始控制小球1
    }

    public void SwitchControlledBall(Vector2 velocity)
    {
        // 切换受控制的小球
        if (controlledBall == ball1)
        {
            controlledBall = ball2;

            // 设置小球2的速度
            controlledBall.GetComponent<Rigidbody2D>().velocity = velocity;
        }
    }
}
