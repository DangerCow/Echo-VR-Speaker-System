﻿using System.Linq;
using UnityEngine;
 using UnityEngine.UI;
 
 public class SliderText : MonoBehaviour {
 
     Text textComponent;
     private string textValue = "1.1x";
 
     void Start() {
         textComponent = GameObject.Find("UICanvas").transform.GetComponentsInChildren<Transform>(true).FirstOrDefault(t => t.name == "GoalHornVolTextVal").GetComponent<Text>();
         textComponent.text = textValue;
     }
    
 
     public void SetSliderValue(float sliderValue) {
         textValue = (0.5f +(sliderValue * 0.05f)).ToString() + "x";
         if(textComponent != null){
            textComponent.text = textValue;
         }
     }
 }
 