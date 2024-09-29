using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{

    public float movement = 5; // movement speed
    public float deadzone = -15; // x position to destroy pipe

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //move the position of the pipe by the movement by time
        //https://docs.unity3d.com/ScriptReference/Time.html 
        transform.position = transform.position + (Vector3.left * movement) * Time.deltaTime;


        //if in dead zone
        if (transform.position.x < deadzone) 
        {
            //destroy self
            Destroy(gameObject);

            //print to console
            Debug.Log("Pipe Deleted");
        }
    }
}
