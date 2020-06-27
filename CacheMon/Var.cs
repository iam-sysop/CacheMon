using System;


namespace CacheMon
{
	public static partial class Runtime
	{

		public static class Var
		{
			public static double PhysTotalMem { get; set; }   
			public static double PhysInUseMem { get; set; }    
			public static double PhysFreeMem { get; set; }
			public static double PhysUnusedMem { get; set; }
			public static double CommitTotal { get; set; }
			public static double KernelTotalMem { get; set; }  
			public static double KernelVirtMem { get; set; }
			public static double KernelPhysMem { get; set; }
			public static double SystemCacheMem { get; set; }   
			public static double SystemPageSize { get; set; }   
			public static double SystemCompressed { get; set; }
			public static double ModifiedCached { get; set; }
			public static double ModifiedInUse { get; set; }

            public static long FlushHistory { get; set; }
			public static DateTime LastFlush { get; set; }

			public static long TrimmedWorkingSets { get; set; }
			public static long LockedWorkingSets { get; set; }

			public static bool IsFlushing { get; set; }
        }
    }
}
