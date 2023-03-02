using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    // Start is called before the first frame update

    public VideoClip videoClip;
    
    public double time;

    VideoPlayer player;
    void Start()
    {
       player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play()
    {
        
        player.Play();       
    }

    void Puase()
    {
        player.Pause();
    }

    void Stop()
    {
        player?.Stop();
    }


}
