using UnityEngine;
using System.Collections;

public class Esfera : MonoBehaviour {

	public AudioClip clip;
	private float timeVida;
	public float tempoMaxVida;

	// Use this for initialization
	void Start () {
		timeVida = 0;

	}
	
	// Update is called once per frame
	void Update () {

		timeVida += Time.deltaTime;
		if (timeVida >= tempoMaxVida) {
			Destroy(gameObject);
			timeVida = 0;
				}
	
	}

	void OnCollisionEnter2D(Collision2D colisor)
	{
		if (colisor.gameObject.tag == "Player") {

			Destroy(gameObject);
				}
	}
}
