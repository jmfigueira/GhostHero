using UnityEngine;
using System.Collections;

public class CONTADOR : MonoBehaviour {
	public static int pontos;
	public GUIText pontostext;
	// Use this for initialization
	void Start () {
		pontos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		pontostext.text = "Moedas:" + pontos;
	}
}
