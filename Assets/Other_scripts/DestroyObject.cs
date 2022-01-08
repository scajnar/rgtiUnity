using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyMyObject", 30);
    }

    void DestroyMyObject()
    {
        Destroy(gameObject);
    }
}
