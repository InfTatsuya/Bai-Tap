using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap11 : MonoBehaviour
{
    private Vector3 target;

    private void Start()
    {
        target = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                target = hit.point;
            }
        }

        if (target == Vector3.zero) return;
        transform.position =Vector3.Lerp(transform.position, target, Time.deltaTime * 5f);
        if(Vector3.Distance(transform.position, target) < 0.01f)
        {
            Debug.Log("Completed!!");
        }
    }
}
