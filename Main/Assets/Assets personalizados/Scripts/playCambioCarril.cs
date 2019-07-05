﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class playCambioCarril : MonoBehaviour {

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
