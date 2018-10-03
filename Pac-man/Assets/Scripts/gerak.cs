using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerak : MonoBehaviour {

	public int speed;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(Vector2.right*speed*Time.deltaTime);
			anim.SetBool("lari", true);
		}
        else if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector2.left*speed*Time.deltaTime);
            anim.SetBool("lari", true);
        }
        else if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector2.up*speed*Time.deltaTime);
            anim.SetBool("lari", true);
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector2.down*speed*Time.deltaTime);
            anim.SetBool("lari", true);
        }

		else{
			anim.SetBool("lari", false);

		}
	}
}
