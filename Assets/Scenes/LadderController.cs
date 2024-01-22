using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderController : MonoBehaviour
{
    public float climbSpeed = 5f; // �͂�����o�鑬�x
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
            float verticalInput = Input.GetAxis("Vertical"); // �㉺�̓��͂��擾

            // ������ւ̈ړ�
            if (verticalInput > 0f)
            {
                // Rigidbody���g���Ĉړ�������ꍇ
                // GetComponent<Rigidbody>().velocity = new Vector3(0f, climbSpeed, 0f);

                // Transform���g���Ĉړ�������ꍇ
                transform.Translate(Vector3.up * climbSpeed * Time.deltaTime);
            }
            // �������ւ̈ړ�
            else if (verticalInput < 0f)
            {
                // Rigidbody���g���Ĉړ�������ꍇ
                // GetComponent<Rigidbody>().velocity = new Vector3(0f, -climbSpeed, 0f);

                // Transform���g���Ĉړ�������ꍇ
                transform.Translate(Vector3.down * climbSpeed * Time.deltaTime);
            }
            // �㉺�̓��͂��Ȃ��ꍇ
            else
            {
                // Rigidbody���g���Ă���ꍇ�͑��x��0�ɂ���
                // GetComponent<Rigidbody>().velocity = Vector3.zero;

                // Transform���g���Ă���ꍇ�͉������Ȃ�
            }
        }
    }
}
