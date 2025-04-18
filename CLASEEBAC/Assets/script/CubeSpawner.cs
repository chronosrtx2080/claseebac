using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDecubos;
    public float factoriDeEscalamiento;
    public int numCubos = 0;
    // Start is called before the first frame update
    void Start()
    {
        listaDecubos = new List<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value,Random.value,Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listaDecubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDecubos) 
        {
            float escala = go.transform.lossyScale.x;
            escala *= factoriDeEscalamiento;
            go.transform.localScale = Vector3.one*escala;

            if (escala <= 0.1) 
            {
                objetosParaEliminar.Add(go);
            }

        }
        foreach (GameObject go in objetosParaEliminar) 
        {
            listaDecubos.Remove(go);
            Destroy(go);
        }
    }
}
