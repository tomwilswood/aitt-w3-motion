using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
                                     // member variables declared at class level (i.e. put this bit at the top of your script)
        float gravityX = 0.0f;
        float gravityY = 0.0f;
        float sensitivity = 0.1f;


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            //float h = Input.GetAxis("Horizontal");
            //float v = Input.GetAxis("Vertical");
            //float handbrake = Input.GetAxis("Jump");
            //float h = Input.acceleration.x;
            //float v = - Input.acceleration.z;
            float h = gravityX;
            float v = gravityY;
            float handbrake = Input.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);



            // code to calculate latest gravity reading for axis in update function (put this in, e.g., the update function)
            gravityX = ((1.0f - sensitivity) * gravityX) + (sensitivity * Input.acceleration.x);
            gravityY = ((1.0f - sensitivity) * gravityY) + (sensitivity * -Input.acceleration.z);
        }
    }
}
