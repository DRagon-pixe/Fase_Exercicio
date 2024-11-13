using System.Collections.Generic;
using System;
using System.Drawing;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio7 : MonoBehaviour
{
    //7. (Maior número em uma lista) Dada uma lista de números,
    //encontre o maior valor.

    //List<int> nums = new List<int>();

    int[] numeros = { 3, 5, 7, 10, 68, 23, 71, 18, 19 };
    int maior = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //nums.Add(0);
        //nums.Add(37);
        //nums.Add(5);
        //nums.Add(12);
        //nums.Add(21);
        //nums.Add(90);
        //nums.Add(59);
        //nums.Add(62);
        //nums.Add(18);
        //nums.Add(7);
        //nums.Add(67);
        //nums.Add(134);

        //nums.Sort();
        //print(nums[11]);

        maior = numeros[0];

        foreach (var item in numeros)
        {
            if (item > maior)
            {
                maior = item;
            }
        }
        print("O maior número é: " + maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
