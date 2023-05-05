using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private /*GameObject*/MoverUp _creature;

    public void Spawn()
    {
        /*GameObject*/ MoverUp newGameObjectCreature = Instantiate(_creature, transform.position, Quaternion.identity);
    }
}
