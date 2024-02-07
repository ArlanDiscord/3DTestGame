using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCast : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public Transform Player;
    public Transform pointer;
    public Selectable previousSelected;
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public float fireSpeed = 20f;
    void Update()
    {
        Ray ray = new Ray(Player.transform.position, transform.forward);
        Debug.DrawRay(Player.transform.position, transform.forward*100, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            pointer.position = hit.point;
            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (previousSelected && previousSelected != selectable)
            {
                previousSelected.Deselect();
                previousSelected = null;
            }
            if (selectable)
            {
               if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    GameObject bullet = Instantiate(bulletPrefab);
                    bullet.transform.position = bulletSpawn.position;
                    bullet.GetComponent<Rigidbody>().velocity = bulletSpawn.forward * fireSpeed;
                    Destroy(bullet,20);
                }
                previousSelected = selectable;
                selectable.Select();
            }
        }
        else if (previousSelected)
        {
            previousSelected.Deselect();
            previousSelected = null;
        }
    }
}
