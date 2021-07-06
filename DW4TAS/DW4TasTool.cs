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

namespace DW4TAS
{
	[ExternalTool("MyTool")]
	public partial class DW4TasTool : Form, IExternalToolForm
	{
		public DW4TasTool()
		{
			InitializeComponent();
		}

		public void UpdateValues(ToolFormUpdateType type)
		{
			
		}

		public void Restart()
		{
			
		}

		public bool AskSaveChanges() => true;

		public virtual bool IsActive => IsHandleCreated && !IsDisposed;
		public virtual bool IsLoaded => IsActive;
	}
}
