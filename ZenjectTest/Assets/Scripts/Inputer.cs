using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputer : MonoBehaviour,IInputReceivable
{
    public float MoveH()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public float MoveV()
    {
        return Input.GetAxisRaw("Vertical");
    }
}
