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

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        print(num[3]);
        num[0]++;

        print(num[0]);

        string[] nomes;

        nomes = new string[5];
        nomes[0] = "Trembolona";

        print(nomes[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
