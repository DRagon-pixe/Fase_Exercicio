using UnityEngine;

/*
    4. (Verificar item de inventário) Um jogador possui itens limitados
    no inventário. Verifique se o jogador possui uma "Poção de Vida".
    Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    indisponível".
 */

public class Exercicio_04 : MonoBehaviour
{

    [SerializeField] bool pocao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(pocao == true)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
