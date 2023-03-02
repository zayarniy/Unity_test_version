using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController2 : MonoBehaviour
{

    public VideoPlayer video;
    public Slider slider;


    bool isDone;

    public bool isPlaying
    {
        get
        {
            return video.isPlaying;
        }
    }

    public bool isPaused {

        get
        {
            return video.isPaused;
        }
    }

    public bool isLooping
    {
        get
        {
            return video.isLooping;
        }

    }

    public bool isPrepare
    {
        get
        {
            return video.isPrepared;
        }

    }

    public bool IsDone
    {
        get
        {
            return isDone;
        }
        set
        {
            isDone = value; 
        }

    }

    public double Time
    {
        get
        {
            return video.time;
        }

    }

    public ulong Duration
    {
        get
        {
            return (ulong)(video.frameCount / video.frameRate);
        }

    }

    public double NTime
    {
        get
        {
            return Time / Duration;
        }

    }

    private void OnEnable()
    {
        video.errorReceived += errorReciever;
        video.frameReady += frameReady;
        video.loopPointReached += loopPointReached ;
        video.prepareCompleted += prepareCompleted;
        video.seekCompleted += seekCompleted;
        video.started += started;
    }


    private void OnDisable()
    {
        video.errorReceived -= errorReciever;
        video.frameReady -= frameReady;
        video.loopPointReached -= loopPointReached;
        video.prepareCompleted -= prepareCompleted;
        video.seekCompleted -= seekCompleted;
        video.started -= started;
    }

    void errorReciever(VideoPlayer v, string msg)
    {
        Debug.Log("video player error:"+msg);
    }

    void frameReady(VideoPlayer v, long frame)
    {
        //cpu tax is heavy


    }

    void loopPointReached(VideoPlayer v)
    {
        Debug.Log("video player loop point reached");
        IsDone = true;
    }

    void prepareCompleted(VideoPlayer v)
    {
        Debug.Log("video player finished preparing");
        IsDone = false;
    }

    void seekCompleted(VideoPlayer v)
    {
        Debug.Log("video player finished seeking");
        IsDone = false;
    }



    void started(VideoPlayer v)
    {
        Debug.Log("video player started");
    }


    void Start()
    {
        video= GetComponent<VideoPlayer>();
        Debug.Log("video url:" + video.url);
        video.Prepare();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPrepare) return;
        slider.value = (float)NTime;
    }

    public void LoadVideo(string name)
    {
        string temp = video.url; //Application.dataPath + "/Videos/" + name;/*.mp4,.avi,.mov*/
        if (video.url == temp) return;
        video.url = temp;
        video.Prepare();

        Debug.Log("can set direct audio volume: "+video.canSetDirectAudioVolume);
        Debug.Log("can set playback speed: " + video.canSetPlaybackSpeed);
        Debug.Log("can set set skip on drop: " + video.canSetSkipOnDrop);
        Debug.Log("can set time: " + video.canSetTime);
        Debug.Log("can step: " + video.canStep);        
    }

    public void PlayVideo()
    {
        Debug.Log("Play video");
        Debug.Log("isPrepare"+isPrepare);
        if (!isPrepare) return;
        video.Play();
    }

    public void PauseVideo()
    {
        if (!isPlaying) return;
        video.Pause();
    }

    public void RestartVideo()
    {
        if (!isPrepare) return;
        PauseVideo();
        Seek(0);
    }

    public void StopVideo()
    {
        if (!isPrepare) return;
        video.Stop();        
    }

    public void LoopVideo(bool toggle)
    {
        if (!isPrepare) return;
        video.isLooping = toggle;
    }

    public void Seek(float nTime)
    {
        if (!video.canSetTime) return;
        if (!isPrepare) return;
        nTime = Mathf.Clamp(nTime,0,1);
        video.time = nTime * Duration;
    }

    public void IncrementPlaybackSpeed()
    {
        if (!video.canSetPlaybackSpeed) return;
        video.playbackSpeed += 1;
        video.playbackSpeed=Mathf.Clamp(video.playbackSpeed,0,10);
    }

    public void DecrementPlaybackSpeed()
    {
        if (!video.canSetPlaybackSpeed) return;
        video.playbackSpeed -= 1;
        video.playbackSpeed = Mathf.Clamp(video.playbackSpeed, 0, 10);
    }




}
