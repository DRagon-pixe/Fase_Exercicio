using UnityEngine;

/*
    6. (Escolha de personagem) O jogador pode escolher entre o
    personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
    jogador selecionar Guerreiro e "Mago escolhido" se selecionarMago.
*/

public class Exercicio_06 : MonoBehaviour
{

    [SerializeField] bool opcoes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(opcoes == true)
        {
            print("Guerreiro escolhido");
        }
        else
        {
            print("Mago escolhido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
