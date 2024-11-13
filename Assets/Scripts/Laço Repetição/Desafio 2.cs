using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Desafio02 : MonoBehaviour
{
    //Fa�a um algoritmo que receba o dia, o m�s e o ano em que uma pessoa nasceu, imprima na tela quantos anos,
    //meses e dias essa pessoa j� viveu.Leve em considera��o o ano com 365 dias e o m�s com 30 dias.

    //[SerializeField] int dia;
    //[SerializeField] int mes;
    //[SerializeField] int ano; 
    
    [SerializeField] int diaNascimento;
    [SerializeField] int mesNascimento;
    [SerializeField] int anoNascimento;

    void Start()
    {
        //DateTime dataAtual = DateTime.Now;
        //int diaAtual = dataAtual.Day;
        //int mesAtual = dataAtual.Month;
        //int anoAtual = dataAtual.Year;

        //int anosVividos = (anoAtual - ano);
        //int mesesVividos = (mesAtual - mes);
        //int diasVividos = (dia - diaAtual);

        //print("Voc� viveu um total de : " + anosVividos + " Anos" + "\n: " + mesesVividos + " meses" + "\n: " + diasVividos + " dias");

        ////Data atual
        int diaAtual = DateTime.Now.Day;
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        ////Calcular ano vividos
        //int anosVividos = anoAtual - anoNascimento;

        ////Calcular meses vividos
        //int mesesVividos = mesAtual - mesNascimento;

        //if (mesesVividos < 0)
        //{
        //    anosVividos--;
        //    mesesVividos += 12;
        //}

        ////Calcular dias vividos
        //int diasVividos = diaAtual - diaNascimento;

        //if(diasVividos < 0)
        //{
        //    mesesVividos--;
        //    diasVividos += 30;

        //    if(mesesVividos < 0)
        //    {
        //        anosVividos--;
        //        //mesesVividos = mesesVividos + 12;
        //        mesesVividos += 12;
        //    }
        //}

        //print("Voc� viveu: " + diasVividos + " dias, " + mesesVividos + " meses, " + anosVividos + " anos.");

        int totalDiasVividos = (anoAtual - anoNascimento) * 365 + (mesAtual - mesNascimento) * 30 + (diaAtual - diaNascimento);

        //Converte para anos, meses e dias restantes
        int anosVividos = totalDiasVividos / 365;
        int mesesVividos = (totalDiasVividos % 365) / 30;
        int diasVividos = (totalDiasVividos % 365) % 30;
        print("Voc� viveu: " + diasVividos + " dias, " + mesesVividos + " meses, " + anosVividos + " anos.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
