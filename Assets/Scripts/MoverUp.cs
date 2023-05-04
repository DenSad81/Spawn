using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverUp : MonoBehaviour
{
    [SerializeField] private float _velosity = 11;

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        var actualPosition = _transform.position;
        actualPosition.y += _velosity * Time.deltaTime;
        _transform.position = actualPosition;
    }
}
