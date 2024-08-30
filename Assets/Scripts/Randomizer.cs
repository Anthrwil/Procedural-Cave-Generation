using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public Transform[] branchesRot;

    [Range(0, 360)]
    public float branchAngle;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform t in branchesRot)
        {
            t.rotation = Quaternion.Euler(0, t.rotation.y + Random.Range(-branchAngle, branchAngle), 0);
        }
    }
}
