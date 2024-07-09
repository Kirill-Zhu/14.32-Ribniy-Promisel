using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatWaterImpact : MonoBehaviour
{

    [SerializeField] private float _angle = 15;
    [SerializeField] private float _speed;
    public float _timeProgress = 0;
    public float _sinPrpgress = 0;

    private void Update()
    {
        SinMove();
    }
    private void SinMove()
    {
        _timeProgress += Time.deltaTime*_speed;
        _sinPrpgress = Mathf.Sin(_timeProgress);

        var euler = transform.eulerAngles;
        euler.z = _sinPrpgress * _angle;
        transform.eulerAngles = euler;
        


    }
}
