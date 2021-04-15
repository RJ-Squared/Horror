using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public CharacterController player;
    public float playerSpeed = 50f;

    private float xMovement = 0f;
    private float zMovement = 0f;

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal");
        zMovement = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xMovement + transform.forward * zMovement;

        player.Move(move * playerSpeed * Time.deltaTime);
    }
}
