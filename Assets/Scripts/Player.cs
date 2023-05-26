using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public AudioVisualizer viz;
    public bool useFFT = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float move = 0;
        float turn = 0;
        
        

        if(useFFT)
          move = viz.totalAmps * 100 ;

        //get input from the user
        if ( Input.GetKey(KeyCode.UpArrow) )
        {
            move = 10 ;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            move = -10;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            turn = -100;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            turn = 100;
        }

        //move the dude aka blue box

        transform.Rotate(new Vector3(0, turn * Time.deltaTime, 0));

        transform.position = transform.position + transform.forward *  move * Time.deltaTime;

    }
}
