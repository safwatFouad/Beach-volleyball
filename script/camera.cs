using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
	public Camera maincamare;
	public Camera playerdirectioncamre;
	public Camera personalcamare;
	// Use this for initialization

	void Update () {{
			if(Input.GetKey(KeyCode.M) )
	{
		maincamare.enabled = false;
	    playerdirectioncamre.enabled = true;
				personalcamare.enabled = false;
	}

			if(Input.GetKey(KeyCode.N) )
		{
		maincamare.enabled = true;
	    playerdirectioncamre.enabled = false;
				personalcamare.enabled=false;

	}
			if(Input.GetKey(KeyCode.B) )
			{
				maincamare.enabled = false;
				playerdirectioncamre.enabled = false;
				personalcamare.enabled = true;

			}
}

}
}