using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
   [SerializeField]
   private float movespeed = 10f;
   public float damage = 1f;

   // Start is called before the first frame update
   void Start()
   {
       Destroy(gameObject, 1f);
   }
   // Update is called once per frame
   void Update()
   {
       transform.position += Vector3.up * movespeed * Time.deltaTime;
   }
    
}
