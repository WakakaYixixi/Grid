using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Pathea.UISystemNs.Grid
{
    public abstract class GridIcon : MonoBehaviour
    {
        public Image clickIcon;
        public Action<int> onClick;
        public bool enable;
        public int index;

        public void SetImage(Sprite image)
        {
            if (image == null)
            {
                clickIcon.gameObject.SetActive(false);
            }
            else
            {
                clickIcon.sprite = image;
                if (!clickIcon.gameObject.activeSelf)
                {
                    clickIcon.gameObject.SetActive(true);
                }
            }
        }

        public void Click()
        {
            if (onClick != null)
            {
                onClick(index);
            }
        }

        public virtual void Disable()
        {
            enable = false;
            clickIcon.gameObject.SetActive(false);
        }
        public virtual void Enable()
        {
            enable = true;
            clickIcon.gameObject.SetActive(true);
        }
    }
}