using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            GameObject.Find("Canvas").GetComponent<ScoreScript>().pointScore();
            Destroy(other.gameObject);
        }
    }

}
