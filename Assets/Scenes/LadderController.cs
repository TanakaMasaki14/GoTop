using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderController : MonoBehaviour
{
    public float climbSpeed = 5f; // はしごを登る速度
    private bool isClimbing = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isClimbing = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isClimbing = false;
        }
    }

    void Update()
    {
        if (isClimbing)
        {
            float verticalInput = Input.GetAxis("Vertical"); // 上下の入力を取得

            // 上方向への移動
            if (verticalInput > 0f)
            {
                // Rigidbodyを使って移動させる場合
                // GetComponent<Rigidbody>().velocity = new Vector3(0f, climbSpeed, 0f);

                // Transformを使って移動させる場合
                transform.Translate(Vector3.up * climbSpeed * Time.deltaTime);
            }
            // 下方向への移動
            else if (verticalInput < 0f)
            {
                // Rigidbodyを使って移動させる場合
                // GetComponent<Rigidbody>().velocity = new Vector3(0f, -climbSpeed, 0f);

                // Transformを使って移動させる場合
                transform.Translate(Vector3.down * climbSpeed * Time.deltaTime);
            }
            // 上下の入力がない場合
            else
            {
                // Rigidbodyを使っている場合は速度を0にする
                // GetComponent<Rigidbody>().velocity = Vector3.zero;

                // Transformを使っている場合は何もしない
            }
        }
    }
}
