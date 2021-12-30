using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text textTimer;

    private float timer = 10.0f;
    public GameController gameController;

    void Update()
    {
        if (timer <= 0)
        {
            timer = 0;
            DisplayTime();
            gameController.GameOver();
            return;
        }
        timer -= Time.deltaTime;

        DisplayTime();


    }
    void DisplayTime()
    {
        int seconds = Mathf.FloorToInt(timer);
        textTimer.text = string.Format("{00}", seconds);
    }
}
