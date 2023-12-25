using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 0f; // 移動速度
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
        BreakableBoard board = collision.gameObject.GetComponent<BreakableBoard>();
        if (board != null)
        {
            board.ApplyDamage(damageAmount);
        }
    }
}