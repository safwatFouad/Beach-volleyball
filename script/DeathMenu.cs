using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DeathMenu : MonoBehaviour {
	
	// Use this for initialization
	public Text scoretext;
	public Text scoretext2;

	void Start () {
		this.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

	}
	public void toggleendmenu (int j_score,int pc_score)
	{
		
		this.gameObject.SetActive(true) ;

	    scoretext.text = ((int)j_score).ToString ();
		scoretext2.text = ((int)pc_score).ToString ();

	}
	public void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
