using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	public AudioClip collect;

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D Colisao )
	{
		if (Colisao.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (collect, transform.position);
			//Chama tela de final do game
				}
	}
}
