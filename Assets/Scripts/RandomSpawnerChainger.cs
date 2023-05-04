using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnerChainger : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;

    private float _actualTime = 0;
    private float _thresholdTime = 0;
    private float _deltaTime = 2f;

    private void Start()
    {
        _spawners = GetComponentsInChildren<Spawner>();
    }

    private void Update()
    {
        _actualTime += Time.deltaTime;

        if (_actualTime > _thresholdTime)
        {
            int spawnerNomber = Random.Range(0, _spawners.Length);

            _spawners[spawnerNomber].EventSpawnOneCopy.Invoke();

            _thresholdTime += _deltaTime;
        }
    }
}
