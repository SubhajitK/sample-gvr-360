using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer vidPlayer;
    public Transform playCube, pauseCube, stopCube;
    
    void Start()
    {
        playCube.GetComponent<Renderer>().material.color = Color.blue;
        pauseCube.GetComponent<Renderer>().material.color = Color.blue;
        stopCube.GetComponent<Renderer>().material.color = Color.blue;
    }
    // Start is called before the first frame update
    public void OnPlayVideo()
    {
        if (!vidPlayer.isPlaying)
            vidPlayer.Play();
        playCube.GetComponent<Renderer>().material.color = Color.yellow;
        pauseCube.GetComponent<Renderer>().material.color = Color.blue;
        stopCube.GetComponent<Renderer>().material.color = Color.blue;
    }
    public void OnPauseVideo()
    {
        if (vidPlayer.isPlaying)
            vidPlayer.Pause();
        pauseCube.GetComponent<Renderer>().material.color = Color.yellow;
        playCube.GetComponent<Renderer>().material.color = Color.blue;
        stopCube.GetComponent<Renderer>().material.color = Color.blue;
    }
    public void OnStopVideo()
    {
        if (vidPlayer.isPlaying)
            vidPlayer.Stop();
        playCube.GetComponent<Renderer>().material.color = Color.blue;
        pauseCube.GetComponent<Renderer>().material.color = Color.blue;
        stopCube.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
