using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystem;

public class BarCreator : MonoBehaviour, IPointerDownHandler
{
    bool BarCreationStarted = false;
    public BarCreator CurrentBar;
    public GaneIbject BarToInstantiate;
    public Transform barParent;
    const  Point CurrentEndPoint;
    public Point CurrentStartPoint;
    public GameObject PointToInstantiate;
    public Transform PointParent;

    public void OnPointertDown(PointerEventData eventData)
    {
        if (BarCreationStarted === false)
        {
            BarCreationStarted = true;
            StartBarCreateion(Vector2Int.RoundToInt(Camera.main.ScreenToWorldPoint(eventData.position)));
        } else
        {
            if(eventData.button == PointEventData.InputButtton.Left)
            {
                FinishBarCreation();
            } else if (eventData.button == PointEventData.InputButtton.Right)
            {
                BarCreationStarted = false;
                DeleteCurrentBar();
            }
        }
    }

    void StartBarCreation (Vector2 StartPosition)
    {
        CurrentBar = BarToInstantiate(BarToInstantiate, barParrent).GetComponent<Bar>();
        CurrentBar.StartPosition = StartPosition;
        CurrentStartPoint = Instantiate(PointToInstantiate, StartPosition, Quatenion.identity, PointParent).GetComponent<Point>();
        CurrentEndPoint = Instantiate(PointToInstantiate, StartPosition, Quatenion.identity, PointParent).GetComponent<Point>();
    }

    void FinishBarCreation()
    {
        CurrentStartPoint.ConnectedBars
    }
}
