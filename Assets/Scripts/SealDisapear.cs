using UnityEngine;

public class SealDisapear : MonoBehaviour
{
    public float timer = 0f;
    private float nextDisapearTime; //randomly between 5 and ten seconds
    private bool isVisible = true;

    public float speed;
    public Vector3 sealMoveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextDisapearTime = Random.Range(5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= nextDisapearTime && isVisible) //if the seal is visible and its been between 5-10 seconds, hide the seal
        {
            HideSeal();
        }
    }
    void HideSeal()
    {
        isVisible = false;

        gameObject.SetActive(false);

        nextDisapearTime = Random.Range(5f, 10f);

        timer = 0f;

        Invoke("ShowSeal", 1f); //will show the seal again after 1 second
    }
    void ShowSeal() //shows seal again
    {
        isVisible = true;

        gameObject.SetActive(true);
    }
}