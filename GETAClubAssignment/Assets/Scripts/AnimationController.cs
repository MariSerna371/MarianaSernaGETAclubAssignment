using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] GameObject effect;
    [SerializeField] Transform effectTransform;

    Animator myAnimator;

    bool isInstantiated = false;

    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            isInstantiated = true;
        }

        if(isInstantiated)
        {
            myAnimator.SetTrigger("InNature");
            Instantiate(effect, effectTransform.position, effectTransform.rotation);
            isInstantiated = false;
        }
    }
}
