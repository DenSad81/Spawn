using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject Template;
    public UnityEvent EventSpawn = new UnityEvent();
    private Vector3 _startPosition;

    private void Start()
    {
        EventSpawn.AddListener(Shooting);

        _startPosition = this.gameObject.GetComponent<Transform>().position;
       // _startPosition.y += 2;
    }

    private void Shooting()
    {
        GameObject newGameObject = Instantiate(Template, _startPosition, Quaternion.identity);
    }

}
