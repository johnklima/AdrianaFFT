using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

public float xSpread;
public float zSpread;
public Transform CenterPoint;
public float RotationSpeed;
public bool RotateClockwise;
float timer = 0;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * RotationSpeed;
        if (RotateClockwise)
        {
            float x = -Mathf.Cos(timer)*xSpread;
            float z = Mathf.Sin(timer)*zSpread;
            Vector3 pos = new Vector3(x, transform.position.y, z);
            transform.position = CenterPoint.position + pos;
        }
        else
        {
            float x = Mathf.Cos(timer)*xSpread;
            float z = Mathf.Sin(timer)*zSpread;
            Vector3 pos = new Vector3(x, transform.position.y, z);
            transform.position = CenterPoint.position + pos;
        }
    }
}