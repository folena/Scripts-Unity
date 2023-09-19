using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaForeach : MonoBehaviour
{
    public string[] nomesNPC = new string[3];
    public List<string> nomesInimigos = new List<string>();
    
    // Start is called before the first frame update
    void Start()
    {
        //Array
        nomesNPC[0] = "Mark";
        nomesNPC[1] = "Clark";
        nomesNPC[2] = "Lark";

        //Lista
        nomesInimigos.Add("Duracell");
        nomesInimigos.Add("Carlos");
        nomesInimigos.Add("Peter EiNerd");

        //Tipo de item da coleção in cole��o
        foreach (string elemento in nomesNPC)
        {
            Debug.Log(elemento);
        }

        for (int i = 0; i < nomesInimigos.Count; i++)
        {
                Debug.Log(nomesInimigos[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
