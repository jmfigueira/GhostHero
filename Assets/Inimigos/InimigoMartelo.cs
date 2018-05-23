using UnityEngine;
using System.Collections;

public class InimigoMartelo : MonoBehaviour {

	float x;
	bool direita, esquerda;
	void Start () {
		x = 448.2465f;
		direita = esquerda = false;
	}
	
	void Update () {
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		if (esquerda == true) {
			x += (-6 * Time.deltaTime);
			if (x <= 413.8726f) {
				esquerda = false ; 
				direita = false;

			} 
		}
		if (direita == false) {
			x += (6 * Time.deltaTime);
			if (x >=  448.2465f) {
				esquerda = true; 
				direita = true;
			}
		}
	}
}
