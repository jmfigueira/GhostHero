using UnityEngine;
using System.Collections;

public class MoveEstrela : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 150.3861f) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 191.6553f) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
