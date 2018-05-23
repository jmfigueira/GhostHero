using UnityEngine;
using System.Collections;

public class MoverPlataforma : MonoBehaviour {

	float y;
	bool direita, esquerda;
	void Start () {
		y = 1.841582f;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (transform.position.x, y, transform.position.z);
		if (esquerda == true) {
			y += (-1.5f * Time.deltaTime);
			if (y <= 0) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			y += (1.5f * Time.deltaTime);
			if (y >= 15) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}