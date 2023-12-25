using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public Transform startPoint;    // 移動の始点
    public Transform endPoint;      // 移動の終点
    public float moveSpeed = 2f;    // 移動速度

    private Vector3 targetPosition; // 現在の移動先の位置

    private void Start()
    {
        targetPosition = endPoint.position;
    }

    private void Update()
    {
        // 現在の位置から目標位置に向かって移動
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // 目標位置に到達したら、目標位置を切り替える
        if (transform.position == targetPosition)
        {
            if (targetPosition == endPoint.position)
                targetPosition = startPoint.position;
            else
                targetPosition = endPoint.position;
        }
    }
}
