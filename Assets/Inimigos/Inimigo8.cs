using UnityEngine;
using System.Collections;

public class Inimigo8 : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 380.6236f;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 375.9596f) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 387.4019f) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
