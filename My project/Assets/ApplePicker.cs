using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;

    public int numBaskets = 3;

    public float bottom = -14f;

    public float spacing = 2f;

    public List<GameObject> baskets;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject basket = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = bottom + spacing * i;
            basket.transform.position = pos;
            baskets.Add(basket);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppleMissed()
    {
        if (baskets.Count > 0)
        {
            Destroy(baskets[baskets.Count - 1]);
            baskets.RemoveAt(baskets.Count - 1);

            if (baskets.Count == 0)
            {
                // the player has just lost
                SceneManager.LoadScene("_Scene_0");
            }
        }
    }
}
