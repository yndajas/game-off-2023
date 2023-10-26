using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D _rigidBody;

    // Start is called before the first frame update
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = touchPosition.x < 0 ? Vector2.left : Vector2.right;

            _rigidBody.AddForce(direction * moveSpeed);
        }
        else
        {
            _rigidBody.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Block"))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
