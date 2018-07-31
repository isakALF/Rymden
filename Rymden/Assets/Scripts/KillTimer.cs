using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTimer : MonoBehaviour {

    void Start()
    {
        Invoke("DestroyMyObject", 0.5f);
    }

    void DestroyMyObject()
    {
        Destroy(gameObject);
    }
}
