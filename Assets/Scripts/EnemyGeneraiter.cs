using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyGeneraiter : MonoBehaviour
{
    [SerializeField] private GameObject _template;

    public UnityEvent EventSpawnOneCopy = new UnityEvent();

    private void Start()
    {
        EventSpawnOneCopy.AddListener(Spawn);
    }

    private void Spawn()
    {
        GameObject newGameObject = Instantiate(_template, transform.position, Quaternion.identity);
    }

}
