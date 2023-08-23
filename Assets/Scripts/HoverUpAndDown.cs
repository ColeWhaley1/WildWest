using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverUpAndDown : MonoBehaviour
{
    public float amplitude = .1f;
    public float frequency = 1f;
    Vector3 posOrigin = new Vector3();
    Vector3 tempPos = new Vector3();
    
    void Start()
    {
        posOrigin = transform.position;
    }
    void Update()
    {
        tempPos = posOrigin;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }
}
