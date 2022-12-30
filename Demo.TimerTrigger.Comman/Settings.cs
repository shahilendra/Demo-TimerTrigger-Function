using Demo.TimerTrigger.Comman.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.TimerTrigger.Comman
{
    public class Settings : ISettings
    {
        public Settings()
        {
            IsEnableLog = Convert.ToBoolean(Environment.GetEnvironmentVariable("IsEnableLog", EnvironmentVariableTarget.Process));

        }
        public bool IsEnableLog { get; set; }
    }
}
