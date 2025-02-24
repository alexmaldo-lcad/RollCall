using System.Xml.Serialization;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using System.Linq;

public class SealSpawner : MonoBehaviour
{
    public GameObject sealPrefab;
    public Vector3 sealSpawnPosition;
    public int numberOfSeals;

    public List<SealDisapear> seals = new List<SealDisapear>();
    private float hideTime;
    private float showTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numberOfSeals = Random.Range(20, 41); //spawns random # of seals
        seals = FindObjectsByType<SealDisapear>(FindObjectsSortMode.None).ToList();
        Debug.Log(numberOfSeals);

        SpawnSeals();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnSeals()
    {
        //spawns seals from the index in a random location
        for (int i = 0; i < numberOfSeals; i++)
        {
            Instantiate(sealPrefab);
            sealPrefab.transform.position = sealSpawnPosition = new Vector3(Random.Range(-9f, 8f), 1f, Random.Range(-8f, 4f));
        }
    }

}
