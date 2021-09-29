using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fainter : MonoBehaviour
{
    // Start is called before the first frame update
    // 마우스 클릭을 하면 라인 랜더러가 생성되게 하고 싶다.
    // 마우스의 위치에 마우스 포인터가 따라가게 하고 싶다.
    // 
    // < 그러기 위해서 필요한 기능들>
    // 라인 랜더러를 받아야 한다.(Instance)
    // 라인 랜더러의 메테리얼을 받아야 한다.
    // 스태틱화 시켜서 다른 스크립트에서 라인 렌더러의 메테리얼을 참조할 수 있어야 한다.

    // 내 마우스 위치에 따라 마우스 포인터가 따라 다녀야 한다.(게임 오브젝트의 위치 변동) (내 위치는 너야!)

    // public GameObject mousePointer;

    [SerializeReference]
    public LineRenderer lR;
    public Material matlR;

    public GameObject linePrefab;
    EdgeCollider2D col;
    List<Vector2> points = new List<Vector2>();

    public static Fainter instance;


    //흠... 매테리얼을 이 녀석게 아니라 프리팹걸 참조해야 하는데.
    //라인 랜더러는 매테리얼이 아닌 컬러를 참조해야함. 어떻게 참조하지?

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

        // mousePointer = GetComponent<GameObject>();

        matlR = GetComponent<Material>();

    }


    // Update is called once per frame
    /*void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            print("mousedown");

            if (ColorPicker.instance.colorSelect == true)
            {
                lR.SetColors(Plate.selectedColor, Plate.selectedColor);
                print("colorselect true-----------");
                print("selectedcolor =======" + Plate.selectedColor.ToString());
                GameObject go = Instantiate(linePrefab);

                col = go.GetComponent<EdgeCollider2D>();
                points.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));

                lR.positionCount = 1;
                lR.SetPosition(0, points[0]);
            }
            else
            {
                print("colorselect true-----------");
                print("selectedcolor =======" + Plate.selectedColor.ToString());
                GameObject go = Instantiate(linePrefab);

                col = go.GetComponent<EdgeCollider2D>();
                points.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));

                lR.positionCount = 1;
                lR.SetPosition(0, points[0]);


            }

        }
        else if (Input.GetMouseButton(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Vector2.Distance(points[points.Count - 1], pos) > 0.1f)
            {
                points.Add(pos);
                lR.positionCount++;
                lR.SetPosition(lR.positionCount - 1, pos);
                col.points = points.ToArray();



            }
            else if (Input.GetMouseButtonUp(0))
            {
                points.Clear();
            }


        }

    }*/
}
