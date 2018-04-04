using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSelector : MonoBehaviour {

    public string lane;

	// Use this for initialization
	void Start () {
        lane = "short";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.S))
        {
            lane = "short";
        }
        if (Input.GetKey(KeyCode.L))
        {
            lane = "long";
        }
    }
}
