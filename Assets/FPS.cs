using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    private float startTime; // 開始時間

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // 60秒に一回fpsを表示する。
        if (Time.frameCount % 60 == 0)
        {
            var nowTime = Time.time;
            var elapsedTime = nowTime - startTime;
            Debug.Log($"fps: {Time.frameCount / elapsedTime}");
        }
    }
}