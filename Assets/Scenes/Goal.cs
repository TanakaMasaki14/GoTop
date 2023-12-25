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
            // ƒS[ƒ‹‚Ìˆ—
            SceneManager.LoadScene("Clear");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}