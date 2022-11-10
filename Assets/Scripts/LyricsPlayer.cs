using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LyricsPlayer : MonoBehaviour
{
    public Text lyrics;

    AudioSource song;

    public int Time; 


    public int Count = 0;

    public Lyrics[] soLyrics;

    //initTime (float)
    //finalTime (float)
    //currLyric (string)

    //x = 0
    //arr[x]


    //public Lyric(int initTime)
    //{
    //    initTime = -initTime
    //}


    //if (Time.time > arr[x].initTime)
    //{
    //    Text.text = arr[x].currLyric;
    //}

    //if (arr[x].finalTime < Time.time)
    //{
    //    Text.text = "";
    //    x++;
    //}



    void Start()
    {
        song = GetComponent<AudioSource>();
        lyrics.text = "";
    }

    
    void Update()
    {
        Time = Mathf.RoundToInt(PlayerPrefs.GetFloat("timer"));
        Debug.Log(Time);
        ChangeLyrics();
        //PlayLyrics();
    }

    void ChangeLyrics()
    {
        if (Time > soLyrics[Count].initTime)
        {
            lyrics.text = soLyrics[Count].currLyric;
        }

        if (Time > soLyrics[Count].finalTime)
        {
            lyrics.text = "";
            Count++;
        }
    }

    

    // void PlayLyrics()
    // {
    //     if (Time == 5F)
    //     {
    //         lyrics.text = "Letra";
    //     }
    // }
}
