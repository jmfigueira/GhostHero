using UnityEngine;
using System.Collections;

public class MoverPisca2 : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 300.2103f;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 269.2507f) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 312.97f) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
