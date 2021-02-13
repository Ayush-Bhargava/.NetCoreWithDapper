using System;
using System.Collections.Generic;
using System.Text;

namespace DoodleBlue.Data.ConnectionConfiguration
{
    public sealed class ConnectionString : IConnectionString
    {
        public ConnectionString(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
