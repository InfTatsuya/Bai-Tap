using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap4 : MonoBehaviour
{
    [SerializeField] Vector3 pos1;
    [SerializeField] Vector3 pos2;

    Vector3 start;
    Vector3 target;
    float progress;

    private void Start()
    {
        transform.position = pos1;
        start = pos1;
        target = pos2;
        progress = 0f;
    }

    private void Update()
    {
        progress += Time.deltaTime;

        transform.position = Vector3.Lerp(start, target, progress);

        if (progress >= 1f)
        {
            progress = 0f;
            ChangeTarget();
        }
    }

    private void ChangeTarget()
    {
        start = target;

        if(target == pos1)
        {          
            target = pos2;
        }
        else
        {
            target = pos1;
        }
    }
}
