using System;
using System.Windows.Forms;

namespace CacheMon
{
	public static partial class Runtime
	{

		public static class Var
		{
			public static double PhysTotalMem { get; set; }         // physical total
			public static double PhysInUseMem { get; set; }          // physical free
			public static double PhysFreeMem { get; set; }
			public static double PhysUnusedMem { get; set; }
			public static double CommitTotal { get; set; }
			public static double KernelTotalMem { get; set; }              // kernal total (paged + nonpaged)
			public static double KernelVirtMem { get; set; }
			public static double KernelPhysMem { get; set; }
			public static double SystemCacheMem { get; set; }           // standby + working set 
			public static double SystemPageSize { get; set; }           // System Memory Page Size (2^20)
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
