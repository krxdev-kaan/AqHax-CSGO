using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.Objects.Classes;

namespace AqHaxCSGO.MemoryManagers
{
	/**
	 * Fully Remade And Ported Code From A Java Project
	 * So Credits To @Jonatino
	 */
    static class NetvarManager
    {
		public static List<NetVar> netvarList = new List<NetVar>();
		private static CClass clientClass = new CClass();
		private static RecvTable table = new RecvTable();
		private static RecvProp prop = new RecvProp();

		public static void LoadOffsets()
		{
			int startingPoint = Memory.clientBase + SigScanner.ClientSigScan(Encoding.ASCII.GetBytes("DT_TEWorldDecal"));
			int secondPoint = SigScanner.ClientSigScan(BitConverter.GetBytes(startingPoint));
			startingPoint = Memory.Read<int>(Memory.clientBase + 0x2B + secondPoint);

			for (clientClass.SetBase(startingPoint); clientClass.Readable(); clientClass.SetBase(clientClass.Next))
			{
				table.SetBase(clientClass.Table);
				string tableName = table.TableName;
				if (tableName.Length > 0 && table.PropCount > 0)
				{
					ScanTable(table, 0, tableName);
				}
			}
		}

		public static int GetOffsetByName(string tableName, string propName) 
		{
			foreach (NetVar n in netvarList) 
			{
				if (n.ClassName == tableName && n.PropName == propName) 
				{
					return n.Offset;
				}
			}
			return -1;
		}

		private static void ScanTable(RecvTable table, int offset, String className)
		{
			for (int i = 0; i < table.PropCount; i++)
			{
				prop.SetBase(table.PropForId(i));
				prop.SetOffset(offset);

				string propName = prop.Name;
				int propOffset = prop.Offset;

				if (Char.IsDigit(propName[0]))
				{
					continue;
				}

				if (propOffset != 0x0)
				{
					netvarList.Add(new NetVar(className, propName, propOffset));
				}

				int child = prop.Table;
				if (child == 0)
				{
					continue;
				}
				ScanTable(new RecvTable().SetBase(child), propOffset, className);
			}
		}
	}

	class NetVar
	{
		public string ClassName { get; private set; }
		public string PropName { get; private set; }
		public int Offset { get; private set; }

		public NetVar(string className, string propName, int offset)
		{
			this.ClassName = className;
			this.PropName = propName;
			this.Offset = offset;
		}
	}

	class RecvProp
	{
		private int this_pointer;
		private int offset;

		public RecvProp SetBase(int this_pointer)
		{
			this.this_pointer = this_pointer;
			return this;
		}

		public RecvProp SetOffset(int newOffset)
		{
			offset = newOffset;
			return this;
		}

		public int Table
		{
			get
			{
				return Memory.Read<int>(this_pointer + 0x28);
			}
		}

		public string Name
		{
			get
			{
				return Memory.ReadString(Memory.Read<int>(this_pointer), 64, Encoding.ASCII);
			}
		}

		public int Offset
		{
			get
			{
				return offset + Memory.Read<int>(this_pointer + 0x2C);
			}
		}

		public int Type
		{
			get
			{
				return Memory.Read<int>(this_pointer + 0x4);
			}
		}

		public int Elements
		{
			get
			{
				return Memory.Read<int>(this_pointer + 0x34);
			}
		}

		public int StringLength
		{
			get
			{
				return Memory.Read<int>(this_pointer + 0xC);
			}
		}
	}
	class RecvTable
	{
		private int this_pointer;

		public RecvTable SetBase(int this_pointer)
		{
			this.this_pointer = this_pointer;
			return this;
		}

		public int PropForId(int id)
		{
			return Memory.Read<int>(this_pointer) + (id * 0x3C);
		}

		public string TableName
		{
			get
			{
				return Memory.ReadString(Memory.Read<int>(this_pointer + 0xC), 32, Encoding.ASCII);
			}
		}

		public int PropCount
		{
			get
			{
				return Memory.Read<int>(this_pointer + 0x4);
			}
		}

		public bool Readable
		{
			get
			{
				return Memory.CanRead(this_pointer, 0x10);
			}
		}
	}
}
