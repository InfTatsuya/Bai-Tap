using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap5 : MonoBehaviour
{
    [SerializeField] Vector3 pos1 = Vector3.zero;
    [SerializeField] Vector3 pos2 = new Vector3(10, 10, 10);

    private Vector3 start;
    private Vector3 target;

    private float progress;

    private void Start()
    {
        transform.position = pos1;
        start = pos1;
        target = pos2;
    }

    private void Update()
    {
        progress += Time.deltaTime;

        transform.position = Vector3.Lerp(start, target, progress);

        if (progress >= 1f)
        {
            progress = 0f;

            start = target;
            if (target == pos1)
            {
                target = pos2;
            }
            else
            {
                target = pos1;
            }
        }
    }
}
