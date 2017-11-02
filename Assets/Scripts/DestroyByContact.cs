using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
	public GameObject Explosions;
	public GameObject playerExplosions;
	public int ScoreValue;
	public GameController gameController;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary")
		{
			return;
		}
			Instantiate (Explosions, transform.position, transform.rotation);
		if (other.tag == "Player") {
			Instantiate (playerExplosions, other.transform.position, other.transform.rotation);
		}
		gameController.AddScore (ScoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
