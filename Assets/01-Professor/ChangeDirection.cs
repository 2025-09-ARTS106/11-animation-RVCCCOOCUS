using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    private Animator ami;
    private float horizontalmove;
    private float verticalmove;

    // Start is called before the first frame update
    void Start()
    {
        ami = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxis("Horizontal");

        verticalmove = Input.GetAxis("Vertical");


        if (horizontalmove < 0)
        {
            ami.SetInteger("direction", 3);
        }

        if (horizontalmove > 0)
        {
            ami.SetInteger("direction", 1);
        }

        if (verticalmove < 0)
        {
            ami.SetInteger("direction", 2);
        }

        if (verticalmove > 0)
        {
            ami.SetInteger("direction", 0);
        }
    }
}
