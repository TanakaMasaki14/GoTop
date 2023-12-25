using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 0f; // �ړ����x
    public float jumpForce = 0f; // �W�����v��
    public float damageAmount = 0f; // �Փˎ��̃_���[�W��

    public AudioSource jumpSound; // �W�����v���̃T�E���h

    private Rigidbody rb;
    private bool isJumping = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpSound = GetComponent<AudioSource>(); // AudioSource���擾
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

            // �W�����v�T�E���h���Đ�
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