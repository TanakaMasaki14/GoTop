using UnityEngine;

public class Platformer : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度
    private Vector3 originalPosition; // 初期位置
    private bool isPlayerOnPlatform = false; // プレイヤーがプラットフォーム上にいるかどうか

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (isPlayerOnPlatform)
        {
            // プレイヤーがプラットフォーム上にいる場合、移動処理を実行
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        else
        {
            // プレイヤーがプラットフォーム上にいない場合、元の位置に戻る
            transform.position = originalPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // プレイヤーがプラットフォームに乗った場合
            isPlayerOnPlatform = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // プレイヤーがプラットフォームから降りた場合
            isPlayerOnPlatform = false;
        }
    }
}
