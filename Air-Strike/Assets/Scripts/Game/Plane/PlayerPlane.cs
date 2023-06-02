using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerPlane : MonoBehaviour
{
    [SerializeField] private Properties properties;
    [Space(10)]
    [SerializeField] private GameObject ultimate;

    public Properties Properties
    {
        get { return properties; }
    }

    public GameObject Ultimate
    {
        get { return ultimate; }
    }

    private List<Cockpit> cockpits;
    private List<Wing>    wings;
    private List<Engine>  engines;
    private List<Gun>     guns;

    private void Awake()
    {
        SetAllPlaneParts();
        SetAllPropertiesParts();
    }

    private void SetAllPlaneParts()
    {
        cockpits = GetPlaneParts<Cockpit>();
        wings    = GetPlaneParts<Wing>();
        engines  = GetPlaneParts<Engine>();
        guns     = GetPlaneParts<Gun>();
    }

    private List<T> GetPlaneParts<T>() where T : PlanePart
    {
        List<T> result = new List<T>();
        foreach (Transform child in transform)
        {
            if (child.GetComponent<T>() != null)
                result.Add(child.GetComponent<T>());
        }

        return result;
    }

    private void SetAllPropertiesParts()
    {
        properties = SumPropertiesParts(cockpits.Cast<PlanePart>().ToList())
                   + SumPropertiesParts(wings.Cast<PlanePart>().ToList())
                   + SumPropertiesParts(engines.Cast<PlanePart>().ToList())
                   + SumPropertiesParts(guns.Cast<PlanePart>().ToList());
    }

    private Properties SumPropertiesParts(List<PlanePart> parts)
    {
        Properties sumProperties = new Properties();
        foreach (PlanePart part in parts)
        {
            sumProperties += part.Properties;
        }

        return sumProperties;
    }

    // Combat

    public void Attack()
    {
        foreach (Gun gun in guns)
            gun.Attack();
    }

    public void StopAttack()
    {
        foreach (Gun gun in guns)
            gun.StopAttack();
    }
}