using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARSubsystems;

namespace UnityEngine.XR.ARFoundation.Samples
{

    public class GoToFoodSkyla : MonoBehaviour
    {
        public float speed = 0.1f;
        private Rigidbody skylaRB;

        GameObject food;
        private Animator anim;

        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();

        }

        // Update is called once per frame
        void Update()
        {
            if (PlaceFoodOnPlane.foodIsOnPlane == true)
            {

                //StartCoroutine(MyCoroutine());

                skylaRB = GetComponent<Rigidbody>();
                food = GameObject.Find("Food(Clone)");

                var foodPos = food.transform.position;
                transform.LookAt(skylaRB.transform.position);

                Vector3 lookDirection = (food.transform.position - skylaRB.transform.position).normalized;

                transform.rotation = Quaternion.LookRotation(lookDirection);

                var step = speed * Time.deltaTime; // calculate distance to move
                transform.position = Vector3.MoveTowards(transform.position, foodPos, step);

                anim.SetTrigger("Walk");
                anim.SetBool("Walk1", true);
            }

        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Food"))
            {
                PlaceFoodOnPlane.foodIsOnPlane = false;
                Destroy(other.gameObject);
                anim.SetTrigger("Idle");
                anim.SetBool("Walk1", false);
                anim.SetBool("Idle1", true);
                Debug.Log("Skyla is Idle");

                //explosionParticle.Play();


            }
        }
    }
}


