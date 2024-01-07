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
    //　スタートボタンを押したら実行する
    public void ClearGame()
    {
        SceneManager.LoadScene("Title");
    }
}