﻿using UnityEngine;
using System.Collections;
namespace Bitboys.SuperPlaftormer2D {
	
	public class DestroyObjectOverTime_Mobile : MonoBehaviour {

		public float lifetime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		lifetime -= Time.deltaTime;

		if (lifetime < 0) {
			Destroy (gameObject);
	
		}
	}
}
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////// SUPER PLATFORMER 2D By BITBOYS //////////////////////////////////////////////////////////////////////////////////////////////////////