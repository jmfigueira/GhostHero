var BarraVida : Transform;

function Start () {


}

function Update () 
{
	if(Boss.Vida == 0)
	{
		BarraVida.localScale.x = 4;
	}
	if(Boss.Vida == 10)
	{
		BarraVida.localScale.x = 3.8;
	}
	if(Boss.Vida == 20)
	{
		BarraVida.localScale.x = 3.4;
	}
	if(Boss.Vida == 30)
	{
		BarraVida.localScale.x = 2.8;
	}
	if(Boss.Vida == 40)
	{
		BarraVida.localScale.x = 2.4;
	}
	if(Boss.Vida == 50)
	{
		BarraVida.localScale.x = 1.8;
	}
	if(Boss.Vida == 60)
	{
		BarraVida.localScale.x = 1.4;
	}
	if(Boss.Vida == 70)
	{
		BarraVida.localScale.x = 1;
	}
	if(Boss.Vida == 80)
	{
		BarraVida.localScale.x = 0.8;
	}
	if(Boss.Vida == 90)
	{
		BarraVida.localScale.x = 0.4;
	}
	if(Boss.Vida == 100)
	{
		BarraVida.localScale.x = 0;
	}
	
}