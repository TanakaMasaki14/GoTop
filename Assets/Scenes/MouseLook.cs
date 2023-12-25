using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 0f; // マウスの感度

    private float xRotation = 0f;

    private bool isMoving = false; // プレイヤーが移動中かどうかを判定するフラグ

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // マウスカーソルをロックして非表示にする
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 上下の回転角度を制限する

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // カメラの回転を設定

        if (!isMoving)
        {
            transform.parent.Rotate(Vector3.up * mouseX, Space.World); // プレイヤーキャラクターの回転を設定
        }
    }

    public void SetIsMoving(bool moving)
    {
        isMoving = moving;
    }
}
