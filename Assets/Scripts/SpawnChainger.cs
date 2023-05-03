using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChainger : MonoBehaviour
{
    [SerializeField] private Spawn[] _Spawners;
    [SerializeField] private float _actualTime = 0;

    private float _thresholdTime = 0;
    private float _deltaTime = 2f;

    private void Start()
    {
        _Spawners = gameObject.GetComponentsInChildren<Spawn>();
    }

    private void Update()
    {
        _actualTime += Time.deltaTime;

        if (_actualTime > _thresholdTime)
        {
            int nomberOfSpoun = Random.Range(0, _Spawners.Length);

            _Spawners[nomberOfSpoun].EventSpawn.Invoke();

            _thresholdTime += _deltaTime;
        }
    }
}
