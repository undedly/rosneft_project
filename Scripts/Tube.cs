using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using static System.Math;

public class Tube : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public GameObject cube;

    private GameObject instantiatedCube;

    public float tubeScale;

    private void SetLine()
    {
        Vector3 deltaVector = end.position + start.position;
        Vector3 center = (deltaVector) / 2;
        Quaternion angle = Quaternion.FromToRotation(deltaVector, transform.forward);
        if (instantiatedCube == null)
        {
            instantiatedCube = Instantiate(cube, center, angle);
        }
        else
        {
            instantiatedCube.transform.position = center;
            instantiatedCube.transform.rotation = angle;
        }

        instantiatedCube.transform.localScale = new Vector3(tubeScale, tubeScale, deltaVector.magnitude);




    }
}    