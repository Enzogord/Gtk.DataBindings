// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.HBox hbox1;
    
    private Gtk.VBox vbox1;
    
    private Gtk.ScrolledWindow GtkScrolledWindow;
    
    private Gtk.DataBindings.DataTreeView datatreeview1;
    
    private Gtk.DataBindings.DateEntry dateentry2;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.hbox1 = new Gtk.HBox();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.GtkScrolledWindow = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow.Name = "GtkScrolledWindow";
        this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
        this.datatreeview1 = new Gtk.DataBindings.DataTreeView();
        this.datatreeview1.CanFocus = true;
        this.datatreeview1.Name = "datatreeview1";
        this.datatreeview1.CursorPointsEveryType = false;
        this.datatreeview1.InheritedDataSource = false;
        this.datatreeview1.InheritedBoundaryDataSource = false;
        this.datatreeview1.ColumnMappings = "{ColorClass}; Color[Color]<<cairocolor; Name[Name]; Date[Date]<>date; Time[Time]<<time; Ip[Ip]<<ip; Money[Money]<<currency";
        this.GtkScrolledWindow.Add(this.datatreeview1);
        this.vbox1.Add(this.GtkScrolledWindow);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
        w2.Position = 0;
        // Container child vbox1.Gtk.Box+BoxChild
        this.dateentry2 = new Gtk.DataBindings.DateEntry();
        this.dateentry2.Name = "dateentry2";
        this.dateentry2.HasDropDown = false;
        this.dateentry2.HasClearButton = false;
        this.dateentry2.HasCalculator = false;
        this.dateentry2.Editable = true;
        this.vbox1.Add(this.dateentry2);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.dateentry2]));
        w3.Position = 1;
        w3.Expand = false;
        w3.Fill = false;
        this.hbox1.Add(this.vbox1);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
        w4.Position = 0;
        w4.Expand = false;
        w4.Fill = false;
        this.Add(this.hbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 967;
        this.DefaultHeight = 348;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
    }
}
