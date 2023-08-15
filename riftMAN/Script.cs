using Microsoft.CSharp;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace riftMAN.Mods;
public abstract class Script
{
    /// <summary>
    /// Method that is called when the script is updated.
    /// </summary>
    public virtual void Update() { }

    /// <summary>
    /// Method that is called when the mod is enabled, before the first time it is updated.
    /// </summary>
    public virtual void Start() { }

    /// <summary>
    /// Method that is called when the mod is disabled.
    /// </summary>
    public virtual void Stop() { }

    /// <summary>
    /// How long to wait between updates of this script, in milliseconds. Default is 16.
    /// </summary>
    public virtual int Interval => 16;

    // RiftMAN's state to be accessed by mod scripts.
    public static RiftMANState State => RiftMANState.Instance;
}
