using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap7 : MonoBehaviour
{
    [SerializeField] List<Vector3> posList = new List<Vector3>();

    Vector3 start;
    Vector3 target;
    float progress;

    private void Start()
    {
        transform.position = posList[0];
        start = posList[0];
        target = posList[1];
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
        target = posList[Random.Range(0, posList.Count)];
    }
}
