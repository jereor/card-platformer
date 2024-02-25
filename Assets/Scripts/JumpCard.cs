using UnityEngine;

public class JumpCard : ICard
{
    public void Use()
    {
        Debug.Log("Use() not implemented!");
        throw new System.NotImplementedException();
    }

    public void Discard()
    {
        Debug.Log("Discard() not implemented!");
        throw new System.NotImplementedException();
    }
}
