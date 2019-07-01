using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_Cero : MonoBehaviour {

    //public GameObject altima;

	// Use this for initialization
	void Start () {

        

    }

    void OnEnable() {
        GameObject thePlayer = GameObject.Find("altima");
        thePlayer.GetComponent<RCC_CarControllerV3>().enabled = false;
        //thePlayer.GetComponent<RCC_CarControllerV3>().OnEnable();
        //thePlayer.GetComponent<RCC_CarControllerV3>().KillOrStartEngine();
        //thePlayer.SetActive(false);

    }

    void OnDisable()
    {
        GameObject thePlayer = GameObject.Find("altima");
        thePlayer.GetComponent<RCC_CarControllerV3>().enabled = true;
        //thePlayer.GetComponent<RCC_CarControllerV3>().Awake();
        //thePlayer.GetComponent<RCC_CarControllerV3>().ResetCar();


    }


    // Update is called once per frame
    void Update () {
		
	}
}
