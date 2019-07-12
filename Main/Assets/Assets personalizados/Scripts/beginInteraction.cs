using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine;

public class beginInteraction : MonoBehaviour {

    public PlayableDirector timeline;
    public GameObject desiciones;
    public GameObject altima;
    public GameObject altima4Anim;

    public GameObject panelA;
    public GameObject panelB;

    public GameObject estrella;
    public Image fill_star;
    public Sprite fill2;
    public Sprite sprite_fillStar;

    bool state = false;

    // Use this for initialization
    void Start () {
        fill_star = GetComponent<Image>();
       // fill2 = GetComponent<SpriteRenderer>();
        timeline = GetComponent<PlayableDirector>();
    }
    //evento al entrar al triggerbox
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player" && state == false)
        {
            
            estrella.gameObject.SetActive(false);
            timeline.Play();
            state = true;
            desiciones.gameObject.SetActive(true);
            disableAltima();
        }
    }

    //deshabilitar Altima
    public void disableAltima()
    {
        altima.gameObject.SetActive(false);
        altima4Anim.gameObject.SetActive(true);
    }

    //habilitar altima y continuar
    public void enableAltima()
    {
        hidePanels();
        altima.gameObject.SetActive(true);
        altima4Anim.gameObject.SetActive(false);
    }
    //
    public void hidePanels()
    {
        panelA.gameObject.SetActive(false);
        panelB.gameObject.SetActive(false);
    }


    public void winStar()
    {
        //fill_star.gameObject.GetComponent<SpriteRenderer>().sprite = sprite_fillStar;
        enableAltima();
    }
}
