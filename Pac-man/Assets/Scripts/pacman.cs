﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pacman : MonoBehaviour {

    //score
    public Text infoCoin;
    public int coin;
    //end score
    public float speed = 4.0f;
    private Vector2 arah = Vector2.zero;
    
	// Use this for initialization
	void Start () {
		infoCoin = GameObject.Find("UIcoin").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Pinput();
        move();
        koin();
	}

    void Pinput()
    {
       if (Input.GetKeyDown(KeyCode.LeftArrow)){
            GetComponent<Transform> (). eulerAngles = new Vector3 (0,0,-180);
            arah = Vector2.left;

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)){
         GetComponent<Transform> (). eulerAngles = new Vector3 (0,0,0);          
            arah = Vector2.right;
            
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)){  
             GetComponent<Transform> (). eulerAngles = new Vector3 (0,0,90);         
            arah = Vector2.up;
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){     
            GetComponent<Transform> (). eulerAngles = new Vector3 (0,0,-90);      
            arah = Vector2.down;
          
        }
    }

    void move()
    {
        transform.localPosition += (Vector3)(arah * speed) * Time.deltaTime;
    }
    void koin(){
        infoCoin.text = "score : " + coin.ToString();
    }
}
