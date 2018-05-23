using UnityEngine;
using System.Collections;

public class Inimigo6 : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 279.0178f;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 279.0178f) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 296.0799f) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
