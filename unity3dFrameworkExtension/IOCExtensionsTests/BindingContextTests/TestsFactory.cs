﻿using System;
using u3dExtensions.IOC;

namespace u3dExtensions.Tests.BindingContextTets
{
	public static class TestsFactory
	{
		//static BindingContext m_context 
		public static IBindingContext BindingContext ()
		{
			return u3dExtensions.IOC.BindingContext.Create();
		}
	}
}

