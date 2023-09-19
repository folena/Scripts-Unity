using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Inimigo inimigo1 = new Inimigo();
        //Inimigo inimigo2 = new Inimigo();
        //Inimigo inimigo3 = new Inimigo();

        Debug.Log(Inimigo.meuInimigo.Vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
