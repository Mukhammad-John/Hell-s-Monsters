using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.GetComponent<MeshRenderer>().sortingOrder = -55;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
