
// This file has been generated by the GUI designer. Do not modify.
namespace stopwatch
{
	public partial class StopWatchDialog
	{
		private global::Gtk.DataBindings.DataTable DataBox;
		private global::Gtk.DataBindings.DataEntry dataentry1;
		private global::Gtk.DataBindings.DataHBox datahbox1;
		private global::Gtk.DataBindings.DataSpinButton dataspinbutton1;
		private global::Gtk.Label label3;
		private global::Gtk.DataBindings.DataSpinButton dataspinbutton2;
		private global::Gtk.Label label4;
		private global::Gtk.DataBindings.DataSpinButton dataspinbutton3;
		private global::Gtk.Label label5;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget stopwatch.StopWatchDialog
			this.Name = "stopwatch.StopWatchDialog";
			this.Title = "Add StopWatch";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			// Internal child stopwatch.StopWatchDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.DataBox = new global::Gtk.DataBindings.DataTable (((uint)(2)), ((uint)(2)), false);
			this.DataBox.Name = "DataBox";
			this.DataBox.RowSpacing = ((uint)(6));
			this.DataBox.ColumnSpacing = ((uint)(8));
			this.DataBox.BorderWidth = ((uint)(8));
			this.DataBox.InheritedDataSource = false;
			this.DataBox.InheritedBoundaryDataSource = false;
			this.DataBox.InheritedDataSource = false;
			this.DataBox.InheritedBoundaryDataSource = false;
			// Container child DataBox.Gtk.Table+TableChild
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
			this.DataBox.Add (this.dataentry1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.DataBox [this.dataentry1]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child DataBox.Gtk.Table+TableChild
			this.datahbox1 = new global::Gtk.DataBindings.DataHBox ();
			this.datahbox1.Name = "datahbox1";
			this.datahbox1.Spacing = 6;
			this.datahbox1.InheritedDataSource = true;
			this.datahbox1.InheritedBoundaryDataSource = false;
			this.datahbox1.InheritedDataSource = true;
			this.datahbox1.InheritedBoundaryDataSource = false;
			// Container child datahbox1.Gtk.Box+BoxChild
			this.dataspinbutton1 = new global::Gtk.DataBindings.DataSpinButton (0, 100, 1);
			this.dataspinbutton1.CanFocus = true;
			this.dataspinbutton1.Name = "dataspinbutton1";
			this.dataspinbutton1.Adjustment.PageIncrement = 10;
			this.dataspinbutton1.ClimbRate = 1;
			this.dataspinbutton1.Numeric = true;
			this.dataspinbutton1.InheritedDataSource = true;
			this.dataspinbutton1.Mappings = "MaxHours";
			this.dataspinbutton1.InheritedBoundaryDataSource = false;
			this.dataspinbutton1.InheritedDataSource = true;
			this.dataspinbutton1.Mappings = "MaxHours";
			this.dataspinbutton1.InheritedBoundaryDataSource = false;
			this.datahbox1.Add (this.dataspinbutton1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.dataspinbutton1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child datahbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = "Hours";
			this.datahbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.label3]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child datahbox1.Gtk.Box+BoxChild
			this.dataspinbutton2 = new global::Gtk.DataBindings.DataSpinButton (0, 100, 1);
			this.dataspinbutton2.CanFocus = true;
			this.dataspinbutton2.Name = "dataspinbutton2";
			this.dataspinbutton2.Adjustment.PageIncrement = 10;
			this.dataspinbutton2.ClimbRate = 1;
			this.dataspinbutton2.Numeric = true;
			this.dataspinbutton2.InheritedDataSource = true;
			this.dataspinbutton2.Mappings = "MaxMinutes";
			this.dataspinbutton2.InheritedBoundaryDataSource = false;
			this.dataspinbutton2.InheritedDataSource = true;
			this.dataspinbutton2.Mappings = "MaxMinutes";
			this.dataspinbutton2.InheritedBoundaryDataSource = false;
			this.datahbox1.Add (this.dataspinbutton2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.dataspinbutton2]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child datahbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = "Minutes";
			this.datahbox1.Add (this.label4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.label4]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child datahbox1.Gtk.Box+BoxChild
			this.dataspinbutton3 = new global::Gtk.DataBindings.DataSpinButton (0, 100, 1);
			this.dataspinbutton3.CanFocus = true;
			this.dataspinbutton3.Name = "dataspinbutton3";
			this.dataspinbutton3.Adjustment.PageIncrement = 10;
			this.dataspinbutton3.ClimbRate = 1;
			this.dataspinbutton3.Numeric = true;
			this.dataspinbutton3.InheritedDataSource = true;
			this.dataspinbutton3.Mappings = "MaxSeconds";
			this.dataspinbutton3.InheritedBoundaryDataSource = false;
			this.dataspinbutton3.InheritedDataSource = true;
			this.dataspinbutton3.Mappings = "MaxSeconds";
			this.dataspinbutton3.InheritedBoundaryDataSource = false;
			this.datahbox1.Add (this.dataspinbutton3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.dataspinbutton3]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child datahbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = "Seconds";
			this.datahbox1.Add (this.label5);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.label5]));
			w8.Position = 5;
			w8.Expand = false;
			w8.Fill = false;
			this.DataBox.Add (this.datahbox1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.DataBox [this.datahbox1]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child DataBox.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = "Name";
			this.DataBox.Add (this.label1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.DataBox [this.label1]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child DataBox.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = "Max Time";
			this.DataBox.Add (this.label2);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.DataBox [this.label2]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.DataBox);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(w1 [this.DataBox]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Internal child stopwatch.StopWatchDialog.ActionArea
			global::Gtk.HButtonBox w13 = this.ActionArea;
			w13.Name = "dialog1_ActionArea";
			w13.Spacing = 6;
			w13.BorderWidth = ((uint)(5));
			w13.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w14 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w15 = new global::Gtk.HBox ();
			w15.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w16 = new global::Gtk.Image ();
			w16.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w15.Add (w16);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w18 = new global::Gtk.Label ();
			w18.LabelProp = "_Set timer";
			w18.UseUnderline = true;
			w15.Add (w18);
			w14.Add (w15);
			this.buttonOk.Add (w14);
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w13 [this.buttonOk]));
			w22.Expand = false;
			w22.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 467;
			this.DefaultHeight = 153;
			this.buttonOk.HasDefault = true;
			this.Show ();
			this.DestroyEvent += new global::Gtk.DestroyEventHandler (this.OnDestroyEvent);
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		}
	}
}
