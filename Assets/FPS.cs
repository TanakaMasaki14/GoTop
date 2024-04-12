using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    private float startTime; // �J�n����

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // 60�b�Ɉ��fps��\������B
        if (Time.frameCount % 60 == 0)
        {
            var nowTime = Time.time;
            var elapsedTime = nowTime - startTime;
            Debug.Log($"fps: {Time.frameCount / elapsedTime}");
        }
    }
}