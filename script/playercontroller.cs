using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

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




		Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		Vector2 inputDir = input.normalized;



		if (Input.GetKey(KeyCode.Space) && isGrounded == true)
		{
			rb.AddForce(0, jumpheight, 0);
			anim.SetTrigger("isthrowball");
			isGrounded = false;
		}

		if  (Input.GetKey(KeyCode.X)  && isGrounded == true  && theball.transform.position.x - this.transform.position.x <=10)
		{
			anim.SetTrigger("isthrowball");

			vollyball ball =theball.GetComponent("vollyball")as vollyball;
		
			ball.player ();

			if(teleportsound !=null)
			{
				AudioSource.PlayClipAtPoint (teleportsound , this.transform.position);

			}

		}


	











		if(isGrounded)
		{
			speed = w_speed;

			if (inputDir != Vector2.zero)
			{
				float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg;
				transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
				anim.SetBool("iswalking", true);
				anim.SetBool("isrunning", false);
				anim.SetBool("isidel", false);
			}

			/*else if (Input.GetKey(KeyCode.LeftShift) )
            {
                anim.SetBool("iswalking", true);
                anim.SetBool("isrunning", true);
                anim.SetBool("isidel", false);
            }*/
			else
			{
				anim.SetBool("iswalking", false);
				anim.SetBool("isrunning", false);
				anim.SetBool("isidel", true);
			}

		}

	}

	void OnCollisionEnter()
	{
		isGrounded = true;

	}



}






