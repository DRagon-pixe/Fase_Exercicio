using NUnit.Framework;
using System;
using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    //6. (Fizz Buzz) Para cada n�mero entre 0 e 10000, escreva apenas
    //�fizz� no console quando for divis�vel por 3, �buzz� quando for
    //divis�vel por 5 e �fizz buzz� quando for divis�vel pelos dois.Se o
    //n�mero n�o for divis�vel por nenhum deles, escreva-o no console.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int nums = 0; nums <= 10000; nums++)
        {
            if (nums % 3 == 0 && nums % 5 == 0)
            {
                print("fizz buzz");
            } else if (nums % 3 == 0)
            {
                print("fizz");
            } else if (nums % 5 == 0)
            {
                print("buzz");
            }else
            {
                print(nums);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
