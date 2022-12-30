using Demo.TimerTrigger.Service.Abstraction;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using static Demo.TimerTrigger.Comman.Constants;
namespace Demo.TimerTrigger.Function
{
    public class TimerTriggerFunction
    {
        private readonly ILogger<TimerTriggerFunction> _logger;
        private readonly IDataService _dataService;

        public TimerTriggerFunction(IDataService dataService, ILogger<TimerTriggerFunction> logger)
        {
            _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        [FunctionName(FUNCTION_NAME)]
        public async Task Run([TimerTrigger("%CRON_EXPRESSION%", RunOnStartup = true)] TimerInfo myTimer, ILogger log)
        {
            _logger.LogInformation($"{nameof(FUNCTION_NAME)}.{nameof(Run)} called!");
            await _dataService.ProcessData("Function Payload");
            _logger.LogInformation($"{nameof(FUNCTION_NAME)}.{nameof(Run)} Commpleted!");
        }
    }
}
