using UnityEngine;

public class Exercicio_03 : MonoBehaviour
{
    /*
        Operadores L�gicos

        && (E / AAND)
        || (OU / OR)
        ! (N�O / NOT)
     
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
        //    print("Ainda n�o, vida atual " + vidaPlayer);
        //}
        //else
        //{
        //    print("Game Over");
        //}

        //if(vidaPlayerAtual <= 0 && powerUp == true)
        //{
        //    vidaPlayerAtual = vidaPlayerInicial * 0.5;
        //    print("Ainda n�o, vida atual " + vidaPlayerAtual);
        //}
        //else
        //{
        //    print("Game Over");
        //}


        switch (estadoVilao)
        {
            case 1:
                print("Vil�o atacando");
                if (true)
                {
                    print("Dano");
                }
                break;
            case 2:
                print("Vil�o defendendo");
                break;
            case 3:
                print("Vil�o tomando um coro");
                break;
            default:
                print("Valor n�o identificado");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
