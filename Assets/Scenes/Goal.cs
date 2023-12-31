using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ゴール時の処理
            SceneManager.LoadScene("Clear");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}