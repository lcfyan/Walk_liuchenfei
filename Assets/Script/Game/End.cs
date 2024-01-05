using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // 检测是否碰撞到了带有 "Ball5" 标签的物体
        if (other.CompareTag("Ball5"))
        {
            // 游戏结束，退出应用
            Debug.Log("Game Over!");
            Application.Quit();
        }
    }
}
