using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    
    public float playerSpeed;

    private Vector3 currMovement;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    // Movement
        float inputX = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", inputX);

        float inputY = Input.GetAxisRaw("Vertical");

        currMovement = new Vector3(inputX, inputY, 0);
        currMovement = currMovement * playerSpeed * Time.deltaTime;
        transform.position += currMovement;

    }
}
