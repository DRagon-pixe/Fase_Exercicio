using System.Collections.Generic;
using System;
using System.Drawing;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio7 : MonoBehaviour
{
    //7. (Maior número em uma lista) Dada uma lista de números,
    //encontre o maior valor.

        List<int> nums = new List<int>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nums.Add(0);
        nums.Add(37);
        nums.Add(5);
        nums.Add(12);
        nums.Add(21);
        nums.Add(90);
        nums.Add(59);
        nums.Add(62);
        nums.Add(18);
        nums.Add(7);
        nums.Add(67);

        nums.Sort();
        print(nums[10]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
