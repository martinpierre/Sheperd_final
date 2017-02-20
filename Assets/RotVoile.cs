using UnityEngine;
using System.Collections;

public class RotVoile : MonoBehaviour {

	// Use this for initialization

		
		public float m_speed = 50f;

	
	
	
	// Update is called once per frame
	void Update () 
	{
	Vector3 rot = new Vector3();
	 if(Input.GetKey(KeyCode.LeftArrow))
			rot.y -= 0.1f;
     if(Input.GetKey(KeyCode.RightArrow))
            rot.y += 0.1f;
		transform.Rotate(rot,Space.Self);
	
}
}
