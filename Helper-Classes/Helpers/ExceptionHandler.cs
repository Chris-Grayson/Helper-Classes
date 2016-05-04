using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_Classes.Helpers
{
    public static class ExceptionHandler
    {
        /// <summary>
        /// Logs an exception.
        /// </summary>
        /// <param name="e">The exception.</param>
        /// <param name="handled">if set to <c>true</c> [handled].</param>
        public static void LogException(Exception e, bool handled)
        {
            LogException(e, handled ? "Handled exception" : "Unhandled exception");
        }

        /// <summary>
        /// Logs a rethrown exception.
        /// </summary>
        /// <param name="e">The exception.</param>
        public static void LogRethrowException(Exception e)
        {
            LogException(e, "Exception caught and rethrown");
        }

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="e">The exception.</param>
        /// <param name="header">The header.</param>
        private static void LogException(Exception e, string header)
        {
        }
    }
}
