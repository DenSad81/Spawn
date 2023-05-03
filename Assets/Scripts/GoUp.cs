using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUp : MonoBehaviour
{
    [SerializeField] private float _velosity=11;
    private Transform _transform;

    void Start()
    {
        _transform = this.GetComponent<Transform>();
    }

    void Update()
    {
        var actualPosition = _transform.position;
        actualPosition.y += _velosity * Time.deltaTime;
        _transform.position = actualPosition;
    }
}
