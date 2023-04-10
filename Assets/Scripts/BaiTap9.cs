using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap9 : MonoBehaviour
{
    Vector3 pos1 = Vector3.zero;
    Vector3 pos2 = new Vector3(2, 2, 2);

    [SerializeField] private Vector3 dir;
    private Vector3 target;
    private bool isStop = false;

    private void Start()
    {
        transform.position = pos1;
        dir = (pos2 - pos1).normalized;
    }

    private void Update()
    {
        if (isStop) return;

        transform.Translate(dir * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) <= 0.05f)
        {
            isStop = true;
            Invoke(nameof(ResetIsStop), Random.Range(1f, 2f));

            if (target == pos1)
            {
                target = pos2;
                dir = (pos2 - pos1).normalized;
            }
            else
            {
                target = pos1;
                dir = (pos1 - pos2).normalized;
            }
        }
    }

    private void ResetIsStop()
    {
        isStop = false;
    }


}
