using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fitBar : MonoBehaviour {

    public Text buttonText;
    public Slider barra;
    public Text tiempoText;
    public Text tiempoBool;
    public float tiempo = 0.0f;
    public Canvas MainCanvas;

    float valorBarra = 0f;
    bool play = false;

    public void Slider_Change(float newValue)
    {
        barra.value = newValue;
    }

    public void pressTomarElControl()
    {
        valorBarra += .2f;
        Slider_Change(valorBarra);
        play = true;
    }

    public void cuentaAtras()
    {
        if (tiempo>0)
        {
            tiempo = tiempo - 1 * Time.deltaTime;
            if (tiempo <= 0)
            {
                tiempoText.text = "0";
                tiempoBool.enabled = true;
            }
            else {
                tiempoText.text = "" + tiempo.ToString("f0");

            }
        }
        
    }

	// Use this for initialization
	void Start () {
        

    }

    private void OnEnable()
    {
        tiempoBool.enabled = false;
        MainCanvas.gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        //MainCanvas.enabled = true;
    }

    // Update is called once per frame
    void Update () {

        if (play)
        {
            cuentaAtras();
        }
       
        

        //valorBarra -= .5f;
        //Slider_Change(valorBarra);


    }
}
