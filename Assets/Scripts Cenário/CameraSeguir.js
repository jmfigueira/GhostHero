var Personagem: Transform;
var ValorSuavizacao = 0.3;
var Velocidade: Vector2;

function Update () 
{
	transform.position.x = Mathf.SmoothDamp(transform.position.x, Personagem.position.x, Velocidade.x, ValorSuavizacao);
	transform.position.y = Mathf.SmoothDamp(transform.position.y, Personagem.position.y, Velocidade.y, ValorSuavizacao);
}