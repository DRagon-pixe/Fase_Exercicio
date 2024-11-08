using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    //3. (Cálculo de moedas coletadas) O jogador coleta 3 moedas a
    //    cada fase.Após 10 fases, exiba o total de moedas coletadas.

    int moedas = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int fase = 1; fase < 11; fase++)
        {
            if (fase < 11)
            {
                print(moedas);
                moedas += Random.Range(1, 10);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
