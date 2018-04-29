using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volleypc : MonoBehaviour {

	public Transform target;

	public float fireangle= 60.0f;
	public float gravity = 50.0f;

	public Transform projectile;
	private Transform mytransform;






	public void Start () {

	}



	public void player()
	{

		mytransform = transform;
		StartCoroutine (Simulatprojectileplayer());
	}


	IEnumerator Simulatprojectileplayer()
	{
		yield return new WaitForSeconds (0.0f);

		projectile.position = mytransform.position + new Vector3 (0, 0.0f, 0);


		float target_distance = Vector3.Distance (projectile.position, target.position);

		float projectile_velocity = target_distance / (Mathf.Sin (2 * fireangle * Mathf.Deg2Rad) / gravity);

		float Vx = Mathf.Sqrt (projectile_velocity) * Mathf.Cos (fireangle * Mathf.Deg2Rad);

		float Vy = Mathf.Sqrt (projectile_velocity) * Mathf.Sin (fireangle * Mathf.Deg2Rad);

		float flightduration = target_distance / Vx;

		projectile.rotation = Quaternion.LookRotation (target.position - projectile.position);

		float elapse_time = 0;

		while(elapse_time < flightduration)
		{
			projectile.Translate (0, (Vy - (gravity * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

			elapse_time += Time.deltaTime;
			yield return null;

		}

		//transform.position = new Vector3 (336.22f,42.41f,279.41f);
	}







}




