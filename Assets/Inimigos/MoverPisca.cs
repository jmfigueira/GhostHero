using UnityEngine;
using System.Collections;

public class MoverPisca : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 168;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 165.8156f) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 176.674f) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
