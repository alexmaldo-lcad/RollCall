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
    public TextMeshProUGUI youWinText;
    public TextMeshProUGUI youLoseText;
    public TextMeshProUGUI finalNumberText;

    public SealSpawner sealSpawnerScript;
    public PlayerCounter playerCounterScript;

    void Start()
    {
       
    }

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            finalNumberText.text = "The final number is " + sealSpawnerScript.numberOfSeals; //displays the final number of seals whether u win OR lose
            finalNumberText.gameObject.SetActive(true);

            playerCounterScript.allowCounting = false; //player no longer allowed to count (mostly to stop sound effects)

            if (sealSpawnerScript.numberOfSeals == playerCounterScript.currentNumber)
            {
                Debug.Log("Player wins!");
                youWin.SetActive(true);
                youWinText.gameObject.SetActive(true);

            }
            else
            {
                Debug.Log("Player loses!");
                youLose.SetActive(true);
                youLoseText.gameObject.SetActive(true);
            }
        }
    }
}

