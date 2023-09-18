using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    private Hero _target;
    private float _speed;

    public void Init(Hero target)
    {
        _target = target;
        _speed = 1;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target.transform.position,_speed * Time.deltaTime);
    }
}
