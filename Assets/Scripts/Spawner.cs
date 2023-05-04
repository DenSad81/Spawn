using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;

    private Vector3 _startPosition;

    public UnityEvent EventSpawnOneCopy = new UnityEvent();

    private void Start()
    {
        EventSpawnOneCopy.AddListener(Spawn);
        _startPosition = GetComponent<Transform>().position;
    }

    private void Spawn()
    {
        GameObject newGameObject = Instantiate(_template, _startPosition, Quaternion.identity);
    }

}
