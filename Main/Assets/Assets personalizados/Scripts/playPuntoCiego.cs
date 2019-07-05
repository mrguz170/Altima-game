using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class playPuntoCiego : MonoBehaviour {

    public PlayableDirector timeline;
    bool state = false;

    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player" && state == false)
        {
            timeline.Play();
            state = true;

        }
    }
}
