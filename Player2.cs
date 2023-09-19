using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public class Arma
    {
        public string Nome;
        public string Tipo;

        //Construtor da classe
        public Arma(string armaNome, string armaTipo)
        {
            Nome = armaNome;
            Tipo = armaTipo;
        }

        public string getNome()
        {
            return Nome;
        }

        public string setNome(string SNome)
        {
            return Nome = SNome;
        }
    }

    int Vida;
    int Velocidade;

    Arma espada;

    void Attack()
    {

    }

    void Jump()
    {

    }

    void Start()
    {
        espada = new Arma("Minha Espada", "Espada");
        Debug.Log(espada.getNome());

        espada.setNome("Severino");
        Debug.Log(espada.getNome());
    }

}
