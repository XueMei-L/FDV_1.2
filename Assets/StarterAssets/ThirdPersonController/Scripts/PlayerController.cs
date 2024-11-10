using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movemento = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movemento * Speed);
    }
}
