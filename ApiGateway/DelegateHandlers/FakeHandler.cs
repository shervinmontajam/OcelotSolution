using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ApiGateway.DelegateHandlers
{
    public class FakeHandler : DelegatingHandler
    {
        private readonly ILogger<FakeHandler> _logger;

        public FakeHandler(ILogger<FakeHandler> logger)
        {
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //do stuff and optionally call the base handler..

            _logger.LogInformation("Logged here: "+ request.RequestUri.AbsolutePath);

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
