using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine;

public class beginInteraction : MonoBehaviour {

    public PlayableDirector timeline;
    
    public GameObject altima;
    public GameObject altima4Anim;

    public GameObject panelInteraction;
    public GameObject AoB;
    public GameObject panelA;
    public GameObject panelB;
    public GameObject panelEstrellas;
    public GameObject panelControles;


    public GameObject estrella;
    public Image fill_star;
    public Sprite fill2;
    public Sprite sprite_fillStar;

    bool state = false;

    // Use this for initialization
    void Start () {
       
        panelInteraction.gameObject.SetActive(false);
        //AoB.gameObject.SetActive(false);
        timeline = GetComponent<PlayableDirector>();
    }
    //evento al entrar al triggerbox
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player" && state == false)
        {         
            estrella.gameObject.SetActive(false);   //deshabilitar estrella 
            panelInteraction.gameObject.SetActive(true); //habilitar panel interaction
            panelEstrellas.gameObject.SetActive(false);
            panelControles.gameObject.SetActive(false);
            timeline.Play();
            state = true;
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
        panelInteraction.SetActive(false);
    }

    
    public void push_A()
    {
        AoB.gameObject.SetActive(false);
        panelA.gameObject.SetActive(true);
    }

    public void push_B()
    {
        AoB.gameObject.SetActive(false);
        panelB.gameObject.SetActive(true);
    }

    // AL GANAR: funcion llamada al presionar next/go/continue
    public void winStar()
    {
        panelEstrellas.gameObject.SetActive(true);
        panelControles.gameObject.SetActive(true);
        enableAltima();
        addStar();
    }

    // AL PERDER: funcion llamada al presionar next/go/continue
    public void loseStar()
    {
        panelEstrellas.gameObject.SetActive(true);
        panelControles.gameObject.SetActive(true);
        enableAltima();
        
    }
    
    // AL REINTENTAR: funcion llamada al presionar next/go/continue
    public void retryStar()
    {
        panelEstrellas.gameObject.SetActive(true);
        panelControles.gameObject.SetActive(true);
        enableAltima();
    }

    //------------------------------------------------//

    public void addStar()
    {

    }

}
