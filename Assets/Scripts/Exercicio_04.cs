using UnityEngine;

/*
    4. (Verificar item de invent�rio) Um jogador possui itens limitados
    no invent�rio. Verifique se o jogador possui uma "Po��o de Vida".
    Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
    indispon�vel".
 */

public class Exercicio_04 : MonoBehaviour
{

    [SerializeField] bool pocao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(pocao == true)
        {
            print("Usando Po��o de Vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
