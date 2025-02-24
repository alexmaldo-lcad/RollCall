using System.Xml.Serialization;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class SealSpawner : MonoBehaviour
{
    public GameObject sealPrefab;
    public Vector3 sealSpawnPosition;
    public Vector3 sealMoveDirection;
    public float speed;
    public int numberOfSeals;

    private List<GameObject> seals = new List<GameObject>();
    private float hideTime;
    private float showTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numberOfSeals = Random.Range(20, 41);
        Debug.Log(numberOfSeals);
        
        for (int i = 0; i < numberOfSeals; i++) //for some reason this isn't moving it along the z axis
        {
            GameObject newSeal = Instantiate(sealPrefab);
            newSeal.transform.position = sealSpawnPosition = new Vector3(Random.Range(-9f, 8f), 1f, Random.Range(-8f, 4f));
            seals.Add(newSeal);
        }
    }

    // Update is called once per frame
    void Update()
    {//idk why they vibrate
        foreach (GameObject seal in seals)
        {
            speed = Random.Range(1f, 6f);
            sealMoveDirection = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
            //seal.GetComponent<Rigidbody>().AddForce...
            seal.transform.position += sealMoveDirection * speed * Time.deltaTime;
        }
    }

}
