using System;

namespace Cosmos.IL2CPU.Profiler.IL
{
	[Cosmos.IL2CPU.OpCode(ILOp.Code.Not)]
	public class Not: ILOpCode
	{



		#region Old code
		// using System;
		// 
		// using CPUx86 = Indy.IL2CPU.Assembler.X86;
		// 
		// namespace Indy.IL2CPU.IL.X86 {
		// 	[Cosmos.IL2CPU.OpCode(ILOp.Code.Not)]
		// 	public class Not: ILOpCode {
		// 		public Not(ILReader aReader, MethodInformation aMethodInfo)
		// 			: base(aReader, aMethodInfo) {
		// 		}
		// 		public override void DoAssemble() {
		// 			new CPUx86.Pop{DestinationReg=CPUx86.Registers.EAX};
		//             new CPUx86.Not { DestinationReg = CPUx86.Registers.EAX };
		//             new CPUx86.Push { DestinationReg = CPUx86.Registers.EAX };
		// 		}
		// 	}
		// }
		#endregion
	}
}
