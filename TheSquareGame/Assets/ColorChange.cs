using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public Color farbe;
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Renderer>().material.color = farbe;
    }
}
