using UnityEngine;

/*
    10. (Itens do inventário) Crie um script onde o jogador pode coletar
    diferentes tipos de itens (como moedas, poções, ou power-ups)
    que têm efeitos diferentes dependendo do tipo coletado. Use um
    switch case para determinar o efeito de cada tipo de item.
*/

public class Exercicio_10 : MonoBehaviour
{

    [SerializeField] int inventario = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (inventario)
        {
            case 1:
                print("moedas");
                print("Podem ser usadas para compras 'coisas'");
                break;
            case 2:
                print("poções");
                print("Aplicam efeitos diversos");
                break;
            case 3:
                print("Power-ups");
                print("Podem ser usados para se fortalecer");
                break;
            default:
                print("Item inexistente");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
