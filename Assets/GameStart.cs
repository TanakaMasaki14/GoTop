using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Bボタンが押されたら実行する
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            StartGame();
        }
    }

    // ゲームを開始するメソッド
    void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
