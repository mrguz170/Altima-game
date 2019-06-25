using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public CharacterController controllerPlayer;
    public float speed = 10f;

	// Use this for initialization
	void Start () {
        controllerPlayer = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

        Vector3 mov = new Vector3(SimpleInput.GetAxis("Horizontal") * speed, 0, SimpleInput.GetAxis("Vertical") * speed);

        controllerPlayer.Move(mov * Time.deltaTime);

	}
}
