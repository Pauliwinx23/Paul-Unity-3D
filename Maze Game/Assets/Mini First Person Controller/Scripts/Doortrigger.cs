using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    Animator dooranim;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        dooranim.SetBool("open", true);
    }
    void Start()
    {
        dooranim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
