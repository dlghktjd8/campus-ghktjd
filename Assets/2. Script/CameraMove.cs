using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    private Vector3 pos = new Vector3(0, 5, -3);

    void Update()
    {
        this.gameObject.transform.position = player.transform.position + pos;
    }
}
