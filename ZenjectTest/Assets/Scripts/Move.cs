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
            Debug.Log("�E�ړ�");
        }
        if(inputReceivable.MoveH() == -1)
        {
            Debug.Log("���ړ�");
        }
        if (inputReceivable.MoveV() == 1)
        {
            Debug.Log("��ړ�");
        }
        if (inputReceivable.MoveV() == -1)
        {
            Debug.Log("�E�ړ�");
        }
    }
}
