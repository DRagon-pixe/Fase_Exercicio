using UnityEngine;

public class Exercicio_01 : MonoBehaviour
{

    /*
     Exercicio 01: (Verifica��o de pontos de vida) Um personagem perde pontos de vida ap�s uma batalha. 
     Verifique se ele ainda est� vivo. 
    Caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contr�rio, "Game over"
     */

    [SerializeField] int vidaJogador = 100;
    //string resposta = "Personagem Vivo";
    //string Resposta = "Game over";
    string Resultado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if( vidaJogador > 0)
        //{
        //    print(resposta);
        //}
        //else
        //{
        //    print(Resposta);
        //}
        Resultado = (vidaJogador > 0) ? "Personagem Vivo" : "Game over";
        print(Resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
