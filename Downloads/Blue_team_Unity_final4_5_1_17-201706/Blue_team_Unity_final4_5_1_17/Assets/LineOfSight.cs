using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineOfSight : MonoBehaviour
{
    private int count;
    public Text countText;

    // Use this for initialization
    void Start()
    {
        count = 0;
        countText.text = " Score:" + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        //Vector3 origin = new Vector3(0f, 0.5f, 0f) ;
        // Vector3 direction = new Vector3(transform.forward);
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {

            if (hit.collider.tag == "Interactive")
            {
                Debug.Log("hit:" + hit.collider.name);
                count = count + 1;
                countText.text = " Score:" + count.ToString();
            }

        }

        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.red,50000f);

    }
}
/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimShootScore : MonoBehaviour
{



    public float weaponRange = 50000f;
    private Camera fpsCam;
    private int count;
    public Text countText;



    // Use this for initialization
    void Start()
    {
        fpsCam = GetComponentInParent<Camera>();
        count = 0;
        countText.text = " Score:" + count.ToString();

    }

    // Update is called once per frame
    void Update()
    {



        Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        // Ray raydirection = new Ray(transform.position, transform.forward);


        if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
        {


            if (hit.collider.gameObject.name == "Plane")
            {//if your raycast hits certia objects
                Debug.Log("hit plane");
                //do nothing
            }
            else
            {
                // count = count + 1;
                // countText.text = " Score:" + count.ToString();
            }

        }//end if
        Debug.DrawRay(transform.position, transform.forward, Color.black, 1); //unless you allow debug to be seen in game, this will only be viewable in the scene view


    }

}
*/