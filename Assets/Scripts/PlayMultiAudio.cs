using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMultiAudio : MonoBehaviour
{

    public AudioClip[] clips;   // a list of clips set inside unity editor at design

    public int curClip = 0;     //which is the current clip
   
    AudioSource source;         //the audio emitter of this object

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = clips[curClip];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Player")
        {
            //set the clip to the current clip number in the list
            source.clip = clips[curClip];

            //if the clip is not currently playing...
            if (source.isPlaying == false)
            {
                //...play it
               source.Play();
                
                //increment  the clip number
               curClip++;

                //if that number is bigger than the list of clips...
                if (curClip == clips.Length)
                    curClip = 0; //...go back to zero clip
               
            }
        }

    }

}
