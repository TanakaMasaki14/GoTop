using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivityX = 0f; // �}�E�X��X�����x
    public float mouseSensitivityY = 0f; // �}�E�X��Y�����x
    public float controllerSensitivityX = 0f; // �R���g���[���[��X�����x
    public float controllerSensitivityY = 0f; // �R���g���[���[��Y�����x

    private float xRotation = 0f;

    private bool isMoving = false; // �v���C���[���ړ������ǂ����𔻒肷��t���O

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // �}�E�X�J�[�\�������b�N���Ĕ�\���ɂ���
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

        // Controller input
        float controllerX = Input.GetAxis("RightStickHorizontal") * controllerSensitivityX * Time.deltaTime;
        float controllerY = Input.GetAxis("RightStickVertical") * controllerSensitivityY * Time.deltaTime;

        xRotation -= mouseY + controllerY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // �㉺�̉�]�p�x�𐧌�����

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // �J�����̉�]��ݒ�

        if (!isMoving)
        {
            transform.parent.Rotate(Vector3.up * (mouseX + controllerX), Space.World); // �v���C���[�L�����N�^�[�̉�]��ݒ�
        }
    }

    public void SetIsMoving(bool moving)
    {
        isMoving = moving;
    }
}
