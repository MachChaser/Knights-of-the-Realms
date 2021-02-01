using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] private Animator animator;
 

void OnMouseDown()
    {

        animator.SetBool("NewGameCam", false);
    }




}
