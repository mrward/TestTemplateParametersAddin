//
// ProjectTemplateWizardPage.cs
//
// Author:
//       Matt Ward <matt.ward@xamarin.com>
//
// Copyright (c) 2015 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using System;
using MonoDevelop.Ide.Templates;
using MonoDevelop.Core;

namespace TestTemplateParametersAddin
{
	public class ProjectTemplateWizardPage : WizardPage
	{
		GtkProjectConfigurationWidget view;
		ProjectTemplateWizard wizard;

		public ProjectTemplateWizardPage (ProjectTemplateWizard wizard)
		{
			this.wizard = wizard;
		}

		protected override object CreateNativeWidget<T> ()
		{
			if (view == null) {
				view = new GtkProjectConfigurationWidget ();
				view.WizardPage = this;
			}
			return view;
		}

		public override string Title {
			get { return GettextCatalog.GetString ("Add your template parameters"); }
		}

		public void UpdateTemplateParameters (string text)
		{
			wizard.Parameters.Clear ();
			foreach (TemplateParameter parameter in TemplateParameter.CreateParameters (text)) {
				if (parameter.IsValid) {
					wizard.Parameters [parameter.Name] = parameter.Value;
				}
			}
		}
	}
}

