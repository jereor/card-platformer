using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _jumpForce;
    
    private Rigidbody2D _playerRigidbody;
    
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _playerRigidbody.AddForce(Vector3.right * (_movementSpeed * Time.fixedDeltaTime), ForceMode2D.Force);
        // TODO: Cap the velocity
    }

    // ----------- PC CONTROLS -------------
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        Debug.Log("Jump!");
        _playerRigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
