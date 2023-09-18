using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


[RequireComponent(typeof(SpriteRenderer))]
public class Hero : MonoBehaviour
{
    [SerializeField] private Vector2 _startPosition;
    [SerializeField] private Vector2 _endPosition;

    private float _speed = 5;

    private void Start()
    {
        transform.position = _startPosition;
        transform.DOMoveX(_endPosition.x, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
