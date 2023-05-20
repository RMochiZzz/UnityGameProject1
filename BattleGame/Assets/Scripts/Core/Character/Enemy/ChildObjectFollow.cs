using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChildObjectFollow : MonoBehaviour
{
    public Transform childPosition;

    private void FixedUpdate()
    {

        transform.position = childPosition.position;
    }
}
