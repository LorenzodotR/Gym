using GymHelper.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GymHelper.Persistence
{
    public class LoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new Logger();
        }

        public void Dispose()
        { }

        private class Logger : ILogger
        {
            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                StandardLogger.LogDebug(formatter(state, exception));
            }

            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }

            protected ILogger _Logger;
            public ILogger StandardLogger
            {
                get
                {
                    if (_Logger == null)
                    {
                        _Logger = ServiceProviderFactory.ServiceProvider.GetService<ILoggerFactory>().CreateLogger(GetType());
                    }
                    return _Logger;
                }
            }
        }
    }
}
