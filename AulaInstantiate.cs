using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaInstantiate : MonoBehaviour
{
    
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        GameObject copiaCubo = Instantiate(cubo, transform.position, transform.rotation);
        Destroy(copiaCubo.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
