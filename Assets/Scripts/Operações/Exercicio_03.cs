using UnityEngine;

public class Exercicio_03 : MonoBehaviour
{
    /*
        Operadores Lógicos

        && (E / AAND)
        || (OU / OR)
        ! (NÃO / NOT)
     
     */

    //[SerializeField] bool playerVivo;
    //[SerializeField] bool powerUp;
    ////double vidaPlayer = 100;

    //int vidaPlayerInicial = 100;
    //double vidaPlayerAtual = 100;

        [SerializeField] int estadoVilao = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if(playerVivo == false && powerUp == true)
        //{
        //    vidaPlayer = vidaPlayer * 0.5;
        //    print("Ainda náo, vida atual " + vidaPlayer);
        //}
        //else
        //{
        //    print("Game Over");
        //}

        //if(vidaPlayerAtual <= 0 && powerUp == true)
        //{
        //    vidaPlayerAtual = vidaPlayerInicial * 0.5;
        //    print("Ainda náo, vida atual " + vidaPlayerAtual);
        //}
        //else
        //{
        //    print("Game Over");
        //}


        switch (estadoVilao)
        {
            case 1:
                print("Vilão atacando");
                if (true)
                {
                    print("Dano");
                }
                break;
            case 2:
                print("Vilão defendendo");
                break;
            case 3:
                print("Vilão tomando um coro");
                break;
            default:
                print("Valor não identificado");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
