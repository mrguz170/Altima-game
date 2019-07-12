using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    public GameObject finalizado;
    public GameObject NOfinalizado;
    public bool juegoTerminado;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void openPremio()
    {
        if(juegoTerminado == true)
        {
            finalizado.gameObject.SetActive(true);
        }
        else
        {
            NOfinalizado.gameObject.SetActive(true);
        }
    }
}
