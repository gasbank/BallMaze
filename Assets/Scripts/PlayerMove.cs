using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float unitForce = 0.5f;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddForce(Input.GetAxis("Horizontal") * unitForce, 0, Input.GetAxis("Vertical") * unitForce);
    }
}
