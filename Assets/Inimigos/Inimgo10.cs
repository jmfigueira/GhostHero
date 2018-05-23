using UnityEngine;
using System.Collections;

public class Inimgo10 : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 315.5832f;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-2 * Time.deltaTime);
			if (x <= 298.7093f) {
				esquerda = false ; 
				direita = false;
				
			} 
		}
		if (direita == false) {
			x += (2 * Time.deltaTime);
			if (x >= 315.8723f) {
				esquerda = true; 
				direita = true;
			}
		}
}
}
