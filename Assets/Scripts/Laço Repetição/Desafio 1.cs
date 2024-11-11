using System.Linq;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    string palavra = "Souleater";

    char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    int consoantes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = palavra.Length -1; i >= 0; i--)
        {
            char letra = palavra[i];

            if (!vogais.Contains(letra)) {
                consoantes++;
            }

        }
                print(consoantes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
