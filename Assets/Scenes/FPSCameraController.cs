using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCameraController : MonoBehaviour
{
    public float sensitivity = 2f; // �R���g���[���[�̊��x
    public float minimumVerticalAngle = -90f; // ���������̍ŏ��p�x
    public float maximumVerticalAngle = 90f;  // ���������̍ő�p�x

    private void Update()
    {
        // �v���C���[�̐��������̉�]
        float rotateHorizontal = Input.GetAxis("RightStickHorizontal") * sensitivity;
        transform.Rotate(Vector3.up * rotateHorizontal);

        // �v���C���[�̐��������̉�]
        float rotateVertical = Input.GetAxis("RightStickVertical") * sensitivity;
        rotateVertical = Mathf.Clamp(rotateVertical, -1f, 1f); // ���͂� -1 ���� 1 �͈̔͂ɐ���

        float rotationX = transform.localEulerAngles.x - rotateVertical;
        rotationX = Mathf.Clamp(rotationX, minimumVerticalAngle, maximumVerticalAngle);

        // ���������̉�]��K�p
        transform.localEulerAngles = new Vector3(rotationX, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
