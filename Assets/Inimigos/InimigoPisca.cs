using UnityEngine;
using System.Collections;

public class InimigoPisca : MonoBehaviour {



	public bool g;
	public float force;

	public float jumpTime = 0.5f;
	public float jumpDelay = 0.1f;
	public bool jumped = false;
	public Transform Ground;
	
	void Start () {
	}
	
	void Update () {
		Movimentar ();
	}
	
	void Movimentar ()
	{
		g = Physics2D.Linecast (this.transform.position, Ground.position,1<<LayerMask.NameToLayer("Plataforma"));	
		
		if (g && !jumped) {
			rigidbody2D.AddForce(transform.up * force);
			jumpTime = jumpDelay;
			jumped = true;
		}
		
		jumpTime -= Time.deltaTime;
		
		if (jumpTime <= 0 && g && jumped) {
			jumped = false;
		}
		
	}
}
