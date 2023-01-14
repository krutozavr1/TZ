using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bounds : MonoBehaviour
{ 

    void LateUpdate()
    {
        FollowPlayer(); 
    }

    private void FollowPlayer()
    {
        transform.position = new Vector2(Player.instance.gameObject.transform.position.x, transform.position.y);
    }
}
