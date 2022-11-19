using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
    public GameObject btn;
    public Menu menu;

    public void HunterPressed()
    {
        btn.transform.position = new Vector2(3000, transform.position.y);
    }

    private void Update()
    {
        if(btn.transform.position.x < 100)
        {
            menu.GameOver();
            Time.timeScale = 0;
        }
    }
}
