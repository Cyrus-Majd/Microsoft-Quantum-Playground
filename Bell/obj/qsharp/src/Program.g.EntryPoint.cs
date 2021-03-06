//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

namespace Bell
{
    internal class __QsEntryPoint__TestBellState : global::Microsoft.Quantum.EntryPointDriver.IEntryPoint
    {
        public string Name => "Bell.TestBellState";
        public string Summary => "";
        public System.Collections.Generic.IEnumerable<System.CommandLine.Option> Options => new System.CommandLine.Option[] { global::Microsoft.Quantum.EntryPointDriver.Options.CreateOption<Int64>("--" + System.CommandLine.Parsing.StringExtensions.ToKebabCase("count"), ""), global::Microsoft.Quantum.EntryPointDriver.Options.CreateOption<Result>("--" + System.CommandLine.Parsing.StringExtensions.ToKebabCase("initial"), "") };
        private static (Int64,Result) CreateArgument(System.CommandLine.Parsing.ParseResult parseResult) => (parseResult.ValueForOption<Int64>("--" + System.CommandLine.Parsing.StringExtensions.ToKebabCase("count")), parseResult.ValueForOption<Result>("--" + System.CommandLine.Parsing.StringExtensions.ToKebabCase("initial")));
        public System.Threading.Tasks.Task<int> GenerateAzurePayload(System.CommandLine.Parsing.ParseResult parseResult, global::Microsoft.Quantum.EntryPointDriver.GenerateAzurePayloadSettings settings) => global::Microsoft.Quantum.EntryPointDriver.Azure.GenerateAzurePayload(settings, global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("__qsharp_data_qir_v1__.bc") is { } qirStream ? new global::Microsoft.Quantum.EntryPointDriver.QirSubmission(qirStream, "Bell.TestBellState", global::System.Collections.Immutable.ImmutableList.Create<global::Microsoft.Quantum.Runtime.Argument>(new global::Microsoft.Quantum.Runtime.Argument("count", new global::Microsoft.Quantum.Runtime.ArgumentValue.Int(parseResult.ValueForOption<Int64>("--" + System.CommandLine.Parsing.StringExtensions.ToKebabCase("count")))), new global::Microsoft.Quantum.Runtime.Argument("initial", new global::Microsoft.Quantum.Runtime.ArgumentValue.Result(parseResult.ValueForOption<Result>("--" + System.CommandLine.Parsing.StringExtensions.ToKebabCase("initial")))))) : null);
        public System.Threading.Tasks.Task<int> Submit(System.CommandLine.Parsing.ParseResult parseResult, global::Microsoft.Quantum.EntryPointDriver.AzureSettings settings) => global::Microsoft.Quantum.EntryPointDriver.Azure.Submit(settings, new global::Microsoft.Quantum.EntryPointDriver.QSharpSubmission<(Int64,Result), (Int64,Int64,Int64,Int64)>(global::Bell.TestBellState.Info, CreateArgument(parseResult)), global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("__qsharp_data_qir_v1__.bc") is { } qirStream ? new global::Microsoft.Quantum.EntryPointDriver.QirSubmission(qirStream, "Bell.TestBellState", global::System.Collections.Immutable.ImmutableList.Create<global::Microsoft.Quantum.Runtime.Argument>(new global::Microsoft.Quantum.Runtime.Argument("count", new global::Microsoft.Quantum.Runtime.ArgumentValue.Int(parseResult.ValueForOption<Int64>("--" + System.CommandLine.Parsing.StringExtensions.ToKebabCase("count")))), new global::Microsoft.Quantum.Runtime.Argument("initial", new global::Microsoft.Quantum.Runtime.ArgumentValue.Result(parseResult.ValueForOption<Result>("--" + System.CommandLine.Parsing.StringExtensions.ToKebabCase("initial")))))) : null);
        public System.Threading.Tasks.Task<int> Simulate(System.CommandLine.Parsing.ParseResult parseResult, global::Microsoft.Quantum.EntryPointDriver.DriverSettings settings, string simulator) => global::Microsoft.Quantum.EntryPointDriver.Simulation<global::Bell.TestBellState, (Int64,Result), (Int64,Int64,Int64,Int64)>.Simulate(this, CreateArgument(parseResult), settings, simulator);
    }
}