using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : MonoBehaviour
{
    Player player;


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
            Destroy(gameObject);
       }
    }
}
