using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.ARFoundation.Samples
{

    public class Destroy : MonoBehaviour
    {


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Skyla"))
            {
                PlaceFoodOnPlane.foodIsOnPlane = false;
                Destroy(gameObject);
                //explosionParticle.Play();

            }

        }
    }
}


