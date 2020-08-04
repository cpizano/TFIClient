using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool[] previous = new bool[4];

    private void FixedUpdate()
    {
        SendInputToServer();
    }

    private void SendInputToServer()
    {
        bool[] _inputs = new bool[]
        {
            Input.GetKey(KeyCode.W),
            Input.GetKey(KeyCode.S),
            Input.GetKey(KeyCode.A),
            Input.GetKey(KeyCode.D),
        };

        // This is cpu's added code, probably needs to be removed.
        if (previous.Equals(_inputs))
        {
            return;
        }

        ClientSend.PlayerMovement(_inputs);
        previous = _inputs;
    }
}
