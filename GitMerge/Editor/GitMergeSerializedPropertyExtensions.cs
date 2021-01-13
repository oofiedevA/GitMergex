﻿using UnityEngine;
using UnityEditor;

public static class GitMergeSerializedPropertyExtensions
{
	public static object GetValue(this SerializedProperty p, bool forComparison = false)
    {
        switch(p.propertyType)
        {
            case SerializedPropertyType.AnimationCurve:
                return p.animationCurveValue;
            case SerializedPropertyType.ArraySize:
                return 0; //TODO: erm
            case SerializedPropertyType.Boolean:
                return p.boolValue;
            case SerializedPropertyType.Bounds:
                return p.boundsValue;
            case SerializedPropertyType.Character:
                return p.stringValue; //TODO: might be bullshit
            case SerializedPropertyType.Color:
                return p.colorValue;
            case SerializedPropertyType.Enum:
                return p.enumValueIndex;
            case SerializedPropertyType.Float:
                return p.floatValue;
            case SerializedPropertyType.Generic:
                return 0; //TODO: erm
            case SerializedPropertyType.Gradient:
                return 0; //TODO: erm
            case SerializedPropertyType.Integer:
                return p.intValue;
            case SerializedPropertyType.LayerMask:
                return p.intValue;
            case SerializedPropertyType.ObjectReference:
                if(forComparison)
                {
                    return ObjectIDFinder.GetIdentifierFor(p.objectReferenceValue);
                }
                else
                {
                    return p.objectReferenceValue;
                }
            case SerializedPropertyType.Quaternion:
                return p.quaternionValue;
            case SerializedPropertyType.Rect:
                return p.rectValue;
            case SerializedPropertyType.String:
                return p.stringValue;
            case SerializedPropertyType.Vector2:
                return p.vector2Value;
            case SerializedPropertyType.Vector3:
                return p.vector3Value;
            case SerializedPropertyType.Vector4:
                return p.vector4Value;
            default:
                return 0;
        }
    }

    public static void SetValue(this SerializedProperty p, object value)
    {
        switch(p.propertyType)
        {
            case SerializedPropertyType.AnimationCurve:
                p.animationCurveValue = value as AnimationCurve;
                break;
            case SerializedPropertyType.ArraySize:
                //TODO: erm
                break;
            case SerializedPropertyType.Boolean:
                p.boolValue = (bool)value;
                break;
            case SerializedPropertyType.Bounds:
                p.boundsValue = (Bounds)value;
                break;
            case SerializedPropertyType.Character:
                p.stringValue = (string)value; //TODO: might be bullshit
                break;
            case SerializedPropertyType.Color:
                p.colorValue = (Color)value;
                break;
            case SerializedPropertyType.Enum:
                p.enumValueIndex = (int)value;
                break;
            case SerializedPropertyType.Float:
                p.floatValue = (float)value;
                break;
            case SerializedPropertyType.Generic:
                //TODO: erm
                break;
            case SerializedPropertyType.Gradient:
                //TODO: erm
                break;
            case SerializedPropertyType.Integer:
                p.intValue = (int)value;
                break;
            case SerializedPropertyType.LayerMask:
                p.intValue = (int)value;
                break;
            case SerializedPropertyType.ObjectReference:
                p.objectReferenceValue = value as Object;
                break;
            case SerializedPropertyType.Quaternion:
                p.quaternionValue = (Quaternion)value;
                break;
            case SerializedPropertyType.Rect:
                p.rectValue = (Rect)value;
                break;
            case SerializedPropertyType.String:
                p.stringValue = (string)value;
                break;
            case SerializedPropertyType.Vector2:
                p.vector2Value = (Vector2)value;
                break;
            case SerializedPropertyType.Vector3:
                p.vector3Value = (Vector3)value;
                break;
            case SerializedPropertyType.Vector4:
                p.vector4Value = (Vector4)value;
                break;
            default:
                break;
        }
    }

    public static string GetPlainName(this SerializedProperty p)
    {
        var s = p.name;
        var i = s.IndexOf('_');
        if(i >= 0)
        {
            s = s.Substring(i + 1);
        }
        return s;
    }
}
