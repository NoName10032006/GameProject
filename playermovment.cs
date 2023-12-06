using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool jumping;
    private Rigidbody2D body;

    private void Awake()
    {
         body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        
        if (Input.GetKey(KeyCode.UpArrow) && jumping == false)
        {
            body.velocity = new Vector2(body.velocity.x, speed);
            jumping = true;
        }
        
            

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            jumping = false;
        }
    }







}
