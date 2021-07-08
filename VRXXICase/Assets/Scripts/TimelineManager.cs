using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineManager : MonoBehaviour
{
    public List<PlayableDirector> playInDirectors;
   // public List<TimelineAsset> timelines;
    public int currentIndex = 0;

    //public void Play()
    //{
    //    foreach(PlayableDirector playInDirector in playInDirectors)
    //    {
    //        playInDirector.Play();
    //    }
    //}

    //public void PlayFromTimelines (int index)
    //{
    //    TimelineAsset selectedAsset;

    //    if (timelines.Count <= index)
    //    {
    //        selectedAsset = timelines[timelines.Count - 1];
    //    }
    //    else
    //    {
    //        selectedAsset = timelines[index];
    //    }

    //    playInDirectors[0].Play(selectedAsset);
    //}

    public void PlayTimelineObject (int index)
    {
        playInDirectors[index].Play();
        currentIndex = index;
        Debug.Log(currentIndex);
    }

    public void StopTimelineObject (int index)
    {
        playInDirectors[index].Stop();
    }
}
