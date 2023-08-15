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
    /// <param name="state">RiftMAN's current state</param>
    public abstract void Update(RiftMANState state);

    /// <summary>
    /// Method that is called when the mod is enabled, before the first time it is updated.
    /// </summary>
    /// <param name="state">RiftMAN's current state</param>
    public abstract void Start(RiftMANState state);

    /// <summary>
    /// Method that is called when the mod is disabled.
    /// </summary>
    /// <param name="state">RiftMAN's current state</param>
    public abstract void Stop(RiftMANState state);

    /// <summary>
    /// How long to wait between updates of this script, in milliseconds. Default is 16.
    /// </summary>
    public virtual int Interval => 16;
}
