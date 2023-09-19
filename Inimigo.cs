using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo: MonoBehaviour
{
    //var estática é compartilhada com todas as instâncias da classe
    public static int contadorInimigos = 0;

    public int Vida;

    public static Inimigo meuInimigo;

    void Start()
    {
        meuInimigo = this;
    }
    
    public Inimigo()
    {
        contadorInimigos++;
    }

    //Um método estático pode ser chamado de outra classe sem objeto
    public static int Adicionar(int num1, int num2)
    {
        return num1 + num2;
    }
}
