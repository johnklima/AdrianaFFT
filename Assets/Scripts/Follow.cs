using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Transform target; //the blue box aka the player


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 targetPos = target.position - target.forward * 10; //change this for distance
        targetPos.y += 3; //change this for height

        transform.position = targetPos;
        transform.LookAt(target.position);

    }
}
