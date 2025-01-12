using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerController : NetworkBehaviour
{
    public override void OnStartLocalPlayer()
    {
        float playerHeight = 1.0f; // GetComponent<MeshRenderer>().bounds.size.y;
        
        Camera.main.transform.SetParent(transform);
        Camera.main.transform.localPosition = new Vector3(0.0f, playerHeight, 0.0f);
    }

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void LateUpdate()
    {
        MovementBehaviour();
    }

    public void MovementBehaviour()
    {
        if (!isLocalPlayer) { return; }

        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 110.0f;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 4f;

        transform.Rotate(0, moveX, 0);
        transform.Translate(0, 0, moveZ);
    }
}
