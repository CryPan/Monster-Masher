using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Monster1 : MonoBehaviour
{
    //Player player;
    public GameObject[] ParticleSpawns = null;
    public GameObject[] KillMonsterParticleSpawn = null;
    public Text Monster1LifeText = null;

    public float Monster1Health;

    // Start is called before the first frame update
    void Start()
    {
        Monster1Health = 50;
        //player.monster1health = ;
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Space))
        {

            Monster1Health -= 1;
            Debug.Log("Hit");

        }

        if (Monster1Health == 0)
       {
            //Monster1Health 0;
            Debug.Log(Monster1Health);
            Destroy(gameObject);
            Instantiate(KillMonsterParticleSpawn[Random.Range(0, KillMonsterParticleSpawn.Length)]);
            Debug.Log(Monster1Health);
        }

        Monster1LifeText.text = "Monsters Life " + Monster1Health;
    }
}
