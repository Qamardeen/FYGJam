using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;

    private Rigidbody2D rb;
    private Vector3 currMovement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal"); 
        float inputY = Input.GetAxisRaw("Vertical");

        currMovement = new Vector3(inputX, inputY, 0);

        currMovement = currMovement * playerSpeed * Time.deltaTime;

        transform.position += currMovement;
    }



    private void FixedUpdate()
    {
        
        
    }
}
