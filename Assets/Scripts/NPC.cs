using UnityEngine;

public class NPC : MonoBehaviour
{
    public string npcName = "Merchant";
    public int health = 100;

    void Start()
    {
        Debug.Log("NPC created: " + npcName);
    }
}