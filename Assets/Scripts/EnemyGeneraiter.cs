using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyGeneraiter : MonoBehaviour
{
    [SerializeField] private GameObject _creature;

    public UnityEvent EventSpawnOneCopy = new UnityEvent();

    private void Start()
    {
        EventSpawnOneCopy.AddListener(Spawn);
    }

    private void Spawn()
    {
        GameObject newGameObjectCreature = Instantiate(_creature, transform.position, Quaternion.identity);
    }

}
