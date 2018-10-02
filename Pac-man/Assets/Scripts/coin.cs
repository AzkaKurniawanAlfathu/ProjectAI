using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
    pacman playe;

    // Use this for initialization
    void Start () {
        playe = GameObject.Find("player").GetComponent<pacman>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D other){
		if(other.transform.tag == "Player"){
			Destroy(gameObject);
			playe.coin+= 50;
		}
	}
}
