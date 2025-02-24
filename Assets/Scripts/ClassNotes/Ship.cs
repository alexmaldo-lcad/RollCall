using System.Collections.Generic; //allows us to make lists
using System.Linq; //makes ToList work
using Unity.VisualScripting;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Cannon> cannons = new List<Cannon>(); //declaring that this new lost is empty to avoid a null references

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.InstanceID).ToList(); //findas all objects in the scene with Cannon script on them, tosses it into array, then
        //converted into a list
        //cannons[0].FireCannon(); //fires the first cannon in the list
        //cannons[1].FireCannon(); //fires the second cannon in the list
    }

    // Update is called once per frame
    void Update()
    {
        FireAllcannons();

        FireEvenCannons();

        FireOddCannons();
    }

    void FireAllcannons()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (Cannon c in cannons)
            {
                c.FireCannon(); //referencing function from Cannon script
            }
        }
    }

    void FireEvenCannons()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < cannons.Count; i++)
            {
                //if it's odd, don't fire, if it's even, fire
                if (i % 2 == 0)
                {
                    cannons[i].FireCannon();
                }
            }
        }
    }

    void FireOddCannons()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < cannons.Count; i++)
            {
                if (i % 2 == 1)
                {
                    cannons[i].FireCannon();
                }
            }
        }
    }
}
