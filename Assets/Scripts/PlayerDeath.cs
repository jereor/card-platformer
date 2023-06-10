using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public void Die()
    {
        Destroy(gameObject);
        Debug.Log("You died!");
    }
}
