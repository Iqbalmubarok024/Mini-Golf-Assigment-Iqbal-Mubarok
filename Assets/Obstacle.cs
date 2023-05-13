using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] List<Transform> positions;

    int index;

    private void Start()
    {
        
    }

    private void Move()
    {
        var pos = positions[index];
        this.transform.DOMove(pos.positions,1);
    }
}
