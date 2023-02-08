using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    ScoreScript MyscoreScript;
    public int score = 0;

    public void start()
    {
        MyscoreScript = GetComponent<ScoreScript>();
        Endscreen();
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            score++;
            GameObject.Find("Canvas").GetComponent<ScoreScript>().pointScore();
            Destroy(other.gameObject);
            if (score == 8)
            {
                Endscreen();
            }

        }
    }

    public void Endscreen()
    {
       GameObject.Find("Win Canvas").GetComponent<Canvas>().enabled = true;
    }

}
