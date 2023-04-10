using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap8 : MonoBehaviour
{
    [SerializeField] Vector3 pos1 = Vector3.zero;
    [SerializeField] Vector3 pos2 = new Vector3(2, 2, 2);
    [SerializeField] private float time;

    private Vector3 dir;
    private Vector3 target;

    private float speed;
    private float t1;

    private void Start()
    {
        transform.position = pos1;
        speed = (pos2 - pos1).magnitude / time;
        dir = (pos2 - pos1).normalized;
        t1 = 0f;
    }

    private void Update()
    {
        t1 += Time.deltaTime;

        transform.Translate(dir * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) <= 0.05f)
        {
            Debug.Log(t1);
            t1 = 0;

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
}
