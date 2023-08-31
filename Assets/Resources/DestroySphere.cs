using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour
{
    void OnMouseDown()
    {
        FindObjectOfType<Score>().IncreaseScore();
        Destroy(gameObject);
    }
}
