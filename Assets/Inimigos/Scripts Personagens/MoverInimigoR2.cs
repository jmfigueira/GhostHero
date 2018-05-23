using UnityEngine;
using System.Collections;

public class MoverInimigoR2 : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 224;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 221.2802f) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 233.6624) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
