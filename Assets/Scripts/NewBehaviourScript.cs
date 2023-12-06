using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
public Camera camera;
    public List<GameObject> nottoy;
    public int ui;

    public void one()
    {
        ui = 0;
    }
    public void two()
    {
        ui = 1;
    }
    public void three()
    {
        ui = 2;
    }

    // Update is called once per frame
    void Update()
    {
        // Check for mouse input (left mouse button)
        if (Input.GetMouseButtonDown(0))
        {
            
            // Get the mouse position in screen coordinates
            Vector3 mousePosition = Input.mousePosition;

            // Cast a ray from the camera through the mouse position
            Ray ray = camera.ScreenPointToRay(mousePosition);

            // Perform the raycast and store the hit information
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                // The ray hit an object
                GameObject hitObject = hitInfo.collider.gameObject;

                // You can now do something with the hit object
                Instantiate(nottoy[ui], hitObject.transform.position, hitObject.transform.rotation);

                // Optionally, perform further actions with the hit object
            }
            else
            {
                // The ray did not hit any object
                Debug.Log("Ray did not hit anything.");
            }
        }
    }
}
