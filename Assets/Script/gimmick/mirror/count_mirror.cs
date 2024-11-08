using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count_mirror : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;

    public GameObject object6;
    public GameObject object7;
    public GameObject object8;
    public GameObject object9;


    public GameObject l_object1;
    public GameObject l_object2;
    public GameObject l_object3;
    public GameObject l_object4;
    public GameObject l_object5;

    public GameObject l_object6;
    public GameObject l_object7;
    public GameObject l_object8;
    public GameObject l_object9;

    public GameObject player;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    public GameObject door;

    private void Start()
    {
        door.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        initialPosition = player.gameObject.transform.position;
        initialRotation = player.gameObject.transform.rotation;
    }
    void Update()
    {
        if (object1.activeSelf == false && object2.activeSelf == false && object3.activeSelf == false &&
             object4.activeSelf == false && object5.activeSelf == false)
        {
            door.gameObject.SetActive(true);
            //Debug.Log("open");
        }

        if(object6.activeSelf == false || object7.activeSelf == false ||
             object8.activeSelf == false || object9.activeSelf == false || 
             l_object1.activeSelf == false || l_object2.activeSelf == false
             || l_object3.activeSelf == false || l_object4.activeSelf == false ||
             l_object5.activeSelf == false || l_object6.activeSelf == false
             || l_object7.activeSelf == false || l_object8.activeSelf == false
             || l_object9.activeSelf == false)
        {
            player.gameObject.SetActive(false);

            object1.gameObject.SetActive(true);
            object2.gameObject.SetActive(true);
            object3.gameObject.SetActive(true);
            object4.gameObject.SetActive(true);
            object5.gameObject.SetActive(true);
            object6.gameObject.SetActive(true);
            object7.gameObject.SetActive(true);
            object8.gameObject.SetActive(true);
            object9.gameObject.SetActive(true);

            l_object1.gameObject.SetActive(true);
            l_object2.gameObject.SetActive(true);
            l_object3.gameObject.SetActive(true);
            l_object4.gameObject.SetActive(true);
            l_object5.gameObject.SetActive(true);
            l_object6.gameObject.SetActive(true);
            l_object7.gameObject.SetActive(true);
            l_object8.gameObject.SetActive(true);
            l_object9.gameObject.SetActive(true);
        }
    }
}
