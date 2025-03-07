using UnityEngine;

public class SealMover : MonoBehaviour
{
    public float speed;
    public Vector3 sealMoveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(1f, 6f);
        sealMoveDirection = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
        this.transform.position += sealMoveDirection * speed * Time.deltaTime;
    }

}
