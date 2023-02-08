using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottom = -20f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottom)
        {
            AppleMissed();
        }
    }

    void AppleMissed()
    {
        Destroy(this.gameObject);
        Camera.main.GetComponent<ApplePicker>().AppleMissed();
    }
}
