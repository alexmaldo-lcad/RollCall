using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCounter : MonoBehaviour
{
    public TextMeshProUGUI playerText;
    public int currentNumber = 0;
    public AudioSource notif;
    public bool allowCounting = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerText.text = currentNumber.ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        if (allowCounting == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                currentNumber++; //adds in an increment of 1
                playerText.text = currentNumber.ToString("00"); //updates text
                notif.Play();
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                currentNumber--; //decreases in an increment of 1
                playerText.text = currentNumber.ToString("00");
                notif.Play();

                if (currentNumber < 0)
                {
                    currentNumber = 0;
                }
            }
        }
    }
}
