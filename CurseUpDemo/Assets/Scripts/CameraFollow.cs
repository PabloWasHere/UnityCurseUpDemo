using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;

    void Update()
    {
        Vector3 pos = target.transform.position;
        pos.z = -1;
        transform.position = pos;
    }
}
