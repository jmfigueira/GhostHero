using UnityEngine;
using System.Collections;

public class EstrelaMata : MonoBehaviour {

	public GameObject objeto;

	void OnCollisionEnter2D(Collision2D Colisao)
	{
		if (Colisao.collider.tag == "Player") 
			{
			Instantiate(objeto, transform.position,objeto.transform.rotation); 
			Destroy (gameObject);
			}
	}
}
