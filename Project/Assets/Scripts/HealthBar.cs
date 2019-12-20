using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthBar : MonoBehaviour
{

    public static Transform bar;
    public static float HealthLong = 3f;

    private void Awake()
    {
        HealthLong = 3f;

        bar = gameObject.GetComponent<Transform>();

        bar.localScale = new Vector3(3, 0.4f, 1);


    }




}
