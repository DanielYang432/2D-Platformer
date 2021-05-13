using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{


	public float speed = 1;

	private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
        _rigidbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector3 (Mathf.Sin (Time.time) * speed, 0, 0);
    }
}
