using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float turnSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] KeyCode jumpKey;
    [SerializeField] TextMeshProUGUI text;
    private Rigidbody rb;

    float turnDir;
    float moveDir;

    public int Coins;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveDir = Input.GetAxis("Vertical");
        turnDir = Input.GetAxis("Horizontal") * turnSpeed;
         Vector3 move = transform.forward  *moveDir* moveSpeed *Time.deltaTime;
        rb.MovePosition(rb.position+move);
        if (turnDir != 0)
        {
            Quaternion rotation = Quaternion.Euler(0, turnDir * turnSpeed*Time.deltaTime, 0);
            rb.MoveRotation(rb.rotation * rotation);
        }
        if (Input.GetKeyUp(jumpKey))
        {
            rb.AddForce(new Vector3(rb.velocity.x, jumpForce, rb.velocity.z), ForceMode.Impulse);
        }

    }
    public void Fall()
    {
        GetComponent<Collider>().enabled = false;
    }

    public void AddCoin(int coins)
    {
        Coins += coins;
        text.text = Coins.ToString();
    }
}
