using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap3 : MonoBehaviour
{
    [SerializeField] Vector3 pos1;
    [SerializeField] Vector3 pos2;
    [SerializeField] Vector3 pos3;

    Vector3 start;
    Vector3 target;

    private void Start()
    {
        transform.position = pos1;
        start = pos1;
        target = pos2;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.2f);

        if(Vector3.Distance(transform.position, target) <= 0.05f)
        {
            ChangeTarget();
        }
    }

    private void ChangeTarget()
    {
        if(target == pos1)
        {
            target = pos2;
            start = pos1;
        }
        else if(target == pos2)
        {
            target = pos3;
            start = pos2;
        }
        else
        {
            target = pos1;
            start = pos3;
        }
    }
}
