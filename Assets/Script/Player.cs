using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject[] ParticleSpawns = null;
    public GameObject[] BloodParticleSpawn = null;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

           Instantiate(BloodParticleSpawn[Random.Range(0, BloodParticleSpawn.Length)]);

        }


    }
}
