using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pc : MonoBehaviour {

	public bool isGrounded;
	public GameObject theball;
	public AudioClip teleportsound;


	private float speed;
	private float w_speed = 0.05f;
	public float rootspeed;
	public float jumpheight;
	Rigidbody rb;
	Animator anim;
	CapsuleCollider col_size;
	public float turnSmoothTime = 0.2f;
	float turnSmoothVelocity;






	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
		col_size = GetComponent<CapsuleCollider>();
		isGrounded = true;

	}



	// Update is called once per frame
	void Update () {





		if (Input.GetKey(KeyCode.Z)  && isGrounded == true && this.transform.position.x - theball.transform.position.x <=10)
		{
			anim.SetTrigger("isthrowball");

			volleypc ball =theball.GetComponent("volleypc")as volleypc;

			ball.player ();

			if(teleportsound !=null)
			{
				AudioSource.PlayClipAtPoint (teleportsound , this.transform.position);

			}

		}








	

	}

	void OnCollisionEnter()
	{
		isGrounded = true;

	}


}






