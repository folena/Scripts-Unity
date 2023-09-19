using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaList : MonoBehaviour
{
    public List<string> tiposInimigos = new List<string>();
    
    // Start is called before the first frame update
    void Start()
    {
        tiposInimigos.Add("Orc");
        tiposInimigos.Add("Elfo");
        tiposInimigos.Add("Anao");

        tiposInimigos.Insert(0, "lobos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
