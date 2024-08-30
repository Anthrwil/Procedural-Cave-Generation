using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    public Transform item;
    public float smoothSpeed = 1;
    public float maxAngle;

    void Update()
    {
        Quaternion currentLocalRotation = item.localRotation;
        item.localRotation = Quaternion.identity;
        Vector3 targetWorldLookDir = target.position - item.position;
        Vector3 targetLocalLookDir = item.InverseTransformDirection(targetWorldLookDir);
        targetLocalLookDir = Vector3.RotateTowards(Vector3.forward, targetLocalLookDir, Mathf.Deg2Rad * maxAngle, 0);
        Quaternion targetLocalRotation = Quaternion.LookRotation(targetLocalLookDir, Vector3.up);
        item.localRotation = Quaternion.Slerp(currentLocalRotation, targetLocalRotation, 1 - Mathf.Exp(-smoothSpeed * Time.deltaTime));
    }
}
