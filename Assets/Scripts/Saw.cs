using UnityEngine;

public class Saw : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag != "Player") return;
        
        if (Camera.main)
        {
            Camera.main.transform.parent = null;
        }
            
        col.gameObject.GetComponent<PlayerDeath>().Die();
    }
}
