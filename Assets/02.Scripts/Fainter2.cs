using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fainter2 : MonoBehaviour
{
    
    public GameObject linePrefab;
   
     LineRenderer lr;

    public Color cor;

    EdgeCollider2D col;


    List<Vector2> points = new List<Vector2>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       


        if (Input.GetMouseButtonDown(0))
        {
            
           GameObject go = Instantiate(linePrefab);

            lr = go.GetComponent<LineRenderer>();
           col = go.GetComponent<EdgeCollider2D>();

            print(Plate.instance.selectedColor);


            lr.startColor = Plate.instance.selectedColor;
            lr.endColor = Plate.instance.selectedColor;



            print(lr.startColor + lr.endColor);

            //lr.SetColors(Plate.selectedColor, Plate.selectedColor);


            points.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                lr.positionCount = 1;
                lr.SetPosition(0, points[0]);
            



        } else if (Input.GetMouseButton(0))
        {

                    Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //lr.SetColors(Plate.selectedColor, Plate.selectedColor);
            points.Add(pos);
            lr.positionCount++;
            lr.SetPosition(lr.positionCount - 1, pos);
            col.points = points.ToArray();
        } else if (Input.GetMouseButtonUp(0))
        {
            points.Clear();

        }

    }
}
