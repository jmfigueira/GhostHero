function OnCollisionEnter2D(Colisao : Collision2D)
{
	if(Colisao.gameObject.tag == "Player")
	{
		Destroy (gameObject, 2);
	}
}