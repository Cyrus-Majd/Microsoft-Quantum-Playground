//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Bell\",\"Name\":\"SetQubitState\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\cyrus\\\\Desktop\\\\Gitz\\\\Microsoft-Quantum-Playground\\\\Bell\\\\Program.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Bell\",\"Name\":\"SetQubitState\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\cyrus\\\\Desktop\\\\Gitz\\\\Microsoft-Quantum-Playground\\\\Bell\\\\Program.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Bell\",\"Name\":\"TestBellState\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":17,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\cyrus\\\\Desktop\\\\Gitz\\\\Microsoft-Quantum-Playground\\\\Bell\\\\Program.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Bell\",\"Name\":\"TestBellState\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\cyrus\\\\Desktop\\\\Gitz\\\\Microsoft-Quantum-Playground\\\\Bell\\\\Program.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Bell
{
    [SourceLocation("C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs", OperationFunctor.Body, 12, 22)]
    public partial class SetQubitState : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public SetQubitState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "SetQubitState";
        String ICallable.FullName => "Bell.SetQubitState";
        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> __Body__ => (__in__) =>
        {
            var (desired,target) = __in__;
#line 13 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
            if ((desired != Microsoft__Quantum__Intrinsic__M.Apply(target)))
            {
#line 14 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__((Result,Qubit) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit target)
        {
            return __m__.Run<SetQubitState, (Result,Qubit), QVoid>((desired, target));
        }
    }

    [SourceLocation("C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs", OperationFunctor.Body, 22, -1)]
    public partial class TestBellState : Operation<(Int64,Result), (Int64,Int64,Int64,Int64)>, ICallable
    {
        public TestBellState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Result)>, IApplyData
        {
            public In((Int64,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestBellState";
        String ICallable.FullName => "Bell.TestBellState";
        public static EntryPointInfo<(Int64,Result), (Int64,Int64,Int64,Int64)> Info => new EntryPointInfo<(Int64,Result), (Int64,Int64,Int64,Int64)>(typeof(TestBellState));
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> SetQubitState__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        public override Func<(Int64,Result), (Int64,Int64,Int64,Int64)> __Body__ => (__in__) =>
        {
            var (count,initial) = __in__;
#line 23 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
            var numOnesQ1 = 0L;
#line 24 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
            var numOnesQ2 = 0L;
#line hidden
            {
#line 27 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                var (q1,q2) = (Allocate__.Apply(), Allocate__.Apply());
#line hidden
                bool __arg1__ = true;
                try
                {
#line 28 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                    foreach (var test in new QRange(1L, count))
#line hidden
                    {
#line 29 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                        SetQubitState__.Apply((initial, q1));
#line 30 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                        SetQubitState__.Apply((Result.Zero, q2));
#line 33 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                        Microsoft__Quantum__Intrinsic__H.Apply(q1);
#line 36 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                        Microsoft__Quantum__Intrinsic__CNOT.Apply((q1, q2));
#line 39 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                        var resultQ1 = Microsoft__Quantum__Intrinsic__M.Apply(q1);
#line 40 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                        var resultQ2 = Microsoft__Quantum__Intrinsic__M.Apply(q2);
#line 43 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                        if ((resultQ1 == Result.One))
                        {
#line 44 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                            numOnesQ1 = (numOnesQ1 + 1L);
                        }

#line 46 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                        if ((resultQ2 == Result.One))
                        {
#line 47 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                            numOnesQ2 = (numOnesQ2 + 1L);
                        }
                    }

#line 52 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                    SetQubitState__.Apply((Result.Zero, q1));
#line 53 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                    SetQubitState__.Apply((Result.Zero, q2));
#line 57 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                    Message__.Apply("q1: Zero, One  q2: Zero, One");
#line 58 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\Bell\\Program.qs"
                    return ((count - numOnesQ1), numOnesQ1, (count - numOnesQ2), numOnesQ2);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(q1);
#line hidden
                        Release__.Apply(q2);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.SetQubitState__ = this.__Factory__.Get<ICallable<(Result,Qubit), QVoid>>(typeof(SetQubitState));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __DataIn__((Int64,Result) data) => new In(data);
        public override IApplyData __DataOut__((Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<TestBellState, (Int64,Result), (Int64,Int64,Int64,Int64)>((count, initial));
        }
    }
}