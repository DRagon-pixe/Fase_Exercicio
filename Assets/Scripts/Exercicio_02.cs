using UnityEngine;

public class Exercicio_02 : MonoBehaviour
{

    /*
        2. (Detec��o de power-up) Ao coletar um power-up, o
        personagem aumenta sua velocidade. Se o jogador encontrar um
        power-up, exiba "Power-up Coletado". Caso contr�rio, exiba
        "Nenhum power-up encontrado".
     */

    //int velocidadeJogador = 10;
    //int Power_Up = 1;
    //string Pegou = "Power-up Coletado";
    //string n�oPegou = "Nenhum power-up encontrado";

    [SerializeField] bool powerUp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if (Power_Up == 1)
        //{
        //    print(Pegou);
        //    velocidadeJogador += 1;
        //}
        //else
        //{
        //    print(n�oPegou);
        //}

        //if (powerUp == true)
        //{
        //    print("Power-Up Coletado!");
        //}
        //else
        //{
        //    print("Nenhum power-Update encontrado!");
        //}

        print(powerUp ? "Power-up Coletado!" : "Nenhum power-Update encontrado!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
