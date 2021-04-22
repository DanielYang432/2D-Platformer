using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public Transform target;
	public float smotherSpeed = 0.125f;
	public Vector3 offset;

    // Start is called before the first frame update
	void LateUpdate()
	{
		transform.position = target.position + offset;

	}
}
