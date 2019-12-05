using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("跟随目标")]
    public Transform target;
    [Header("跟随速度"), Range(0f, 100f)]
    public float speed = 1.5f;


    private void Track()
    {
        float limitY = Mathf.Clamp(target.position.y, 0f, 3f);

        Vector3 targetPos = new Vector3(target.position.x, limitY , -10);

        transform.position = Vector3.Lerp(transform.position, targetPos, 0.3f * speed *Time.deltaTime);

    }

    private void LateUpdate()
    {
        Track();
    }
}
