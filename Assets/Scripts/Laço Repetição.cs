using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LaçoRepetição : MonoBehaviour
{
    //for -> É utilizado quando se sabe a qtd. de repetições

    //While ou DoWhile -> É utilizado quando não se sabe a qtd. de repetições

    //Foreach -> Quando se tem uma lista que para cada elemento quero fazer alguma operação //// 
    //Usado em lista ou arrays, para executar uma operação para cada item da lista

    //Array -> É uma lista

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //int x = 0; //While
    //int y = 10; //DoWhile

    //-------------------------------------------------

    //Criando uma Lista de Inteiros chamada 'nums'
    //List<int> nums = new List<int>();

    void Start()
    {
        //for(inicializador; condição; incremento/decremento)
        //    for (int variavel = 0; variavel <= 10; variavel++)
        //    {
        //        if(variavel == 5)
        //    {
        //        break;
        //    }

        //    if (variavel == 6)
        //        {
        //            continue;
        //        }
        //        print(variavel);
        //    }

        //while (x <= 10)
        //{
        //    print(x);
        //    x++;
        //}

        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        //-------------------------------------------------

        //int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        //print(num[3]);
        //num[0]++;

        //print(num[0]);

        //string[] nomes;

        //nomes = new string[5];
        //nomes[0] = "Trembolona";

        //print(nomes[1]);

        //foreach (var item in num)
        //{
        //    print(item);
        //}

        //-------------------------------------------------

        //Adiciona elemntos á lista de nums
        //nums.Add(1); //Indice 0
        //nums.Add(2); //Indice 1
        //nums.Add(3); //Indice 2
        //nums.Add(4); //Indice 3
        //nums.Add(4); //Indice 4
        //nums.Add(5); //Indice 5
        //nums.Add(6); //Indice 6
        //nums.Add(7); //Indice 7
        //nums.Add(8); //Indice 8
        //nums.Add(49);

        //Remove o primeiro valor '4' encontrado na lista (Indice 3)
        //nums.Remove(4);

        //Ordena os elementos da lista em ordem crescente
        //nums.Sort();

        //nums.Reverse();

        //print(nums.IndexOf(49));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
