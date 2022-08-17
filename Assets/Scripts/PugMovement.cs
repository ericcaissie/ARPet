using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARSubsystems;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class PugMovement : MonoBehaviour
    {
        [SerializeField]
        private Animator anim;

        public static int jumpAnimHash = Animator.StringToHash("Jump");

        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PugJump()
        {
            //if (anim == null)
            //{
            //    Debug.LogError("no animator found");
            //}

            anim.SetTrigger(jumpAnimHash);
          //  anim.SetBool("Jump1", true);
            //Debug.Log("the dog is jumping");
        }


    }

}


