using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    //4. (Pontua��o em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontua��o total ap�s 7 combos.

    int pontos = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int combos = 0; combos <= 7; combos++)
        {
            if (combos <= 7)
            {
                print(pontos);
                pontos += 10;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
