using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Movement : MonoBehaviour
{
    Rigidbody RB;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

        RB = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {

        Move();
    }


    void Move()
    {

        RB.velocity = new Vector3(speed, 0f, 0f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
