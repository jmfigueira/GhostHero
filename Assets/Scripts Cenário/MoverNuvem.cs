using UnityEngine;
using System.Collections;

public class MoverNuvem : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 189;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 189) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 215) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
