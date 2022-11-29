using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PtyFlyRandom : MonoBehaviour
{
    Vector3[] targetPositions;
    public int numTargetPos;
    public float moveDuration;

    // Start is called before the first frame update
    void Start()
    {
        targetPositions = new Vector3[numTargetPos];
        for (int i = 0; i < numTargetPos; i++)
        {
            targetPositions[i] = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
        }
        Sequence s = DOTween.Sequence();
        for( int i = 0; i < targetPositions.Length; i++)
        {
            s.Append(transform.DOMove(targetPositions[i], moveDuration).SetEase(Ease.Linear));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

