﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace Layaway
{
    public sealed class ToastHandlerTasks : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            var details = taskInstance.TriggerDetails;
        }
    }
}
