using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{
    public List<Material> myMaterials;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Sphere");
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (GameObject obj in objects)
            {
                obj.GetComponent<Renderer>().material = myMaterials[Random.Range(0, myMaterials.Count)];
            }       
        }
    }
}
