using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Core.Delegates
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    public delegate void IntervalElapsedHandler(object sender);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="state"></param>
    public delegate void TickingStateChangedHandler(bool state);
}
