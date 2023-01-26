using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : Interactable
{
    public int id;
    public bool room2Button;
    public bool room3Button;
    public bool switchButton;
    public Door targetDoor;
    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
        if (playerInRange)
        {
            if (!Textthing.buttonIDs.Contains(id))
            {
                Textthing.buttonIDs.Add(id);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (room2Button)
                {
                    targetDoor.Unlock();
                }
            }
        } else
        {
            if (Textthing.buttonIDs.Contains(id))
            {
                Textthing.buttonIDs.Remove(id);
            }
        }
    }
}
