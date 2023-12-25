using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{

    //　スタートボタンを押したら実行する
    public void ClearGame()
    {
        SceneManager.LoadScene("Title");
    }
}