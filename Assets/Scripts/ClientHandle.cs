﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientHandle : MonoBehaviour
{
    public static void Welcome(Packet _packet)
    {
        string _msg = _packet.ReadString();
        int _id = _packet.ReadInt();

        Debug.Log($"Msg from server: {_msg}");
        Client.instance.myId = _id;
        ClientSend.WelcomeReceived();
    }
}
