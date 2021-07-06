using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using BizHawk.Emulation.Common;

namespace DW4TAS
{
	[ExternalTool("MyTool")]
	public partial class DW4TasTool : Form, IExternalToolForm
	{
		public DW4TasTool()
		{
			InitializeComponent();
		}

		[RequiredService]
		private IEmulator Emulator { get; set; }

		public void UpdateValues(ToolFormUpdateType type)
		{
			switch (type)
			{
				case ToolFormUpdateType.General:
				case ToolFormUpdateType.PostFrame:
					FrameUpdate();
					break;
			}
		}

		public void Restart()
		{
			
		}

		public bool AskSaveChanges() => true;

		public virtual bool IsActive => IsHandleCreated && !IsDisposed;
		public virtual bool IsLoaded => IsActive;

		private void FrameUpdate()
		{
			TestLabel.Text = Emulator.Frame.ToString();
		}
	}
}
