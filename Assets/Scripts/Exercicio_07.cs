using UnityEngine;

/*
    7. (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    calcular probabilidades e simular a rolagem de dados. Crie um
    script em que o usu�rio defina o n�mero de faces de um dado
    (int) e calcule a rolagem de um dado com esse n�mero de faces.
    Use a fun��o abaixo para o c�lculo: Random.Range (valor_min,
    valor_max); (Coloque o c�digo dentro da fun��o-evento Start).
*/

public class Exercicio_07 : MonoBehaviour
{

    [SerializeField] int numeroFaces = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(Random.Range(4, numeroFaces));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
