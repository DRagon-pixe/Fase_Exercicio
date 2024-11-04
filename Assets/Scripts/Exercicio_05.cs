using UnityEngine;

/*
    5. (Pontuação de missão) Após completar uma missão, o jogador
    recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
    exiba "c"; caso contrário, "Missão incompleta".
*/

public class Exercicio_05 : MonoBehaviour
{

    [SerializeField] int pontos = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(pontos >= 50)
        {
            print("Missão bem-sucedida");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
