using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    public float scaleSpeed = 0.5f; // スケールが変化する速度
    public float maxScale = 2f;     // 最大スケール
    public float minScale = 0.5f;   // 最小スケール

    private bool scalingUp = true;  // スケールが拡大中かどうかのフラグ

    void Update()
    {
        // スケールを変化させる
        if (scalingUp)
        {
            transform.localScale += new Vector3(scaleSpeed * Time.deltaTime, 0f, 0f);

            // 最大スケールを超えたらスケールダウンに切り替え
            if (transform.localScale.x >= maxScale)
            {
                scalingUp = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(scaleSpeed * Time.deltaTime, 0f, 0f);

            // 最小スケールを下回ったらスケールアップに切り替え
            if (transform.localScale.x <= minScale)
            {
                scalingUp = true;
            }
        }
    }
}
