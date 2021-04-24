using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ScreenLimit))]
public class PlayerBoundScreenLimit : Editor
{
    /// <summary>
    /// usati per tener conto della dimensione totale man mano si posizionano i background,
    /// in modo da non andare a misurare ogni volta con i gameObject
    /// </summary>
    /// 
    Vector2 dira;
   
    public override void OnInspectorGUI()
    {
        ScreenLimit screenLimit = (ScreenLimit)target;
        
        DrawDefaultInspector();

        //Handles.DrawLine(screenLimit.upDx, screenLimit.downDx);
    }


    public void OnSceneGUI()
    {
        ScreenLimit screenLimit = (ScreenLimit)target;

        Handles.DrawLine(screenLimit.upDx, screenLimit.downDx);
        Handles.DrawLine(screenLimit.downDx, screenLimit.downSx);
        Handles.DrawLine(screenLimit.downSx, screenLimit.upSx);
        Handles.DrawLine(screenLimit.upSx, screenLimit.upDx);
        
    }



}
