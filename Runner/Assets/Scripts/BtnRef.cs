using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnRef : MonoBehaviour
{
    public GameObject btn;
    public Player player;

    public void Jump()
    {
        if (player.isGrounded == true) {
            player.rb.velocity = Vector2.up * player.jumpspeed;
        }
    }
}
