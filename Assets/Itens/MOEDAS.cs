using UnityEngine;
using System.Collections;

public class MOEDAS : MonoBehaviour {
	public AudioClip collect;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")

			CONTADOR.pontos++;

		AudioSource.PlayClipAtPoint (collect, transform.position);

		Destroy (transform.root.gameObject);
	}
}
