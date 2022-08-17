using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARSubsystems;

namespace UnityEngine.XR.ARFoundation.Samples
{

    public class GoToFood : MonoBehaviour
    {
        public float speed = 0.1f;
        private Rigidbody pugRB;

        GameObject food;
        private Animator animator;

        // Start is called before the first frame update
        void Start()
        {
            animator = GetComponent<Animator>();

        }

        // Update is called once per frame
        void Update()
        {
            if (PlaceFoodOnPlane.foodIsOnPlane == true)
            {

                //StartCoroutine(MyCoroutine());

                pugRB = GetComponent<Rigidbody>();
                food = GameObject.Find("Food(Clone)");

                var foodPos = food.transform.position;
                transform.LookAt(pugRB.transform.position);

                Vector3 lookDirection = (food.transform.position - pugRB.transform.position).normalized;

                transform.rotation = Quaternion.LookRotation(lookDirection);

                var step = speed * Time.deltaTime; // calculate distance to move
                transform.position = Vector3.MoveTowards(transform.position, foodPos, step);


            }

        }

        //private IEnumerator MyCoroutine()
        //{

        //    yield return new WaitForSeconds(0.0f);
        //    animator.SetTrigger("Jump");

        //    yield return new WaitForSeconds(1.5f);
        //    animator.SetTrigger("Walk");


        //}

        //private void OnCollisionEnter(Collision other)
        //{
        //    if (other.gameObject.CompareTag("Food"))
        //    {
        //        animator.SetTrigger("None");
        //    }

        //}
    }
}

