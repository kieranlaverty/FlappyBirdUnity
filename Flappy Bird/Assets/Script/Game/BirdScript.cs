using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    //adds a rigidbody slot to the unity script
    //drag and drop in the unity editor
    public Rigidbody2D myrigidbody;
    public int flapStrength;
    public LogicScript logicScript;

    // Start is called before the first frame update
    void Start()
    {
        //rename object
        //gameObject.name = "Bird";
    }

    // Update is called once per frame
    void Update()
    {

        //If the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            //birdy goes up
            myrigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameover();
    }
}
