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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"quantumRandomNumberGenerator\",\"Name\":\"SampleQuantumRandomNumberGenerator\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":7,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\cyrus\\\\Desktop\\\\Gitz\\\\Microsoft-Quantum-Playground\\\\helloQuantumWorld\\\\quantumRandomNumberGenerator\\\\Program.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"quantumRandomNumberGenerator\",\"Name\":\"SampleQuantumRandomNumberGenerator\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\cyrus\\\\Desktop\\\\Gitz\\\\Microsoft-Quantum-Playground\\\\helloQuantumWorld\\\\quantumRandomNumberGenerator\\\\Program.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
#line hidden
namespace quantumRandomNumberGenerator
{
    [SourceLocation("C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\helloQuantumWorld\\quantumRandomNumberGenerator\\Program.qs", OperationFunctor.Body, 9, -1)]
    public partial class SampleQuantumRandomNumberGenerator : Operation<QVoid, Result>, ICallable
    {
        public SampleQuantumRandomNumberGenerator(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleQuantumRandomNumberGenerator";
        String ICallable.FullName => "quantumRandomNumberGenerator.SampleQuantumRandomNumberGenerator";
        public static EntryPointInfo<QVoid, Result> Info => new EntryPointInfo<QVoid, Result>(typeof(SampleQuantumRandomNumberGenerator));
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

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        public override Func<QVoid, Result> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 11 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\helloQuantumWorld\\quantumRandomNumberGenerator\\Program.qs"
                var q = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 14 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\helloQuantumWorld\\quantumRandomNumberGenerator\\Program.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(q);
#line 16 "C:\\Users\\cyrus\\Desktop\\Gitz\\Microsoft-Quantum-Playground\\helloQuantumWorld\\quantumRandomNumberGenerator\\Program.qs"
                    return Microsoft__Quantum__Intrinsic__M.Apply(q);
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
                        Release__.Apply(q);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<SampleQuantumRandomNumberGenerator, QVoid, Result>(QVoid.Instance);
        }
    }
}