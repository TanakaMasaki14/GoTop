using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerReset : MonoBehaviour
{
    public Transform resetPosition; // プレイヤーをリセットする位置

    private Vector3 initialPosition; // 最初の位置

    private void Start()
    {
        // 最初の位置を保存
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
            // リセット位置にプレイヤーの位置を移動
            transform.position = resetPosition.position;
        }
        else
        {
            transform.position = initialPosition;
        }
    }
}
