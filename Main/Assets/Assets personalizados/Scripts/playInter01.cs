using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine;

public class playInter01 : MonoBehaviour {

    public PlayableDirector timeline;
    public GameObject desiciones;
    public GameObject altima;
    public GameObject altima4Anim;

    public GameObject panelA;
    public GameObject panelB;

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
            desiciones.gameObject.SetActive(true);
            disableAltima();
        }
    }

    public void disableAltima()
    {
        altima.gameObject.SetActive(false);
        altima4Anim.gameObject.SetActive(true);
    }
    public void enableAltima()
    {
        hidePanels();
        altima.gameObject.SetActive(true);
        altima4Anim.gameObject.SetActive(false);
    }

    public void hidePanels()
    {
        panelA.gameObject.SetActive(false);
        panelB.gameObject.SetActive(false);
    }

}
