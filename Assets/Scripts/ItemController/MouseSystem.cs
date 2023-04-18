using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSystem : MonoBehaviour
{
   [SerializeField] private GameObject _item;
   private Vector3 _pointScreen;
   private Vector3 _offset;

   private void OnMouseDown()
   {
      _pointScreen = Camera.main.WorldToScreenPoint(transform.position);
      var newItem = Instantiate(_item);
      _offset = newItem.transform.position - Camera.main.WorldToScreenPoint(new Vector3(Input.mousePosition.x, 
         Input.mousePosition.y, _pointScreen.z));
   }

   private void OnMouseDrag()
   {
      Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _pointScreen.z);
      Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
      _item.transform.position = curPosition;
   }
   
}
