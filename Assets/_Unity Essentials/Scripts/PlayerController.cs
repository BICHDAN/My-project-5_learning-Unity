using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;        // Movement speed

    public float rotationSpeed = 120.0f;  // Rotation speed in degrees per second

    private Rigidbody rb; // Reference to player's Rigidbody.

    public float jumpForce = 5.0f;


    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.

    }

    // Update is called once per frame

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }
    private void FixedUpdate()
    {
        // Movement
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);


        // Rotation
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}