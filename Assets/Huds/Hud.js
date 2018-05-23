var HUD : Texture2D;
var Coracao : Texture2D;
var collect : AudioClip;
var CoracaoCont : int;

function Start () 
{
	CoracaoCont = 3;
}

function Update () 
{
	if(CoracaoCont > 3)
	{
		CoracaoCont = 3;
	}
	if(CoracaoCont < 0)
	{
		CoracaoCont = 0;
	}
	
}

function OnCollisionEnter2D(Colisao : Collision2D)
{
	if(Colisao.gameObject.tag == "Coracao")
	{
		CoracaoCont = CoracaoCont + 1;
	}
	if(Colisao.gameObject.tag == "Monster")
	{
		CoracaoCont = CoracaoCont - 1;
		AudioSource.PlayClipAtPoint (collect, transform.position);
	}
}

function OnGUI()
{
	GUI.DrawTexture(Rect(Screen.width * (0.005), Screen.height * (0.005), Screen.width * (0.2), Screen.height * (0.18)), HUD);
	if(CoracaoCont == 0)
	{
		Destroy (gameObject);
		//chamar cena de game over no lugar de destroy
	}
	if(CoracaoCont == 1)
	{
	GUI.DrawTexture(Rect(Screen.width * (0.0915), Screen.height * (0.109), Screen.width * (0.033), Screen.height * (0.045)), Coracao);
	}
	if(CoracaoCont == 2)
	{
	GUI.DrawTexture(Rect(Screen.width * (0.0915), Screen.height * (0.109), Screen.width * (0.033), Screen.height * (0.045)), Coracao);
	GUI.DrawTexture(Rect(Screen.width * (0.120), Screen.height * (0.109), Screen.width * (0.033), Screen.height * (0.045)), Coracao);
	}
	if(CoracaoCont == 3)
	{
	GUI.DrawTexture(Rect(Screen.width * (0.0915), Screen.height * (0.109), Screen.width * (0.033), Screen.height * (0.045)), Coracao);
	GUI.DrawTexture(Rect(Screen.width * (0.120), Screen.height * (0.109), Screen.width * (0.033), Screen.height * (0.045)), Coracao);
	GUI.DrawTexture(Rect(Screen.width * (0.15), Screen.height * (0.109), Screen.width * (0.033), Screen.height * (0.045)), Coracao);
	}
}


