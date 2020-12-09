﻿using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class RepulserView : MonoBehaviour
{
    [SerializeField] private Button addButton;
    [SerializeField] private Button saveButton;
    [SerializeField] private RectTransform scrollViewParentTransform;

    [SerializeField] private PulseSettingPresenter pulseSettingPrefab;

    public IObservable<Unit> OnAddButtonClickedAsObservable => addButton.OnClickAsObservable();
    public IObservable<Unit> OnSaveButtonClickedAsObservable => saveButton.OnClickAsObservable();
    
    public PulseSettingPresenter AddPulser()
    {
        return Instantiate(pulseSettingPrefab, scrollViewParentTransform);
    }
}