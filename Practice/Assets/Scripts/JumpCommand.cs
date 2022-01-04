using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : MonoBehaviour, ICommand
{
    public void execute(Player player)
    {
        player.jump();
    }
}
