using UnityEngine;

/*
    5. (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
    recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
    exiba "c"; caso contr�rio, "Miss�o incompleta".
*/

public class Exercicio_05 : MonoBehaviour
{

    [SerializeField] int pontos = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(pontos >= 50)
        {
            print("Miss�o bem-sucedida");
        }
        else
        {
            print("Miss�o incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
