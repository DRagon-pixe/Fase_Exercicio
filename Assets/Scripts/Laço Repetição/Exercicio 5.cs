using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    //5. (Aumento de n�vel de dificuldade) A cada fase completada, a
    //dificuldade aumenta em 5 pontos.Exiba a dificuldade ap�s cada
    //fase, em um total de 6 fases.

    int dificuldade = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int fase = 0; fase <= 6;  fase++)
        {
            if (fase <= 6)
            {
                print("A dificuldade subiu! Nova dificuldade � " + dificuldade);
                dificuldade += 5;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
