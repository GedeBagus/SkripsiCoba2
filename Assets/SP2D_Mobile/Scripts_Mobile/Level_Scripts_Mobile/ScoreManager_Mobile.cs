using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace Bitboys.SuperPlaftormer2D {
	public class ScoreManager_Mobile : MonoBehaviour {

	public static int score;

	Text text;

	void Start()
	{
		text = GetComponent<Text> ();

		score = 0;

	}

	void Update()
	{
		if (score < 0)
			score = 0;
		text.text = "" + score;
	}

	public static void AddPoints (int pointsToAdd)
	{
		score += pointsToAdd;

	}

	public static void Reset()
	{
		score = 0;

	}
}
}
///////////////////////////////////////////////////////////////// SUPER PLATFORMER 2D by BITBOYS ///////////////////////////////////////////////////////////////////////////////////////////////
