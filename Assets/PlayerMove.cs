using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
	public float MovementSpeed = 1;
	public float JumpForce = 10;

	private Rigidbody2D _rigidbody;


    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f){

        	_rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other){

    	Debug.Log("Hit Detected");

    	if(other.gameObject.tag == "Enemy"){

    		Debug.Log("Respawn");
    		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    	}
    }
}
