using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverUp : MonoBehaviour
{
    [SerializeField] private float _velosity = 11;


    private void Update()
    {
        var actualPosition = transform.position;
        actualPosition.y += _velosity * Time.deltaTime;
        transform.position = actualPosition;
    }
}
