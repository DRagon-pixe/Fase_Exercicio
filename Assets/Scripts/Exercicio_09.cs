using UnityEngine;

/*
    9. (Placar final) Crie um script que l� o placar de uma partida entre
    time A e time B. Depois, escreva no console qual dos tr�s
    resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
    ou empate. Se o empate teve mais de 3 pontos para cada lado,
    escreva que foi �um empate emocionante�.
 */

public class Exercicio_09 : MonoBehaviour
{

    [SerializeField] int timeA = 10;
    [SerializeField] int timeB = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timeA > timeB)
        {
            print("vit�ria do time A");
        }
        else if (timeA < timeB)
        {
            print("vit�ria do time B");
        }
        else if (timeA == timeB)
        {
            print("empate");
        }
        else if(timeA > 3 && timeB > 3 && timeA == timeB)
        {
            print("um empate emocionante");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
