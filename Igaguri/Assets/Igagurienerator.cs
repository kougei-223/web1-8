﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igagurienerator : MonoBehaviour {

    public GameObject igaguriPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject igaguri =
                Instantiate(igaguriPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<IgaguriController>().shoot(
                worldDir.normalized * 2000);
        }
	}
}
