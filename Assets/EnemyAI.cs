using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
	public Transform target;
	public float moveSpeed = 2f;
	private Rigidbody2D _rigidbody;
	public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) <= 10){
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    	} else{
    	_rigidbody.velocity = new Vector3 (Mathf.Sin (Time.time) * speed, 0, 0);
    	}

    }
}
