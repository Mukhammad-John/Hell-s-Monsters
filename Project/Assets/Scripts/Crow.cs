using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : MonoBehaviour
{
    [SerializeField]
    private GameObject Crows;
    [SerializeField]
    private Transform CrowsPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CrowSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator CrowSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1.5f, 3.2f));
            Instantiate(Crows, new Vector2(-4.32f, Random.Range(0.35f, 4.2f)), Quaternion.identity);
        }
    }
}
