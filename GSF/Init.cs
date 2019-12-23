using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torch;
using Torch.API;
using Torch.Commands;
using Torch.Commands.Permissions;
using VRage.Game.ModAPI;


namespace GSF
{
    public class OS : TorchPluginBase
    {

        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public override void Init(ITorchBase torch)
        {
            base.Init(torch);
            Log.Info($"Torch Init Complete:{DateTime.Now}");
        }

        [Category("torch")]
        public class commands :CommandModule
        {
            public OS Plugin => (OS)Context.Plugin;

            [Command("Reset", "Resets the server in 1 min")]
            [Permission(MyPromoteLevel.None)]
            public void Reset(string trigger, string bar = null)
            {
                Log.Info("This is a Test from " + Context.Player);
            }
        }
    }
}
