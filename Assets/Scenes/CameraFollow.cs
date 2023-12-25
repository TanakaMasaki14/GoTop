using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // 追いかける対象（プレイヤーキャラクター）のTransformコンポーネント
    public Vector3 offset;    // カメラとプレイヤーの距離オフセット

    private void LateUpdate()
    {
        if (target != null)
        {
            // プレイヤーの位置にオフセットを加えてカメラのターゲット位置を計算
            Vector3 targetPosition = target.position + offset;

            // カメラの位置を徐々にターゲット位置に移動させる（スムーズな移動を実現）
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);
        }
    }
}