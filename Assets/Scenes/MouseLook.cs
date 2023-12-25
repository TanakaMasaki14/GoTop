using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 0f; // �}�E�X�̊��x

    private float xRotation = 0f;

    private bool isMoving = false; // �v���C���[���ړ������ǂ����𔻒肷��t���O

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // �}�E�X�J�[�\�������b�N���Ĕ�\���ɂ���
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // �㉺�̉�]�p�x�𐧌�����

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // �J�����̉�]��ݒ�

        if (!isMoving)
        {
            transform.parent.Rotate(Vector3.up * mouseX, Space.World); // �v���C���[�L�����N�^�[�̉�]��ݒ�
        }
    }

    public void SetIsMoving(bool moving)
    {
        isMoving = moving;
    }
}
