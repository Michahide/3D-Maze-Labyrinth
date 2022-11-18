using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    private void Update()
    {
        if (Input.touchCount == 0)
            return;

        var touch = Input.GetTouch(0);

        // swipe
        if (touch.deltaPosition.x > 10)
            Debug.Log("Right");
        else if (touch.deltaPosition.x < -10)
            Debug.Log("Left");

        //switch (touch.phase) 
        //{ 
        //    case TouchPhase.Began:
        //        Debug.Log("Began");
        //        break;
        //    case TouchPhase.Stationary:
        //        Debug.Log("Stationary");
        //        break;
        //    case TouchPhase.Moved:
        //        Debug.Log("Moved");
        //        break;
        //    case TouchPhase.Ended:
        //        Debug.Log("Ended");
        //        break;
        //    case TouchPhase.Canceled:
        //        Debug.Log("Canceled");
        //        break;
        //}
    }

    private void OnDrawGizmos()
    {
        foreach (var touch in Input.touches)
        {
            var touchWorldPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchWorldPos.z = 0;
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Gizmos.color = Color.green;
                    break;
                case TouchPhase.Stationary:
                    Gizmos.color = Color.red;
                    break;
                case TouchPhase.Moved:
                    Gizmos.color = Color.blue;
                    break;
                case TouchPhase.Ended:
                    Gizmos.color = Color.yellow;
                    break;
                case TouchPhase.Canceled:
                    Gizmos.color = Color.grey;
                    break;
            }
        }
    }
}
