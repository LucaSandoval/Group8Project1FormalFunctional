using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public float range;
    private GameObject player;
    public bool playerInRange;
    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public virtual void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= range)
        {
            playerInRange = true;
        } else
        {
            playerInRange = false;
        }
    }
}
