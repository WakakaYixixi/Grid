using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

namespace Pathea.UISystemNs.Grid
{
    public class GridPage : MonoBehaviour
    {
        public System.Action<int> OnClick; 
        public List<GridIcon> allIcons;
        public int curPage;

        private void Start()
        {
            for (int i = 0; i < allIcons.Count; i++)
            {
                allIcons[i].onClick = ClickIcon;
            }
        }

        public void ClickIcon(int index)
        {
            if (OnClick != null)
            {
                OnClick(index + curPage * allIcons.Count);
            }
        }

        [ExposeMethod]
        public void GetAllChildrenAsIcon()
        {
            allIcons = new List<GridIcon>();
            GridIcon[] icons = GetComponentsInChildren<GridIcon>();
            for (int i = 0; i < icons.Length; i++)
            {
                allIcons.Add(icons[i]);
                icons[i].index = i;
            }
        }
    }
}