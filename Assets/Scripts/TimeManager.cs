using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
    public Text timeText;
    public float totalTime = 10.0f; // Th?i gian chõi t?ng c?ng
    private float currentTime = 0;
    private bool isGameOver = false;

    void Update()
    {
        if (!isGameOver)
        {
            currentTime += Time.deltaTime;
            UpdateTimeDisplay();

            if (currentTime >= totalTime)
            {
                GameOver();
            }
        }
    }

    void UpdateTimeDisplay()
    {
        float remainingTime = totalTime - currentTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60F);
        int seconds = Mathf.FloorToInt(remainingTime - minutes * 60);
        string timeString = string.Format("{0:0}:{1:00}", minutes, seconds);
        timeText.text = "Time: " + timeString;
    }

    void GameOver()
    {
        isGameOver = true;

        // Hi?n th? màn h?nh Game Over, có th? th?c hi?n thông qua vi?c kích ho?t m?t panel Game Over trong Canvas
        Debug.Log("Game Over!");
    }
}