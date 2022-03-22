using UnityEngine;
using System.Collections;

namespace Bitboys.SuperPlaftormer2D {

	// This scripts handles the enemy's health.

	public class EnemyHealthManager_Mobile : MonoBehaviour {

	[Range(0, 10)] // Slide Bar.
	public int enemyHealth = 4; // The health amount of the enemy.
	public GameObject deathEffect; // the instantiated particles when the enemy dies.
	[Range(0, 1000)] // Slide Bar.
	public int pointsOnDeath = 100; // score recieved when kill an enemy.
	public AudioClip knockBackSfx; // the sound emited whenever the enemy is damaged.
	[Range(0.0f, 5.0f)] // Slide bar.
	public float knockBackSfxVolume = 1f; // the sound effect volume.
	[Range(0.0f, 5.0f)] 
		private float    _flashSpeed = 0.15f; // the time to wait since the sprite component is disabled and until is enabled again.
	[Range(0.0f, 5.0f)] 
	private float _lengthOfTimeToFlash = 0.1f; // The lenght of the flash 
	

	// Update is called once per frame
	void FixedUpdate () {
			
			if (enemyHealth <= 0) {
			Instantiate(deathEffect, transform.position, transform.rotation); // if the enemy dies we instantiate the death effect particles.
			ScoreManager_Mobile.AddPoints(pointsOnDeath); // we add some points to the score counter.
			Destroy (gameObject); // finally destroy this object.

		}
	
      } 
        public void giveDamage(int damageToGive)
	{
		enemyHealth -= damageToGive; // substract the enemy energy.
		AudioSource.PlayClipAtPoint (knockBackSfx, Camera.main.transform.position, knockBackSfxVolume); // the sound we use whenever the enemy recieves an impact.
			StartCoroutine(Flash(_flashSpeed, _lengthOfTimeToFlash)); // we activate the flash coroutine to make the enemy flash.

			}


		// This enumerator will make the enemy flash when receiving a fireball impact.
		IEnumerator Flash(float duration, float blinkTime)	{

		
			duration -= Time.deltaTime;

			//toggle Sprite renderer off
			GetComponent<Renderer> ().enabled = false;
			//wait for a bit
			yield return new WaitForSeconds (blinkTime);
			//toggle Sprite renderer on
			GetComponent<Renderer> ().enabled = true;
			yield return new WaitForSeconds (blinkTime);
			GetComponent<Renderer> ().enabled = false;
			yield return new WaitForSeconds (blinkTime);
			GetComponent<Renderer> ().enabled = true;
			yield return new WaitForSeconds (blinkTime);
			GetComponent<Renderer> ().enabled = false;
			yield return new WaitForSeconds (blinkTime);
			GetComponent<Renderer> ().enabled = true;

		}
	
	
}
	
}


///////////////////////////////////////////////////////////////// SUPER PLATFORMER 2D by BITBOYS ///////////////////////////////////////////////////////////////////////////////////////////////
