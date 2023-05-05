using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawnerChainger : MonoBehaviour
{
    [SerializeField] private EnemySpawner[] _spawners;

    private int _quantitySpawners;

    private void Start()
    {
        _spawners = GetComponentsInChildren<EnemySpawner>();
        _quantitySpawners = _spawners.Length;
        var corutineChangeSpawner = StartCoroutine(ChangeSpawner(_quantitySpawners));
    }

    private IEnumerator ChangeSpawner(int quantitySpawners)
    {
        while (true)
        {
            int spawnerNomber = Random.Range(0, quantitySpawners);
            _spawners[spawnerNomber].Spawn();

            yield return new WaitForSeconds(1);
        }
    }
}
