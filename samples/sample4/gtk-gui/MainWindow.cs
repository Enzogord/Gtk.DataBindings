// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.ScrolledWindow GtkScrolledWindow;
    
    private Gtk.DataBindings.DataTreeView datatreeview1;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.GtkScrolledWindow = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow.Name = "GtkScrolledWindow";
        this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
        this.datatreeview1 = new Gtk.DataBindings.DataTreeView();
        this.datatreeview1.CanFocus = true;
        this.datatreeview1.Name = "datatreeview1";
        this.datatreeview1.HeadersClickable = true;
        this.datatreeview1.URIDragInSupport = false;
        this.datatreeview1.CursorPointsEveryType = false;
        this.datatreeview1.InheritedDataSource = false;
        this.datatreeview1.Mappings = "";
        this.datatreeview1.InheritedBoundaryDataSource = false;
        this.datatreeview1.ColumnMappings = "{sample4.PictureInfoClass} Preview[Preview]<<; Name[File Name]<<; Size[Size]<<";
        this.GtkScrolledWindow.Add(this.datatreeview1);
        this.Add(this.GtkScrolledWindow);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 400;
        this.DefaultHeight = 517;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
    }
}
