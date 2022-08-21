using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour
{


    int score;
    int increment = 1;
    public Text text1;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
           
            score += increment;
            text1.text = score.ToString();
            Destroy(gameObject);

        }



    }



}
