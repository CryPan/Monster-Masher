using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Monster1 : MonoBehaviour
{
    //Player player;
    public GameObject[] ParticleSpawns = null;
    public GameObject[] KillMonsterParticleSpawn = null;
    public Text MonsterLifeText = null;

    public float SwapMonster = 1;
    public float Monster1Health;
    public float Monster2Health;

    // Start is called before the first frame update
    void Start()
    {
        Monster1Health = 5;
        Monster2Health = 100;
        //player.monster1health = ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (SwapMonster == 1)
            {
                Monster1Health -= 1;
                MonsterLifeText.text = "Monsters 1 Life " + Monster1Health;
                if (Monster1Health == 0)
                {
                    Debug.Log(Monster1Health);
                    Destroy(gameObject);
                    Instantiate(KillMonsterParticleSpawn[Random.Range(0, KillMonsterParticleSpawn.Length)]);
                    Debug.Log(Monster1Health);
                    MonsterLifeText.text = "Monsters 1 Life " + Monster1Health;
                    SwapMonster++;
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SwapMonster == 2)
            {
                Debug.Log(SwapMonster + "Start");
                Monster2Health -= 1;
                MonsterLifeText.text = "Monsters 2 Life " + Monster2Health;
                if (Monster2Health == 0)
                {
                    Debug.Log(Monster2Health);
                    Destroy(gameObject);
                    Instantiate(KillMonsterParticleSpawn[Random.Range(0, KillMonsterParticleSpawn.Length)]);
                    Debug.Log(Monster2Health);
                    MonsterLifeText.text = "Monsters 2 Life " + Monster2Health;
                    SwapMonster++;
                }
            }
        }


    }

}
