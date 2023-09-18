using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class Hero : MonoBehaviour
{
    [SerializeField] private Vector2 _startPosition;
    [SerializeField] private Vector2 _endPosition;

    private SpriteRenderer _spriteRenderer;
    private float _speed = 5;
    private bool _isTurned;
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _isTurned = _spriteRenderer.flipX;
        transform.position = _startPosition;
        transform.DOMoveX(_endPosition.x, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<TurnPoint>(out TurnPoint turnPoint))
        {
            if (_isTurned)
                _isTurned = false;
            else
                _isTurned = true;

            _spriteRenderer.flipX = _isTurned;
        }
    }
}
