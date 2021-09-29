using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{

    //public static ColorPicker instance;


   public Color myColor;
    public bool colorSelect;
    // Start is called before the first frame update

    private void Awake()
    {
        //instance = this;
    }

    void Start()
    {
        colorSelect = false;
     



      // myColor = GetComponent<Image>().color;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setColor()
    {
        colorSelect = true;
        Plate.instance.selectedColor = GetComponent<Image>().color;
        //Plate.selectedColor = myColor;
        //   Plate.selectedColor  = myColor.linear;
        print("setColor");
    }
    public void setBold()
    {


    }


}
