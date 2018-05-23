var Personagem : Transform;
var PertoPlayer :  boolean;
var VelocidadeInimigo : float;
var Projetil : GameObject;
var Forca : float;
var SaidaProjetil : GameObject;
var TempoLancar : int;
var collect : AudioClip;
var collect2 : AudioClip;
var Animacao : Animator;
static var Vida : int;
var Vivo : boolean;
var objeto : GameObject;

function Start () 
{
	VelocidadeInimigo = 1.5;
	Forca = 500;
	Vida = 100;
	TempoLancar = 10;
	Vivo = true;
}

function Update () {

	if(Vivo == true)
	{
	if(PertoPlayer == true)
	{
		if(Personagem.transform.position.x < transform.position.x)
		{
			transform.rigidbody2D.velocity.x = -VelocidadeInimigo;
			transform.rotation.y = 0;
		}
		
		if(Personagem.transform.position.x > transform.position.x)
		{
			transform.rigidbody2D.velocity.x = VelocidadeInimigo;
			transform.rotation.y = 180;
		}
		
		TempoLancar += TempoLancar * 0.1;
		
		if(TempoLancar >= 1000)
		{
			TempoLancar = 1000;
		}
		if(TempoLancar == 1000)
		{
			DestuirFumaca ();
			Animacao.SetBool("InimigoAtack", true);
			AudioSource.PlayClipAtPoint (collect2, transform.position);
			var Projetil = Instantiate(Projetil, SaidaProjetil.transform.position, transform.rotation);
			Projetil.rigidbody2D.AddForce(-Projetil.transform.right * Forca);
			TempoLancar = 10;
		}
		else{
					DestuirFumaca ();
					Animacao.SetBool("InimigoAtack", false);
		}
		
	}
	
	if(Vector2.Distance(transform.position, Personagem.position) < 20)
	{
		PertoPlayer = true;
	}
	else
	{
		PertoPlayer = false;
	}
	}
	else
	{
				Animacao.SetBool("InimigoDano", true);
				Instantiate(objeto, transform.position,objeto.transform.rotation); 
				Destroy(gameObject);
	}
	if(Vida <= 0)
	{
		Vida = 0;
		Vivo = false;
	}
}


function OnCollisionEnter2D (Colisao : Collision2D)
{
	if(Colisao.gameObject.tag == "Player")
	{
		Dano();
		Vida = Vida - 10;
	}
}

function DestuirFumaca()
{
	yield WaitForSeconds(0.3);
}

function Dano()
{
	Animacao.SetBool("InimigoDano", true);
	AudioSource.PlayClipAtPoint (collect, transform.position);
	yield WaitForSeconds(0.2);
	Animacao.SetBool("InimigoDano", false);
}

