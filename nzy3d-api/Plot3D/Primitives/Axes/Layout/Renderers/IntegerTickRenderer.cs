
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace nzy3D.Plot3D.Primitives.Axes.Layout.Renderers
{

	public class IntegerTickRenderer : ITickRenderer
	{

		public string Format(float value)
		{
			return Convert.ToInt32(value).ToString();
		}

	}

}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
