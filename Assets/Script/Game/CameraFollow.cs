using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerController playerController;  // 引用PlayerController脚本

    public float smoothSpeed = 0.125f;  // 跟随平滑度

    private void LateUpdate()
    {
        if (playerController != null && playerController.controlledBall != null)
        {
            // 获取 controlledBall 的 Transform 组件
            Transform controlledBallTransform = playerController.controlledBall.transform;

            // 计算新的摄像机位置
            Vector3 desiredPosition = new Vector3(controlledBallTransform.position.x, controlledBallTransform.position.y, transform.position.z);

            // 使用 SmoothDamp 函数平滑地移动摄像机
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        }
    }
}
