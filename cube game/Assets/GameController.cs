using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public float delay;
    public Transform leftPos;
    public Transform rightPos;
    public Transform midPos;
    public GameObject enemy;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {


        int randomPos = Random.Range(1, 4);

        if (randomPos == 1)
        {

            Instantiate(enemy, leftPos);
        }
        else if (randomPos == 2)
        {
            Instantiate(enemy, rightPos);

        }
        else
        {
            Instantiate(enemy, midPos);

        }


    }



}



