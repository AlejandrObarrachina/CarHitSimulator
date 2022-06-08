using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject AssassinTankPrefab;
    public GameObject AssasinVan;
    public GameObject AssasinBus;
    public float secondsBetweenSpawn;
    public float elapsedTime = 0.0f;
    Quaternion newQuaternion =  new Quaternion();
    // public Transform target = Vector3.up;
    void Start()
    {

        newQuaternion.Set(0.0f, -180.0f, 0.0f, 0.0f);


       
    }
    
    void Spawn(GameObject vehicleType)
    {

        Instantiate(vehicleType, transform.position, newQuaternion);


    }
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;
            Debug.Log(true);

           int rndNumber = Random.Range(0, 3);
           
            if (rndNumber == 1)
            {
                Spawn(AssassinTankPrefab);

            }
            else if (rndNumber == 2)
            {
                Spawn(AssasinVan);

            }
            else
            {
                Spawn(AssasinBus);

            }
        }
    }
}






