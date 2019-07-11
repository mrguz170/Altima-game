using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableAltima : MonoBehaviour {

    public GameObject altima;

    void OnEnable()
    {
        //GameObject thePlayer = GameObject.Find("altima");
        altima.SetActive(false);

        //thePlayer.GetComponent<RCC_CarControllerV3>().OnEnable();
        //thePlayer.GetComponent<RCC_CarControllerV3>().KillOrStartEngine();
        //thePlayer.SetActive(false);

    }

    void OnDisable()
    {
        //GameObject thePlayer = GameObject.Find("altima");
        if (altima.GetComponent<Renderer>() == null ) {

            altima.gameObject.SetActive(true);


        }

    }
}
