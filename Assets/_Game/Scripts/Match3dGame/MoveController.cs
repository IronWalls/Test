using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Camera m_camera;

    public enum ObjectType
    {
        Trash, Food
    }

    private Bounds m_bound;
    private Vector3 m_dist;
    private Vector3 m_startPos;
    private float m_posX;
    private float m_posZ;
    private float m_posY;

    public ObjectType Type { get; set; }

    public void Initialize(ObjectType type, GameObject viewPrefab, Bounds bound)
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        Type = type;
        Instantiate(viewPrefab, transform);
        m_bound = bound;
    }

    private void OnMouseDown()
    {
        m_startPos = transform.position;
        m_dist = Camera.main.WorldToScreenPoint(transform.position);
        m_posX = Input.mousePosition.x - m_dist.x;
        m_posY = Input.mousePosition.y - m_dist.y;
        m_posZ = Input.mousePosition.z - m_dist.z;
    }

    private void OnMouseDrag()
    {
        var plane = new Plane(Vector3.up, Vector3.up * 1.7f);
        var ray = m_camera.ScreenPointToRay(Input.mousePosition);

        if (plane.Raycast(ray, out var enter))
        {
            Vector3 lastPos = ray.GetPoint(enter);
            lastPos = m_bound.ClosestPoint(lastPos);
            transform.position = new Vector3(lastPos.x,
                                             Mathf.MoveTowards(transform.position.y, 1.7f, Time.deltaTime * 100),
                                             lastPos.z);
        }
    }
}