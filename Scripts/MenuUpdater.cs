using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUpdater : MonoBehaviour
{

    public float waitingSec = 5;
    public TextMeshProUGUI secondsCounter;
    public TextMeshProUGUI readyText;
    public bool gameStarted = false;

    private void Start()
    {
        Time.timeScale = 0f;

    }


    private void Count()
    {
        if (waitingSec > 0)
        {
            waitingSec -= Time.unscaledDeltaTime;
        }
        double b = System.Math.Round(waitingSec, 2);
        secondsCounter.text = b.ToString();
        if (waitingSec < 0)
        {
            gameStarted = true;
            if (Time.timeScale == 0f)
            {
                Time.timeScale = 1f;
            }
            secondsCounter.gameObject.SetActive(false);
            readyText.gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        if (gameStarted == false)
        {
            Count();
        }
    }
}
