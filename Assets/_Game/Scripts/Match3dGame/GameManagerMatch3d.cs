using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManagerMatch3d : MonoBehaviour
{
    [SerializeField] private Text m_text;
    [SerializeField] private GameObject[] m_trashViews;
    [SerializeField] private GameObject[] m_foodViews;
    [SerializeField] private Bounds m_bounds;
    [SerializeField] private Transform m_objectsRoot;

    private List<MoveController> m_foodList = new List<MoveController>();

    public IEnumerator PlayMatch3()
    {
        for (int i = 0; i < 15; i++)
        {
            m_text.text = $"seconds {15 - i}";
            yield return new WaitForSeconds(1);
            var haveItems = false;
            for (int j = 0; j < m_foodList.Count; j++)
            {
                haveItems |= m_foodList[j];
            }

            if (!haveItems)
            {
               break;
            }
        }
    }
    void Start()
    {
      var c=  m_objectsRoot.GetComponentsInChildren<MoveController>();
      var newBounds = m_bounds;
      newBounds.center += transform.position;
      newBounds.size /= 2;
      for (int i = 0; i < c.Length; i++)
      {
          var item = c[i];
          if (i <= c.Length * .8f)
          {
              var view = m_trashViews[Random.Range(0, m_trashViews.Length)];
              item.Initialize(MoveController.ObjectType.Trash,view,newBounds);
          }
          else
          {
              var view = m_foodViews[Random.Range(0, m_foodViews.Length)];
              item.Initialize(MoveController.ObjectType.Food,view,newBounds);
              m_foodList.Add(item);
          }
      }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(m_bounds.center+transform.position,m_bounds.extents);
    }
}
