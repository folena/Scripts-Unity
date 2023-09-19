using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string nome;
    int vida;
    int velocidade;
    int forcaPulo;

    private void Start()
    {
        DefinirNome();
    }
    
    void Attack()
    {
        Debug.Log("Olá Mundo!");
    }

    string DefinirNome()
    {
        nome = "Player 1";
        return nome;
    }
}
