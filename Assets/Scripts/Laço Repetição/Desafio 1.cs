using System.Linq;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    /* errado
    //string palavra = "jogos digitais";

    //char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', ' ', ',', '.'};

    //int consoantes;
     */

    [SerializeField] string texto = "JOGOS digitais";
    [SerializeField] int contadorConsoantes = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* errado
        //for (int i = palavra.Length -1; i >= 0; i--)
        //{
        //    char letra = palavra[i];

        //    if (!vogais.Contains(letra))
        //    {
        //        consoantes++;
        //    }

        //}
        //print(consoantes);
        */

        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(letra)))
            {
                contadorConsoantes++;
            }
        }
        print("O número de consoantes é: " + contadorConsoantes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
