using UnityEngine;
using System.Collections;

public class MoverPlayer : MonoBehaviour {

	public bool Dano;
	public float velocidade;

	public AudioClip collect, collect2;

	public Transform player;
	private Animator animator;

	public float positionDead = -3.8f;

	public bool g = false;
	public float force;
	public float jumpTime = 0.5f;
	public float jumpDelay = 0.1f;
	public bool jumped = false;
	public Transform Ground;

	void Start () {
		animator = player.GetComponent <Animator> ();
		AudioSource.PlayClipAtPoint (collect2, transform.position);

	}
	
	void Update () {
		Movimentar ();
		if (transform.position.y <= positionDead) {
			Destroy (gameObject); // NO LUGAR DE DESTROY VOCE CHAMA A CENA DE GAMEOVER
				}
	}

	void Movimentar ()
	{
		g = Physics2D.Linecast (this.transform.position, Ground.position,1<<LayerMask.NameToLayer("Plataforma"));
		animator.SetFloat ("run", Mathf.Abs (Input.GetAxis ("Horizontal")));


		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate(Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0,0);	

		}
		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate(Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
		}

		if (Input.GetButtonDown ("Jump") && g && !jumped) {
			rigidbody2D.AddForce(transform.up * force);
			jumpTime = jumpDelay;
			animator.SetTrigger("jump");
			AudioSource.PlayClipAtPoint (collect, transform.position);
			jumped = true;
				}

		jumpTime -= Time.deltaTime;

		if (jumpTime <= 0 && g && jumped) {
			animator.SetTrigger("ground");
			AudioSource.PlayClipAtPoint (collect, transform.position);
			jumped = false;
		}	
	}

	void OnCollisionEnter2D(Collision2D Colisao)
	{
		if(Colisao.gameObject.tag == "Monster")
		{
			animator.SetTrigger("hit");
		}

		if(Colisao.gameObject.tag == "Cen")
		{
			animator.SetBool("atack", true);
			Dano = true;
		}
		else
		{
			animator.SetBool("atack", false);
		}
	}


}
