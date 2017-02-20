using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection_water : MonoBehaviour {
public Color color = new Color(0.165F, 0.278F, 0.45F, 1F);

    // Use this for initialization
    void Start () {

        
        RenderSettings.fog = false;
        RenderSettings.fogColor = color;
        RenderSettings.fogDensity = 0.0050f;
	}
	
    bool IsunderWater()
    {
        return gameObject.transform.position.y < 0f;
    }
	// Update is called once per frame
	void Update () {

        RenderSettings.fog = IsunderWater();
	}
}
