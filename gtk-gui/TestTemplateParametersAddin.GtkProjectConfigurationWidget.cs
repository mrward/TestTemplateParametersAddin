
// This file has been generated by the GUI designer. Do not modify.
namespace TestTemplateParametersAddin
{
	public partial class GtkProjectConfigurationWidget
	{
		private global::Gtk.VBox mainVBox;
		
		private global::Gtk.Label mainLabel;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView parametersTextView;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TestTemplateParametersAddin.GtkProjectConfigurationWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "TestTemplateParametersAddin.GtkProjectConfigurationWidget";
			// Container child TestTemplateParametersAddin.GtkProjectConfigurationWidget.Gtk.Container+ContainerChild
			this.mainVBox = new global::Gtk.VBox ();
			this.mainVBox.Name = "mainVBox";
			this.mainVBox.Spacing = 6;
			this.mainVBox.BorderWidth = ((uint)(50));
			// Container child mainVBox.Gtk.Box+BoxChild
			this.mainLabel = new global::Gtk.Label ();
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Xalign = 0F;
			this.mainLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Template Parameters:");
			this.mainVBox.Add (this.mainLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.mainLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child mainVBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.parametersTextView = new global::Gtk.TextView ();
			this.parametersTextView.Buffer.Text = "AddSystemXml=True\nAddToStringMethod=False\nFoo=test\nBar=abc";
			this.parametersTextView.CanFocus = true;
			this.parametersTextView.Name = "parametersTextView";
			this.parametersTextView.AcceptsTab = false;
			this.GtkScrolledWindow.Add (this.parametersTextView);
			this.mainVBox.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.GtkScrolledWindow]));
			w3.Position = 1;
			this.Add (this.mainVBox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
