using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int Respawn;

    bool shouldKill = false;
    float killTimer = 1f;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldKill)
        {
            if (killTimer > 0)
            {
                anim.SetBool("ShouldKill", true);

                killTimer = killTimer - Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene(Respawn);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            shouldKill = true;
        }
    }
}
