using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // B�{�^���������ꂽ����s����
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            StartGame();
        }
    }

    // �Q�[�����J�n���郁�\�b�h
    void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
