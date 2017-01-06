using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Pathea.UISystemNs.Grid
{
    public class GridIconWithNum : GridIcon
    {
        public Text num;
        public override void Enable()
        {
            base.Enable();
            num.gameObject.SetActive(true);
        }

        public override void Disable()
        {
            base.Disable();
            num.gameObject.SetActive(false);
        }
    }
}