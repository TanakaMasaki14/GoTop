using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 0f; // 移動速度
    public float rotationSpeed = 2f; // 視点回転速度
    public float jumpForce = 0f; // ジャンプ力
    public float damageAmount = 0f; // 衝突時のダメージ量

    public AudioSource jumpSound; // ジャンプ時のサウンド

    private Rigidbody rb;
    private bool isJumping = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpSound = GetComponent<AudioSource>(); // AudioSourceを取得
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement = transform.TransformDirection(movement);
        movement *= movementSpeed;

        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        // プレイヤーの水平方向の回転
        float rotateHorizontal = Input.GetAxis("RightStickHorizontal") * rotationSpeed;
        transform.Rotate(Vector3.up * rotateHorizontal);

        // カメラの垂直方向の回転
        float rotateVertical = Input.GetAxis("RightStickVertical") * rotationSpeed;
        Camera mainCamera = Camera.main;
        mainCamera.transform.Rotate(Vector3.left * rotateVertical);

        // ジャンプボタンを押したらジャンプ
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;

            // ジャンプサウンドを再生
            if (jumpSound != null)
            {
                jumpSound.Play();
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        // BreakableBoardコンポーネントがアタッチされている場合、ダメージを適用
        BreakableBoard board = collision.gameObject.GetComponent<BreakableBoard>();
        if (board != null)
        {
            board.ApplyDamage(damageAmount);
        }
    }
}
