using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace ToastHandlerTasks
{
    public sealed class Toast : IBackgroundTask
    {
        BackgroundTaskDeferral deferral;
        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            deferral = taskInstance.GetDeferral();

            deferral.Complete();
        }
    }
}
