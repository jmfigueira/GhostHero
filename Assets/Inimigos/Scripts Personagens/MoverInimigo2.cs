using UnityEngine;
using System.Collections;

public class MoverInimigo2 : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 71;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-5 * Time.deltaTime);
			if (x <= 62.73943f) {
				esquerda = false; 
				direita = false;
			} 
		}
		if (direita == false) {
			x += (5 * Time.deltaTime);
			if (x >= 86) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
