using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fainter : MonoBehaviour
{
    // Start is called before the first frame update
    // ���콺 Ŭ���� �ϸ� ���� �������� �����ǰ� �ϰ� �ʹ�.
    // ���콺�� ��ġ�� ���콺 �����Ͱ� ���󰡰� �ϰ� �ʹ�.
    // 
    // < �׷��� ���ؼ� �ʿ��� ��ɵ�>
    // ���� �������� �޾ƾ� �Ѵ�.(Instance)
    // ���� �������� ���׸����� �޾ƾ� �Ѵ�.
    // ����ƽȭ ���Ѽ� �ٸ� ��ũ��Ʈ���� ���� �������� ���׸����� ������ �� �־�� �Ѵ�.

    // �� ���콺 ��ġ�� ���� ���콺 �����Ͱ� ���� �ٳ�� �Ѵ�.(���� ������Ʈ�� ��ġ ����) (�� ��ġ�� �ʾ�!)

    // public GameObject mousePointer;

    [SerializeReference]
    public LineRenderer lR;
    public Material matlR;

    public GameObject linePrefab;
    EdgeCollider2D col;
    List<Vector2> points = new List<Vector2>();

    public static Fainter instance;


    //��... ���׸����� �� �༮�� �ƴ϶� �����հ� �����ؾ� �ϴµ�.
    //���� �������� ���׸����� �ƴ� �÷��� �����ؾ���. ��� ��������?

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
