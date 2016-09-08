 using UnityEngine;
 public class norotate : MonoBehaviour
 {
     public Transform Player;
     public Vector3 Offset;
     private Quaternion startRot;

     void Start() {
     	startRot = transform.rotation;
     }

 
     void LateUpdate ()
     //http://answers.unity3d.com/questions/342550/camera-follows-rotation-how-can-i-fix-it.html
     {
         if (Player != null)
             transform.rotation = startRot;//Quaternion.Euler(Vector3.zero);
     }
 }