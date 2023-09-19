using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaTranslate : MonoBehaviour
{

    public float velocidade;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3 * Time.deltaTime * velocidade);
        transform.Rotate(0f,0f,5f, Space.Self);
    }
}
