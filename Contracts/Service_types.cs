
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.11.0.3
//   Input filename:  Service.bond
//   Output filename: Service_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace GrpcInterceptorExample.Contracts
{
    using System.Collections.Generic;

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.11.0.3")]
    public partial class SampleRequest
    {
        [global::Bond.Id(0)]
        public string Key { get; set; }

        public SampleRequest()
            : this("GrpcInterceptorExample.Contracts.SampleRequest", "SampleRequest")
        {}

        protected SampleRequest(string fullName, string name)
        {
            Key = "";
        }
    }

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.11.0.3")]
    public partial class SampleResponse
    {
        [global::Bond.Id(0)]
        public string Key { get; set; }

        [global::Bond.Id(1)]
        public int Value { get; set; }

        public SampleResponse()
            : this("GrpcInterceptorExample.Contracts.SampleResponse", "SampleResponse")
        {}

        protected SampleResponse(string fullName, string name)
        {
            Key = "";
        }
    }
} // GrpcInterceptorExample.Contracts
