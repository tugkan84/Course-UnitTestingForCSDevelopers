
using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error) {
            if (string.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;

            // Write the log to a storage
            // ...

            OnErrorLogged(Guid.NewGuid());
        }
        
        /* private method being tested through the 'Log' public method. */
        private void OnErrorLogged(Guid errorId) {
            ErrorLogged?.Invoke(this, errorId);
        }
    }
}