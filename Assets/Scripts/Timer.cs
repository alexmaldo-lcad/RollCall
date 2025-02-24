using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float remainingTime = 30;
    public TextMeshProUGUI timerText;
    public GameObject youLose;
    public GameObject youWin;

    public SealSpawner sealSpawnerScript;
    public PlayerCounter playerCounterScript;

    void Start()
    {
       
    }

    void Update()
    {
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            playerCounterScript.allowCounting = false; //player no longer allowed to count (mostly to stop sound effects)
            if (sealSpawnerScript.numberOfSeals == playerCounterScript.currentNumber)
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

