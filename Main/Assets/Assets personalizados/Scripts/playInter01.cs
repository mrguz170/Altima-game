using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;

using UnityEngine;

public class playInter01 : MonoBehaviour {

    public PlayableDirector timeline;
    //public GameObject altima;
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
            //altima.SetActive(false);
            timeline.Play();
            state = true;

        }
    }
}
