using UnityEngine;
using System.Collections;

public class RotVoile1 : MonoBehaviour {

	// Use this for initialization

		
		public float m_speed = 50f;

	
	
	
	// Update is called once per frame
	void Update () 
	{
	Vector3 rot = new Vector3();
	 if(Input.GetKey(KeyCode.Q))
			rot.y -= 0.1f;
     if(Input.GetKey(KeyCode.D))
            rot.y += 0.1f;
		transform.Rotate(rot);
	
}
}
