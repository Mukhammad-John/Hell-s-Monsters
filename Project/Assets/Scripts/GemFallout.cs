using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemFallout : MonoBehaviour
{
    private Transform gem;
    private bool Up = true;
    private bool SecondUp = false;

    private void Awake()
    {
        Up = true;
        SecondUp = false;
    }
    void Start()
    {
        gem = gameObject.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpDown();
    }

    void UpDown()
    {
        if (gem.position.y < 1.5f && Up)
        {
            transform.position += new Vector3(0, 6f * Time.deltaTime, 0);
        }

        if (gem.position.y > 1.5 && gem.position.y > 0.5f)
        {
            Up = false;
            
            
        }
        if (!Up && gem.position.y > 0.5f)
        {
            transform.position -= new Vector3(0, 2f * Time.deltaTime, 0);
            SecondUp = true;
        }
        if (SecondUp && gem.position.y < 1.2f)
        {
            transform.position += new Vector3(0, 6f * Time.deltaTime, 0);
        }
    }
}
