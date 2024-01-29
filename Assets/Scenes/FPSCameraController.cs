using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCameraController : MonoBehaviour
{
    public float sensitivity = 2f; // コントローラーの感度
    public float minimumVerticalAngle = -90f; // 垂直方向の最小角度
    public float maximumVerticalAngle = 90f;  // 垂直方向の最大角度

    private void Update()
    {
        // プレイヤーの水平方向の回転
        float rotateHorizontal = Input.GetAxis("RightStickHorizontal") * sensitivity;
        transform.Rotate(Vector3.up * rotateHorizontal);

        // プレイヤーの垂直方向の回転
        float rotateVertical = Input.GetAxis("RightStickVertical") * sensitivity;
        rotateVertical = Mathf.Clamp(rotateVertical, -1f, 1f); // 入力を -1 から 1 の範囲に制限

        float rotationX = transform.localEulerAngles.x - rotateVertical;
        rotationX = Mathf.Clamp(rotationX, minimumVerticalAngle, maximumVerticalAngle);

        // 垂直方向の回転を適用
        transform.localEulerAngles = new Vector3(rotationX, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
