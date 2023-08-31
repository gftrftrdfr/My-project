using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Sphere");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(destroy(objects));
        }
    }

    public IEnumerator destroy(GameObject[] objs)
    {
        foreach (GameObject obj in objs)
        {
            yield return new WaitForSeconds(2f);
            Destroy(obj);
        }
    }
} 
