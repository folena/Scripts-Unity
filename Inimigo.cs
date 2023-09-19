using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo: MonoBehaviour
{
    //var est�tica � compartilhada com todas as inst�ncias da classe
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

    //Um m�todo est�tico pode ser chamado de outra classe sem objeto
    public static int Adicionar(int num1, int num2)
    {
        return num1 + num2;
    }
}
