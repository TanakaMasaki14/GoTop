using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{

    //�@�X�^�[�g�{�^��������������s����
    public void ClearGame()
    {
        SceneManager.LoadScene("Title");
    }
}