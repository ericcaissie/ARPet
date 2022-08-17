using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARSubsystems;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class PugDestroy : MonoBehaviour
    {
        private Rigidbody pugRB;
        GameObject distance;
        private float maxDist = 50.0f;

        // Start is called before the first frame update
        void Start()
        {
            pugRB = GetComponent<Rigidbody>();
            distance = GameObject.Find("Distance");
        }

        // Update is called once per frame
        void Update()
        {
            if (Vector3.Distance(distance.transform.position, pugRB.transform.position) > maxDist)
            {
                PlaceOnPlane.pugIsActive = false;
                Destroy(gameObject);
            }
        }
    }
}



