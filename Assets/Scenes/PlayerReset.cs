using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerReset : MonoBehaviour
{
    public Transform resetPosition; // �v���C���[�����Z�b�g����ʒu

    private Vector3 initialPosition; // �ŏ��̈ʒu

    private void Start()
    {
        // �ŏ��̈ʒu��ۑ�
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("Title");
        }
    }

    public void ResetPosition()
    {
        if (resetPosition != null)
        {
            // ���Z�b�g�ʒu�Ƀv���C���[�̈ʒu���ړ�
            transform.position = resetPosition.position;
        }
        else
        {
            transform.position = initialPosition;
        }
    }
}
