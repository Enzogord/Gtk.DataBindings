
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.DataBindings.DataVBox datavbox1;
	
	private global::Gtk.DataBindings.DataEntry dataentry1;
	
	private global::Gtk.DataBindings.DataLabel datalabel2;
	
	private global::Gtk.DataBindings.DataLabel datalabel1;
	
	private global::Gtk.DataBindings.DataHBox datahbox1;
	
	private global::Gtk.DataBindings.DataTitleLabel datatitlelabel1;
	
	private global::Gtk.DataBindings.DataAutoWidget dataautowidget1;
	
	private global::Gtk.DataBindings.DataAutoWidget dataautowidget2;
	
	private global::Gtk.DataBindings.DataHBox datahbox2;
	
	private global::Gtk.DataBindings.DataTitleLabel datatitlelabel2;
	
	private global::Gtk.DataBindings.DataAutoWidget dataautowidget3;
	
	private global::Gtk.DataBindings.DataAutoWidget dataautowidget4;
	
	private global::Gtk.EventBox eventbox1;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Label label1;

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
		this.datavbox1 = new global::Gtk.DataBindings.DataVBox ();
		this.datavbox1.Name = "datavbox1";
		this.datavbox1.Spacing = 6;
		this.datavbox1.InheritedDataSource = false;
		this.datavbox1.InheritedBoundaryDataSource = false;
		this.datavbox1.InheritedDataSource = false;
		this.datavbox1.InheritedBoundaryDataSource = false;
		// Container child datavbox1.Gtk.Box+BoxChild
		this.dataentry1 = new global::Gtk.DataBindings.DataEntry ();
		this.dataentry1.CanFocus = true;
		this.dataentry1.Name = "dataentry1";
		this.dataentry1.IsEditable = true;
		this.dataentry1.InvisibleChar = '•';
		this.dataentry1.InheritedDataSource = true;
		this.dataentry1.Mappings = "Name";
		this.dataentry1.InheritedBoundaryDataSource = false;
		this.dataentry1.InheritedDataSource = true;
		this.dataentry1.Mappings = "Name";
		this.dataentry1.InheritedBoundaryDataSource = false;
		this.dataentry1.Editable = false;
		this.datavbox1.Add (this.dataentry1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.datavbox1 [this.dataentry1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child datavbox1.Gtk.Box+BoxChild
		this.datalabel2 = new global::Gtk.DataBindings.DataLabel ();
		this.datalabel2.Name = "datalabel2";
		this.datalabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("datalabel2");
		this.datalabel2.InheritedDataSource = true;
		this.datalabel2.Mappings = "Percent";
		this.datalabel2.InheritedBoundaryDataSource = false;
		this.datalabel2.Important = false;
		this.datalabel2.InheritedDataSource = true;
		this.datalabel2.Mappings = "Percent";
		this.datalabel2.InheritedBoundaryDataSource = false;
		this.datavbox1.Add (this.datalabel2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.datavbox1 [this.datalabel2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child datavbox1.Gtk.Box+BoxChild
		this.datalabel1 = new global::Gtk.DataBindings.DataLabel ();
		this.datalabel1.Name = "datalabel1";
		this.datalabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("datalabel1");
		this.datalabel1.InheritedDataSource = true;
		this.datalabel1.Mappings = "Money";
		this.datalabel1.InheritedBoundaryDataSource = false;
		this.datalabel1.Important = false;
		this.datalabel1.InheritedDataSource = true;
		this.datalabel1.Mappings = "Money";
		this.datalabel1.InheritedBoundaryDataSource = false;
		this.datavbox1.Add (this.datalabel1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.datavbox1 [this.datalabel1]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox1.Add (this.datavbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datavbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.datahbox1 = new global::Gtk.DataBindings.DataHBox ();
		this.datahbox1.Name = "datahbox1";
		this.datahbox1.Spacing = 6;
		this.datahbox1.InheritedDataSource = false;
		this.datahbox1.InheritedBoundaryDataSource = false;
		this.datahbox1.InheritedDataSource = false;
		this.datahbox1.InheritedBoundaryDataSource = false;
		// Container child datahbox1.Gtk.Box+BoxChild
		this.datatitlelabel1 = new global::Gtk.DataBindings.DataTitleLabel ();
		this.datatitlelabel1.Name = "datatitlelabel1";
		this.datatitlelabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("datatitlelabel1");
		this.datatitlelabel1.InheritedDataSource = true;
		this.datatitlelabel1.Mappings = "Name";
		this.datatitlelabel1.InheritedBoundaryDataSource = false;
		this.datatitlelabel1.Important = false;
		this.datatitlelabel1.InheritedDataSource = true;
		this.datatitlelabel1.Mappings = "Name";
		this.datatitlelabel1.InheritedBoundaryDataSource = false;
		this.datahbox1.Add (this.datatitlelabel1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.datatitlelabel1]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child datahbox1.Gtk.Box+BoxChild
		this.dataautowidget1 = new global::Gtk.DataBindings.DataAutoWidget ();
		this.dataautowidget1.Name = "dataautowidget1";
		this.dataautowidget1.InheritedDataSource = true;
		this.dataautowidget1.InheritedBoundaryDataSource = false;
		this.dataautowidget1.Mappings = "Name";
		this.dataautowidget1.Editable = true;
		this.dataautowidget1.InheritedDataSource = true;
		this.dataautowidget1.InheritedBoundaryDataSource = false;
		this.datahbox1.Add (this.dataautowidget1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.dataautowidget1]));
		w6.Position = 1;
		// Container child datahbox1.Gtk.Box+BoxChild
		this.dataautowidget2 = new global::Gtk.DataBindings.DataAutoWidget ();
		this.dataautowidget2.Name = "dataautowidget2";
		this.dataautowidget2.InheritedDataSource = true;
		this.dataautowidget2.InheritedBoundaryDataSource = false;
		this.dataautowidget2.Mappings = "Name";
		this.dataautowidget2.Editable = false;
		this.dataautowidget2.InheritedDataSource = true;
		this.dataautowidget2.InheritedBoundaryDataSource = false;
		this.datahbox1.Add (this.dataautowidget2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.dataautowidget2]));
		w7.Position = 2;
		this.vbox1.Add (this.datahbox1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datahbox1]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.datahbox2 = new global::Gtk.DataBindings.DataHBox ();
		this.datahbox2.Name = "datahbox2";
		this.datahbox2.Spacing = 6;
		this.datahbox2.InheritedDataSource = false;
		this.datahbox2.InheritedBoundaryDataSource = false;
		this.datahbox2.InheritedDataSource = false;
		this.datahbox2.InheritedBoundaryDataSource = false;
		// Container child datahbox2.Gtk.Box+BoxChild
		this.datatitlelabel2 = new global::Gtk.DataBindings.DataTitleLabel ();
		this.datatitlelabel2.Name = "datatitlelabel2";
		this.datatitlelabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("datatitlelabel1");
		this.datatitlelabel2.InheritedDataSource = true;
		this.datatitlelabel2.Mappings = "Birth";
		this.datatitlelabel2.InheritedBoundaryDataSource = false;
		this.datatitlelabel2.Important = false;
		this.datatitlelabel2.InheritedDataSource = true;
		this.datatitlelabel2.Mappings = "Birth";
		this.datatitlelabel2.InheritedBoundaryDataSource = false;
		this.datahbox2.Add (this.datatitlelabel2);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.datahbox2 [this.datatitlelabel2]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child datahbox2.Gtk.Box+BoxChild
		this.dataautowidget3 = new global::Gtk.DataBindings.DataAutoWidget ();
		this.dataautowidget3.Name = "dataautowidget3";
		this.dataautowidget3.InheritedDataSource = true;
		this.dataautowidget3.InheritedBoundaryDataSource = false;
		this.dataautowidget3.Mappings = "Birth";
		this.dataautowidget3.Editable = true;
		this.dataautowidget3.InheritedDataSource = true;
		this.dataautowidget3.InheritedBoundaryDataSource = false;
		this.datahbox2.Add (this.dataautowidget3);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.datahbox2 [this.dataautowidget3]));
		w10.Position = 1;
		// Container child datahbox2.Gtk.Box+BoxChild
		this.dataautowidget4 = new global::Gtk.DataBindings.DataAutoWidget ();
		this.dataautowidget4.Name = "dataautowidget4";
		this.dataautowidget4.InheritedDataSource = true;
		this.dataautowidget4.InheritedBoundaryDataSource = false;
		this.dataautowidget4.Mappings = "Birth";
		this.dataautowidget4.Editable = false;
		this.dataautowidget4.InheritedDataSource = true;
		this.dataautowidget4.InheritedBoundaryDataSource = false;
		this.datahbox2.Add (this.dataautowidget4);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.datahbox2 [this.dataautowidget4]));
		w11.Position = 2;
		this.vbox1.Add (this.datahbox2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datahbox2]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.eventbox1 = new global::Gtk.EventBox ();
		this.eventbox1.Name = "eventbox1";
		// Container child eventbox1.Gtk.Container+ContainerChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
		this.eventbox1.Add (this.label2);
		this.vbox1.Add (this.eventbox1);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.eventbox1]));
		w14.Position = 3;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<span color=\"red\" background=\"#0000ff\">bla</span>");
		this.label1.UseMarkup = true;
		this.vbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
		w15.Position = 5;
		w15.Expand = false;
		w15.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 906;
		this.DefaultHeight = 211;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
