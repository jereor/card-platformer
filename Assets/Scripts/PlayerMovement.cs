using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _maxMovementSpeed;
    [SerializeField] private float _jumpForce;
    private Rigidbody2D _playerRigidbody;
    private PlayerCards _playerCards;
    
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _playerCards = GetComponent<PlayerCards>();
    }

    void FixedUpdate()
    {
        if (_playerRigidbody.velocity.x >= _maxMovementSpeed)
        {
            return;
        }
        _playerRigidbody.AddForce(Vector3.right * (_movementSpeed * Time.fixedDeltaTime), ForceMode2D.Force);
    }

    // ----------- PC CONTROLS -------------
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerCards.Use_TopCard();
        }
    }

    private void Jump()
    {
        _playerRigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
