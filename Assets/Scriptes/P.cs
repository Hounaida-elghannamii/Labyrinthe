using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour
{
    public GameObject Gop;
    // Start is called before the first frame update
    void Start()
    {
        Gop.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Gop.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
