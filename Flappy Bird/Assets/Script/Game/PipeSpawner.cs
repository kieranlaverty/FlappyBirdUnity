using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe; // spawned object
    public float spawnrate = 2; // rate of the spawning
    public float timer = 0; // timer for the spawning
    public float hieghtoffset = 3; // pipe y offset

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            //add the time for the last frame
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();

            //reset timer
            timer = 0;
        }
        
    }
    void spawnPipe()
    {
        //max
        float max = transform.position.y + hieghtoffset;

        //min
        float min = transform.position.y - hieghtoffset;

        //create a new instance of the game object at the spawner
        Instantiate(pipe, //game object
            new Vector3(transform.position.x, //x position is the same
            Random.Range(min, max), //select y random from range
            transform.position.z), transform.rotation); //z position is the same

        

    }
}
