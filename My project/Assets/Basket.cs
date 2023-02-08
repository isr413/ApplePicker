using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Move(mousePos3D.x);
    }

    void Move(float x)
    {
        Vector3 pos = this.transform.position;
        pos.x = x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collided = coll.gameObject;
        if (collided.CompareTag("Apple"))
        {
            Destroy(collided);
            scoreCounter.Add100();
        }
    }
}
