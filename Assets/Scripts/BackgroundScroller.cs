﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {

    [SerializeField] float backgroundScollSpeed = 0.2f;
    Material myMaterial;
    Vector2 offSet;

	// Use this for initialization
	void Start () {
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(0f, backgroundScollSpeed);
	}
	
	// Update is called once per frame
	void Update () {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
	}
}
