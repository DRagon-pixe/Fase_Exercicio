using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    //2. (Multiplicação de dano) Um personagem ataca cinco vezes, e o
    //dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //ataque.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int dano = 1; dano < 11; dano += 2)
        {
            if (dano <= 11)
            {
                print(dano);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
