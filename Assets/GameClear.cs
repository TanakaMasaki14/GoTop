using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            ClearGame();
        }
    }
    //�@�X�^�[�g�{�^��������������s����
    public void ClearGame()
    {
        SceneManager.LoadScene("Title");
    }
}