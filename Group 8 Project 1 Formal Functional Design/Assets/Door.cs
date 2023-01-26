using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public bool alreadyUnlocked;
    private Animator anim;
    private bool open;

    public override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
        open = false;
    }

    public override void Update()
    {
        base.Update();
        if (playerInRange)
        {
            if (alreadyUnlocked)
            {
                open = true;
                Unlock();
            }
        }
    }

    private void Unlock()
    {
        anim.SetBool("opened", true);
    }
}
