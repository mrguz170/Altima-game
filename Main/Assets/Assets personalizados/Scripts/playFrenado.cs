using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class playFrenado : MonoBehaviour {

    public PlayableDirector timeline;

	// Use this for initialization
	void Start () {
		 timeline = GetComponent<PlayableDirector>();
	}

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            timeline.Play();
        }
    }
    /*
    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
           timeline.Stop();
        }
    }
    */

   

}
