using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;
public class VButtonManager : MonoBehaviour,IVirtualButtonEventHandler
{
    public VideoPlayer player;
    public GameObject playButton;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        player.Play();
        playButton.GetComponent<Renderer>().enabled = false;
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
        player.Pause();
        playButton.GetComponent<Renderer>().enabled = true;
    }

   
}
