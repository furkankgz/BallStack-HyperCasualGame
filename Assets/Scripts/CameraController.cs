using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;
    [SerializeField] private float _lerpValue;

    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - _ballTransform.position;        
    }

    void LateUpdate()
    {
        Vector3 _newPos = Vector3.Lerp( transform.position, _ballTransform.position + _offset, Time.deltaTime );
        transform.position = _newPos;
    }
}
