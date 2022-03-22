﻿using UnityEngine;
using System.Collections;

namespace Bitboys.SuperPlaftormer2D {

	//  We can assign this script to objects that want to be destroyed when we play our project on a mobile device. 

	public class DestroyOnMobile_Mobile : MonoBehaviour 
{
	#if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BLACKBERRY && UNITY_WINRT || UNITY_EDITOR
	void Start () 
	{
		Destroy (this.gameObject);
	}
    #endif
}
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////// SUPER PLATFORMER 2D By BITBOYS //////////////////////////////////////////////////////////////////////////////////////////////////////