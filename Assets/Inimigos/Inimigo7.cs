using UnityEngine;
using System.Collections;

public class Inimigo7 : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 274.9625f;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 261.08548f) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 274.9625f) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
