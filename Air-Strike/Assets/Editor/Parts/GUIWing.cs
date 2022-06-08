using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Wing))]
public class GUIWing : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Wing wing = (Wing)target;

        Direction wingDirection = (Direction)EditorGUILayout.EnumPopup("Direction", wing.Direction);
        if (wingDirection != wing.Direction)
            wing.Direction = wingDirection;
    }
}
