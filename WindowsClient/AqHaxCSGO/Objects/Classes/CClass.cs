using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.MemoryManagers;

namespace AqHaxCSGO.Objects.Classes
{

	class CClass
	{
		private int this_pointer;

		public CClass SetBase(int this_pointer)
		{
			this.this_pointer = this_pointer;
			return this;
		}

		public int ClassID
		{
			get
			{
				return Memory.Read<int>(this_pointer + 0x14);
			}
		}

		public string ClassName
		{
			get
			{
				return Memory.ReadString(Memory.Read<int>(this_pointer + 0x8), 64, Encoding.UTF8);
			}
		}

		public int Next
		{
			get
			{
				return Memory.Read<int>(this_pointer + 0x10);
			}
		}

		public int Table
		{
			get
			{
				return Memory.Read<int>(this_pointer + 0xC);
			}
		}

		public bool Readable()
		{
			return Memory.CanRead(this_pointer, 0x28);
		}
	}
}
