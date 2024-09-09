using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("algo paso");
        Debug.LogWarning("algo salio medianamente mal");
        Debug.LogError("algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);
        Debug.Log("hola desde update");


    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola desde fixedUpdate cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("hola desde late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("el objeto a sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("El objeto a sido inhabilitado");
    }
}
