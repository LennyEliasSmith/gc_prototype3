using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{

    public float timer;
    public float timerWait;

    public Vector3 worldPosition;
    public GameObject lure;
    private GameObject lureClone;

    private Animator animator;

    public bool hookActive;
    public bool hookBitten;

    void Start()
    {
        timerWait = Random.Range(0.0f,15.0f);
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = -0.6f;

        if (Input.GetButtonDown("Fire1") && !hookActive)
        {
            CastHook();
            animator.SetTrigger("hookCast");
        }
        else if (Input.GetButtonDown("Fire1") && hookActive)
        {
            PullHook();
        }
        
        if(hookActive)
        {
            timer = timer + Time.deltaTime;
        }

        if(timer >= timerWait)
        {
            hookBitten = true;
            animator.SetBool("hookBitten", true);
        }
    }

    void CastHook()
    {
        lureClone = Instantiate(lure, worldPosition, lure.transform.rotation);
        hookActive = true;
        animator.SetBool("hookActive", true);
    }

    void PullHook()
    {
        Destroy(lureClone);
        hookActive = false;

        // gives a fish only if the hook is pulled when you have a bite
        if(hookBitten)
        {
            Debug.Log("You caught FISH");
            hookBitten = false;
            animator.SetBool("hookBitten", false);
        }
        animator.SetBool("hookActive", false);
        animator.SetTrigger("hookPull");
        timer = 0f;
        SetRandomTimer();
    }

    // set a timer for the new bite when player next casts hook
    void SetRandomTimer()
    {
        timerWait = Random.Range(1.0f, 15.0f);
    }
}
