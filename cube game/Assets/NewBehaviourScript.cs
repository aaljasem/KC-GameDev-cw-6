using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float inc;
    public float maxPos;
    public float minPos;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3( transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z - inc, minPos, maxPos));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z + inc, minPos, maxPos));

        }


    }





}
