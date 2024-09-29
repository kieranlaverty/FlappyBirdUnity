using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipe : MonoBehaviour
{


    public LogicScript Logic;

    // Start is called before the first frame update
    void Start()
    {
        //add logic script functions
        Logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //bird layer only
        if(collision.gameObject.layer == 8)
        {
            Logic.addScore();
        }
        
    }
}
