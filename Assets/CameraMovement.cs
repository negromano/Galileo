using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(player.transform.position.x<0)
            transform.position = new Vector3(0, transform.position.y, -10f);
        else if (player.transform.position.x>74)
            transform.position = new Vector3(74, transform.position.y, -10f);
        else
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -10f);
	}
}
