using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public int speed = 0;
    public int turnSpeed = 0;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        walk();
        turn();
    }

    public void turn()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0));
    }

    public void walk()
    {
        transform.Translate(new Vector3(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime));
    }
}
