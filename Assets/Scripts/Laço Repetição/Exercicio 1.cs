using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    //1. (Contagem regressiva de tempo) Crie uma contagem
    //regressiva de 5 a 1 e exiba "Início da partida!" ao final.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int var = 5; var <= 5; var--)
        {
            if (var == 0)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
