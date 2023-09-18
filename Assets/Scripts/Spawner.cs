using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Hero _target;

    private int _countEnemies;
    private float _maxCountEnemies = 6;
    private Coroutine _spawnCoroutine;

    private void Start()
    {
        _spawnCoroutine = StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        var spawnTime = new WaitForSeconds(2f);

        while (_countEnemies < _maxCountEnemies)
        {
            _enemy = Instantiate(_enemy, transform.position, Quaternion.identity).GetComponent<Enemy>();
            _enemy.Init(_target);
            _countEnemies++;
            yield return spawnTime;
        }

        StopCoroutine(_spawnCoroutine);
    }
}
