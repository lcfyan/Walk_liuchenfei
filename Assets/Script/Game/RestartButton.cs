using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        // 通过重新加载当前场景来重新开始游戏
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
