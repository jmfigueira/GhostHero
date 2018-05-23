var collect : AudioClip;

function OnCollisionEnter2D(Colisao : Collision2D)
{

	if(Colisao.gameObject.tag == "Player")
	{
		AudioSource.PlayClipAtPoint (collect, transform.position);
		Destroy (gameObject);
	}
}