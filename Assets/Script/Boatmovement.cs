using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boatmovement : MonoBehaviour {


	public int speed=5, Rot=20;
	public Transform sail;
	private bool isRotating=false;
	public GameObject Mat;
    public Vector3 pos;
    public float timer;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        /*timer += Time.deltaTime;
        if (timer >= 1)
        {
            newTarget();
            timer = 0;

        }*/




        transform.Translate (Vector3.forward * Input.GetAxis ("Vertical") * Time.deltaTime * speed);
		transform.Rotate (Vector3.up * Input.GetAxis ("Horizontal") * Time.deltaTime * Rot);

		if (Input.GetKeyDown (KeyCode.Space)) {
			isRotating = !isRotating;

		}
		if (isRotating) {
			Mat.transform.Rotate (Vector3.up * Time.deltaTime * Rot);
		}
    }
     /*void newTarget()
     {
         float myx = gameObject.transform.position.x;
         float myz = gameObject.transform.position.z;

        float xPos = myx + Random.Range(myx , myx + 50) * Time.deltaTime;
         float zPos = myz + Random.Range(myz, myz + 50)*Time.deltaTime;

        pos = new Vector3(myx, 0, myz);
        transform.Translate(pos);
    }*/
}



