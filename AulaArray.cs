using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaArray : MonoBehaviour
{
    public string[] Meusinimigos = new string[] {"Orc", "Elfo", "Anao"};

    public GameObject[] inimigos;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Meusinimigos[2]); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
