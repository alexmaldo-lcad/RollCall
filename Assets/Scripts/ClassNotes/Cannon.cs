using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public Transform cannonballSpawnPosition;
    public float forcePower = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon(); //code clean up
        }
        */
    }

    public void FireCannon()
    {
        GameObject go = Instantiate(cannonballPrefab, cannonballSpawnPosition.position, cannonballSpawnPosition.rotation); //makes a variable specifically for update

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * forcePower); //spawns forward relative to the game object
    }
}
