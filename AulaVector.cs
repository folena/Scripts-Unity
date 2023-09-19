using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaVector : MonoBehaviour
{

    public Vector2 pos;
    public Vector3 pos2;
    // Start is called before the first frame update
    void Start()
    {
        pos2 = new Vector3(1f, 1f, 1f);
        pos2.z = 10f;

        transform.position = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
