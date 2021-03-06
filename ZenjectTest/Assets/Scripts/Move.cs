using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Move : MonoBehaviour
{
    [Inject] IInputReceivable inputReceivable;

    // Update is called once per frame
    void Update()
    {
        if(inputReceivable.MoveH() == 1)
        {
            Debug.Log("右移動");
        }
        if(inputReceivable.MoveH() == -1)
        {
            Debug.Log("左移動");
        }
        if (inputReceivable.MoveV() == 1)
        {
            Debug.Log("上移動");
        }
        if (inputReceivable.MoveV() == -1)
        {
            Debug.Log("右移動");
        }
    }
}
