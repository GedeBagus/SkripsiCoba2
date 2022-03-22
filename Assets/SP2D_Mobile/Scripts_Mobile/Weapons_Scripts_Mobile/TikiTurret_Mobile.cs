using UnityEngine;
using System.Collections;
namespace Bitboys.SuperPlaftormer2D {

	public class TikiTurret_Mobile : MonoBehaviour {

		[Range(0.0f, 20.0f)] // slide bar.
		public float playerRange = 10.0f;//The range between the player and the enemy.
		public LayerMask playerLayer;// We use this layer mask to tell the enemy who is the player.
		public bool playerInRange;// sets if the player is the "attack" area.		public GameObject arrow;
		public Transform firePoint;
		public float shotDelay; // The delay between shoots.
		//private float shotDelayCounter; // The shoots delay counter.
		[Range(0.0f, 5.0f)] // Slide Bar.
		public float timeBetweenShots = 1;  
		private float timestamp; // 
		public GameObject arrow;


	void Update () {

			// if the character is near from the turret she will start shooting.
			playerInRange = Physics2D.OverlapCircle (transform.position, playerRange, playerLayer);


			if (playerInRange && Time.time >= timestamp) {
				Instantiate (arrow,firePoint.position, firePoint.rotation);
				timestamp = Time.time + timeBetweenShots;
				return;
			}
	}


}

}
///////////////////////////////////////////////////////////////// SUPER PLATFORMER 2D by BITBOYS ///////////////////////////////////////////////////////////////////////////////////////////////
