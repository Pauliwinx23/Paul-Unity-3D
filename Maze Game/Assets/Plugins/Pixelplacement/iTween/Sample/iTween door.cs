using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweendoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", new Vector3(transform.position.x, transform.position.y + 9f, transform.position.z), "time", 0.5f, "easetype", iTween.EaseType.easeInOutSine));
    }

    private void OnTriggerExit(Collider other)
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), "time", 0.5f, "easetype", iTween.EaseType.easeInOutSine));
    }
}
