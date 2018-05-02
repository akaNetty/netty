﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public int speed = 1;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		speed = ArienScript.speed;
		transform.position += Vector3.down * speed * Time.deltaTime;
	}
}
