using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float remainingTime;
    public TextMeshProUGUI timerText;
    public GameObject youLose;
    public GameObject youWin;
    public SealSpawner numberOfSeals;
    public PlayerCounter currentNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (remainingTime <= 0)
        {
            if (numberOfSeals == currentNumber)
            {
                Debug.Log("Player wins!");
                youWin.SetActive(true);

            }
            else
            {
                Debug.Log("Player loses!");
                youLose.SetActive(true);
            }

        }
    }
}

