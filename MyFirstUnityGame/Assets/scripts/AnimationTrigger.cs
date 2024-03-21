using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Animator.ResetTrigger("Trigger");
            m_Animator.SetTrigger("Trigger2");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Animator.ResetTrigger("Trigger2");
            m_Animator.SetTrigger("Trigger");
        }
    }
}
