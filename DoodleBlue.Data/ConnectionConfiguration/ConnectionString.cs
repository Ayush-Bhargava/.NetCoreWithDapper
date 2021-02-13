using System;
using System.Collections.Generic;
using System.Text;

namespace DoodleBlue.Data.ConnectionConfiguration
{
    public sealed class ConnectionString : IConnectionString
    {
        //private readonly ConnectionStrings _ConnectionStrings;
        //public ConnectionString(IOption<ConnectionStrings> ConnectionStrings)
        //{
        //    _ConnectionStrings = ConnectionConfiguration.Value;
        //}

        //public ConnectionStrings()
        //{
        //    public string DoodleBlueConnection { get; set; }
        //}
        public ConnectionString(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
