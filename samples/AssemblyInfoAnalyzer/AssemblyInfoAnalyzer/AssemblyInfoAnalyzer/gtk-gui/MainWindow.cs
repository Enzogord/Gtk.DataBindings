
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Button buttonOpen;
	
	private global::Gtk.HSeparator hseparator1;
	
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.HPaned hpaned1;
	
	private global::Gtk.HPaned hpaned2;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.DataBindings.DataTreeView AssemblyListTree;
	
	private global::Gtk.VBox vbox4;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	
	private global::Gtk.DataBindings.DataTreeView TypeTree;
	
	private global::Gtk.VBox vbox5;
	
	private global::Gtk.Label InfoLabel;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow2;
	
	private global::Gtk.DataBindings.DataTreeView InfoTree;
	
	private global::Gtk.DataBindings.DataVBox DescriptionBox;
	
	private global::Gtk.DataBindings.DataHBox datahbox1;
	
	private global::Gtk.DataBindings.DataLabel datalabel1;
	
	private global::Gtk.DataBindings.DataHBox datahbox2;
	
	private global::Gtk.DataBindings.DataImage dataimage1;
	
	private global::Gtk.DataBindings.DataLabel datalabel2;
	
	private global::Gtk.HSeparator hseparator2;
	
	private global::Gtk.DataBindings.DataLabel datalabel3;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonOpen = new global::Gtk.Button ();
		this.buttonOpen.CanFocus = true;
		this.buttonOpen.Name = "buttonOpen";
		this.buttonOpen.UseStock = true;
		this.buttonOpen.UseUnderline = true;
		this.buttonOpen.Label = "gtk-open";
		this.hbox1.Add (this.buttonOpen);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonOpen]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		w2.Padding = ((uint)(2));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.vbox1.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 378;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.hpaned2 = new global::Gtk.HPaned ();
		this.hpaned2.CanFocus = true;
		this.hpaned2.Name = "hpaned2";
		this.hpaned2.Position = 210;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xalign = 0F;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Assemblies");
		this.vbox3.Add (this.label1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.AssemblyListTree = new global::Gtk.DataBindings.DataTreeView ();
		this.AssemblyListTree.CanFocus = true;
		this.AssemblyListTree.Name = "AssemblyListTree";
		this.AssemblyListTree.CursorPointsEveryType = false;
		this.AssemblyListTree.InheritedDataSource = false;
		this.AssemblyListTree.InheritedBoundaryDataSource = false;
		this.AssemblyListTree.InheritedDataSource = false;
		this.AssemblyListTree.InheritedBoundaryDataSource = false;
		this.AssemblyListTree.ColumnMappings = "{System.Data.Bindings.AssemblyDescription} Name[Assembly]";
		this.GtkScrolledWindow.Add (this.AssemblyListTree);
		this.vbox3.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
		w6.Position = 1;
		this.hpaned2.Add (this.vbox3);
		global::Gtk.Paned.PanedChild w7 = ((global::Gtk.Paned.PanedChild)(this.hpaned2 [this.vbox3]));
		w7.Resize = false;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 0F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Types");
		this.vbox4.Add (this.label2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label2]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.TypeTree = new global::Gtk.DataBindings.DataTreeView ();
		this.TypeTree.CanFocus = true;
		this.TypeTree.Name = "TypeTree";
		this.TypeTree.CursorPointsEveryType = false;
		this.TypeTree.InheritedDataSource = false;
		this.TypeTree.InheritedBoundaryDataSource = false;
		this.TypeTree.InheritedDataSource = false;
		this.TypeTree.InheritedBoundaryDataSource = false;
		this.TypeTree.ColumnMappings = "{System.Data.Bindings.IDevelopmentInformation} Name[Name]";
		this.GtkScrolledWindow1.Add (this.TypeTree);
		this.vbox4.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow1]));
		w10.Position = 1;
		this.hpaned2.Add (this.vbox4);
		this.hpaned1.Add (this.hpaned2);
		global::Gtk.Paned.PanedChild w12 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.hpaned2]));
		w12.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.InfoLabel = new global::Gtk.Label ();
		this.InfoLabel.Name = "InfoLabel";
		this.InfoLabel.Xalign = 0F;
		this.InfoLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Development informations");
		this.vbox5.Add (this.InfoLabel);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.InfoLabel]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.InfoTree = new global::Gtk.DataBindings.DataTreeView ();
		this.InfoTree.CanFocus = true;
		this.InfoTree.Name = "InfoTree";
		this.InfoTree.CursorPointsEveryType = false;
		this.InfoTree.InheritedDataSource = false;
		this.InfoTree.InheritedBoundaryDataSource = false;
		this.InfoTree.InheritedDataSource = false;
		this.InfoTree.InheritedBoundaryDataSource = false;
		this.InfoTree.ColumnMappings = "{System.Data.Bindings.DevelopmentInformationItem} Name[Name]";
		this.GtkScrolledWindow2.Add (this.InfoTree);
		this.vbox5.Add (this.GtkScrolledWindow2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow2]));
		w15.Position = 1;
		this.hpaned1.Add (this.vbox5);
		this.hbox5.Add (this.hpaned1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.hpaned1]));
		w17.Position = 0;
		this.vbox1.Add (this.hbox5);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox5]));
		w18.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.DescriptionBox = new global::Gtk.DataBindings.DataVBox ();
		this.DescriptionBox.Name = "DescriptionBox";
		this.DescriptionBox.Spacing = 6;
		this.DescriptionBox.InheritedDataSource = false;
		this.DescriptionBox.InheritedBoundaryDataSource = false;
		this.DescriptionBox.InheritedDataSource = false;
		this.DescriptionBox.InheritedBoundaryDataSource = false;
		// Container child DescriptionBox.Gtk.Box+BoxChild
		this.datahbox1 = new global::Gtk.DataBindings.DataHBox ();
		this.datahbox1.Name = "datahbox1";
		this.datahbox1.Spacing = 12;
		this.datahbox1.InheritedDataSource = true;
		this.datahbox1.InheritedBoundaryDataSource = false;
		this.datahbox1.InheritedDataSource = true;
		this.datahbox1.InheritedBoundaryDataSource = false;
		// Container child datahbox1.Gtk.Box+BoxChild
		this.datalabel1 = new global::Gtk.DataBindings.DataLabel ();
		this.datalabel1.Name = "datalabel1";
		this.datalabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("datalabel1");
		this.datalabel1.InheritedDataSource = true;
		this.datalabel1.Mappings = "Status";
		this.datalabel1.InheritedBoundaryDataSource = false;
		this.datalabel1.Important = false;
		this.datalabel1.InheritedDataSource = true;
		this.datalabel1.Mappings = "Status";
		this.datalabel1.InheritedBoundaryDataSource = false;
		this.datahbox1.Add (this.datalabel1);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.datalabel1]));
		w19.Position = 0;
		w19.Expand = false;
		w19.Fill = false;
		// Container child datahbox1.Gtk.Box+BoxChild
		this.datahbox2 = new global::Gtk.DataBindings.DataHBox ();
		this.datahbox2.Name = "datahbox2";
		this.datahbox2.Spacing = 6;
		this.datahbox2.InheritedDataSource = true;
		this.datahbox2.InheritedBoundaryDataSource = false;
		this.datahbox2.InheritedDataSource = true;
		this.datahbox2.InheritedBoundaryDataSource = false;
		// Container child datahbox2.Gtk.Box+BoxChild
		this.dataimage1 = new global::Gtk.DataBindings.DataImage ();
		this.dataimage1.Name = "dataimage1";
		this.dataimage1.InheritedDataSource = true;
		this.dataimage1.Mappings = "Status";
		this.dataimage1.InheritedBoundaryDataSource = false;
		this.dataimage1.InheritedBoundaryDataSource = false;
		this.dataimage1.InheritedDataSource = true;
		this.dataimage1.Mappings = "Status";
		this.datahbox2.Add (this.dataimage1);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.datahbox2 [this.dataimage1]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child datahbox2.Gtk.Box+BoxChild
		this.datalabel2 = new global::Gtk.DataBindings.DataLabel ();
		this.datalabel2.Name = "datalabel2";
		this.datalabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("datalabel2");
		this.datalabel2.UseMarkup = true;
		this.datalabel2.InheritedDataSource = true;
		this.datalabel2.Mappings = "Name";
		this.datalabel2.InheritedBoundaryDataSource = false;
		this.datalabel2.Important = true;
		this.datalabel2.InheritedDataSource = true;
		this.datalabel2.Mappings = "Name";
		this.datalabel2.InheritedBoundaryDataSource = false;
		this.datahbox2.Add (this.datalabel2);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.datahbox2 [this.datalabel2]));
		w21.Position = 1;
		w21.Expand = false;
		w21.Fill = false;
		this.datahbox1.Add (this.datahbox2);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.datahbox2]));
		w22.Position = 1;
		w22.Expand = false;
		w22.Fill = false;
		this.DescriptionBox.Add (this.datahbox1);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.DescriptionBox [this.datahbox1]));
		w23.Position = 0;
		// Container child DescriptionBox.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator ();
		this.hseparator2.Name = "hseparator2";
		this.DescriptionBox.Add (this.hseparator2);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.DescriptionBox [this.hseparator2]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		// Container child DescriptionBox.Gtk.Box+BoxChild
		this.datalabel3 = new global::Gtk.DataBindings.DataLabel ();
		this.datalabel3.Name = "datalabel3";
		this.datalabel3.Xalign = 0F;
		this.datalabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("datalabel3");
		this.datalabel3.Wrap = true;
		this.datalabel3.Selectable = true;
		this.datalabel3.InheritedDataSource = true;
		this.datalabel3.Mappings = "Description";
		this.datalabel3.InheritedBoundaryDataSource = false;
		this.datalabel3.Important = false;
		this.datalabel3.InheritedDataSource = true;
		this.datalabel3.Mappings = "Description";
		this.datalabel3.InheritedBoundaryDataSource = false;
		this.DescriptionBox.Add (this.datalabel3);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.DescriptionBox [this.datalabel3]));
		w25.Position = 2;
		this.vbox1.Add (this.DescriptionBox);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.DescriptionBox]));
		w26.Position = 3;
		w26.Expand = false;
		w26.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 903;
		this.DefaultHeight = 510;
		this.DescriptionBox.Hide ();
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonOpen.Clicked += new global::System.EventHandler (this.OnButtonOpenClicked);
		this.AssemblyListTree.CursorChanged += new global::System.EventHandler (this.OnAssemblyListTreeCursorChanged);
		this.AssemblyListTree.IsVisibleInFilter += new global::System.Data.Bindings.IsVisibleInFilterEvent (this.OnAssemblyListTreeIsVisibleInFilter);
		this.AssemblyListTree.CellDescription += new global::Gtk.DataBindings.CellDescriptionEvent (this.OnAssemblyListTreeCellDescription);
		this.TypeTree.CursorChanged += new global::System.EventHandler (this.OnTypeTreeCursorChanged);
		this.TypeTree.CellDescription += new global::Gtk.DataBindings.CellDescriptionEvent (this.OnTypeTreeCellDescription);
		this.InfoTree.CellDescription += new global::Gtk.DataBindings.CellDescriptionEvent (this.OnInfoTreeCellDescription);
		this.InfoTree.CursorChanged += new global::System.EventHandler (this.OnInfoTreeCursorChanged);
	}
}
