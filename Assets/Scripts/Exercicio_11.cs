using UnityEngine;

/*
    11. (Diálogos) Implemente um sistema de diálogos onde o jogador
    pode interagir com um NPC (personagem não jogável), e o NPC
    responde com diferentes frases dependendo do estado do jogo.
    Use switch case para definir as respostas baseadas no estado do jogador.
*/


public class Exercicio_11 : MonoBehaviour
{

    [SerializeField] int estadoConversa = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch(estadoConversa)
        {
            case 1:
                print("Bom dia!");
                break;
            case 2:
                print("Sim, claro! Do que precisa?");
                break;
            case 3:
                print("Boa tarde!");
                break;
            case 4:
                print("Boa noite!");
                break;
            case 5:
                print("Estou ótimo, e você?");
                break;
            case 6:
                print("Como posso te ajudar?");
                break;
            default:
                print("Não estou entendo");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
