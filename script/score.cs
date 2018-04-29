using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score : MonoBehaviour {

	public Text Jasperscoretext;
	public Text pcscoretext;
	public Text winner;

	private int jasper_scoree = 0;
	private int pc_scoree = 0;

	private int maxscore=5;
	private bool isdead =false;

	private DeathMenu deathmenu = new DeathMenu();

	public GameObject theball;
	public GameObject Jasper;
	public GameObject pc;
	private bool finish =false;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
 void Update () {
		if (finish == false) {
			

			if (theball.transform.position.y <= 33 && theball.transform.position.x > 267.76 && jasper_scoree < maxscore) {
				jasper_scoree = jasper_scoree + 1;
				Debug.Log ("jasper ===> " + jasper_scoree);
				theball.transform.position = new Vector3 (195.73f, 46.2f, 284.78f);
				Jasper.transform.position = new Vector3 (195f, 29.99451f, 276.57f);
				pc.transform.position = new Vector3 (343.3f, 29.99451f, 276.57f);		
				Jasperscoretext.text = ((int)jasper_scoree).ToString ();

			}


			if (theball.transform.position.y <= 33 && theball.transform.position.x < 267.76 && pc_scoree < maxscore) {
				pc_scoree = pc_scoree + 1;
				theball.transform.position = new Vector3 (340.26f, 46.2f, 284.78f);
				Jasper.transform.position = new Vector3 (195f, 29.99451f, 276.57f);
				pc.transform.position = new Vector3 (343.3f, 29.99451f, 276.57f);		
				pcscoretext.text = ((int)pc_scoree).ToString ();
			}


			if (theball.transform.position.x <= 193) {

				jasper_scoree = jasper_scoree + 1;
				theball.transform.position = new Vector3 (195.73f, 46.2f, 284.78f);
				Jasper.transform.position = new Vector3 (195f, 29.99451f, 276.57f);
				pc.transform.position = new Vector3 (343.3f, 29.99451f, 276.57f);		
				Jasperscoretext.text = ((int)jasper_scoree).ToString ();
			}


			if (theball.transform.position.x >= 349) {
				pc_scoree = pc_scoree + 1;
				theball.transform.position = new Vector3 (340.26f, 46.2f, 284.78f);
				Jasper.transform.position = new Vector3 (195f, 29.99451f, 276.57f);
				pc.transform.position = new Vector3 (343.3f, 29.99451f, 276.57f);		
				pcscoretext.text = ((int)pc_scoree).ToString ();
			}
			if (jasper_scoree == maxscore || pc_scoree == maxscore) {
				finish = true;


			}

		} else {

			if (jasper_scoree > pc_scoree) {
				winner.text = "Jasper is winner ";

			
			} else {
				winner.text = "Pc is winner ";

			}

		    jasper_scoree = 0;
			pc_scoree  = 0;

			Jasperscoretext.text = ((int)jasper_scoree).ToString ();
			pcscoretext.text = ((int)pc_scoree).ToString ();

			theball.transform.position = new Vector3 (340.26f, 46.2f, 284.78f);
			Jasper.transform.position = new Vector3 (195f, 29.99451f, 276.57f);
			pc.transform.position = new Vector3 (343.3f, 29.99451f, 276.57f);

		
			finish = false;

			}


}


}