﻿using UnityEngine;
using System.Collections;

public class CombatScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Attack(Vector3 position)
	{
		transform.position = position;
	}
}