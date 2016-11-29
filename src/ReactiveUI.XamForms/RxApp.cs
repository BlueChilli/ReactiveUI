using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI
{
    public static partial class RxApp
    {
        public static void InitReactiveUI()
        {
            ReactiveList.ConfigureStrongReferences();
        }
    }
}
