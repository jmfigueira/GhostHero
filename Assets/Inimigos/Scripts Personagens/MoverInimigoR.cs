using UnityEngine;
using System.Collections;

public class MoverInimigoR : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 54;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 54) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 87) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
