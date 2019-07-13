using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decisiones : MonoBehaviour {

    public Text opc;
    public GameObject decisions_canvas;
    public GameObject canvasA;
    public GameObject canvasB;

    public void Start()
    {
        
        canvasA.gameObject.SetActive(false);
        canvasB.gameObject.SetActive(false);
    }

    public void push_A()
    {
        opc.text = "A";
        decisions_canvas.gameObject.SetActive(false);
        canvasA.gameObject.SetActive(true);
    }

    public void push_B()
    {
        opc.text = "B";
        decisions_canvas.gameObject.SetActive(false);
        canvasB.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
