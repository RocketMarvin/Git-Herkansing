using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int Score = 0;
    public Text p1Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void pointScore()
    {
        Score++;
        p1Text.text = Score.ToString();
    }
}
