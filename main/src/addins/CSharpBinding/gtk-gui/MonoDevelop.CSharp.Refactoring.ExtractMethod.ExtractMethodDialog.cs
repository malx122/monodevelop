
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.CSharp.Refactoring.ExtractMethod
{
	public partial class ExtractMethodDialog
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.ComboBox comboboxModifiers;
		
		private global::Gtk.Entry entry;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label labelNewName;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeviewParameters;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Button buttonUp;
		
		private global::Gtk.Button buttonDown;
		
		private global::Gtk.CheckButton checkbuttonGenerateComment;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Image imageWarning;
		
		private global::Gtk.Label labelWarning;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonPreview;
		
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.CSharp.Refactoring.ExtractMethod.ExtractMethodDialog
			this.Name = "MonoDevelop.CSharp.Refactoring.ExtractMethod.ExtractMethodDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Extract Method");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(6));
			// Internal child MonoDevelop.CSharp.Refactoring.ExtractMethod.ExtractMethodDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxModifiers = global::Gtk.ComboBox.NewText ();
			this.comboboxModifiers.Name = "comboboxModifiers";
			this.table1.Add (this.comboboxModifiers);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxModifiers]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry = new global::Gtk.Entry ();
			this.entry.CanFocus = true;
			this.entry.Name = "entry";
			this.entry.IsEditable = true;
			this.entry.InvisibleChar = '●';
			this.table1.Add (this.entry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.entry]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Access modifier:");
			this.label1.UseUnderline = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelNewName = new global::Gtk.Label ();
			this.labelNewName.Name = "labelNewName";
			this.labelNewName.Xalign = 0F;
			this.labelNewName.LabelProp = global::Mono.Unix.Catalog.GetString ("_Method name:");
			this.labelNewName.UseUnderline = true;
			this.table1.Add (this.labelNewName);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.labelNewName]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("_Parameters:");
			this.label2.UseUnderline = true;
			this.vbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewParameters = new global::Gtk.TreeView ();
			this.treeviewParameters.CanFocus = true;
			this.treeviewParameters.Name = "treeviewParameters";
			this.GtkScrolledWindow.Add (this.treeviewParameters);
			this.hbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.GtkScrolledWindow]));
			w9.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonUp = new global::Gtk.Button ();
			this.buttonUp.CanFocus = true;
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.UseUnderline = true;
			this.buttonUp.Label = global::Mono.Unix.Catalog.GetString ("_Up");
			this.vbox3.Add (this.buttonUp);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.buttonUp]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonDown = new global::Gtk.Button ();
			this.buttonDown.CanFocus = true;
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.UseUnderline = true;
			this.buttonDown.Label = global::Mono.Unix.Catalog.GetString ("_Down");
			this.vbox3.Add (this.buttonDown);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.buttonDown]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.hbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w13.Position = 2;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkbuttonGenerateComment = new global::Gtk.CheckButton ();
			this.checkbuttonGenerateComment.CanFocus = true;
			this.checkbuttonGenerateComment.Name = "checkbuttonGenerateComment";
			this.checkbuttonGenerateComment.Label = global::Mono.Unix.Catalog.GetString ("_Generate method comment  ");
			this.checkbuttonGenerateComment.DrawIndicator = true;
			this.checkbuttonGenerateComment.UseUnderline = true;
			this.vbox2.Add (this.checkbuttonGenerateComment);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.checkbuttonGenerateComment]));
			w14.Position = 3;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.imageWarning = new global::Gtk.Image ();
			this.imageWarning.Name = "imageWarning";
			this.imageWarning.Pixbuf = global::Stetic.IconLoader.LoadIcon (this,"gtk-apply",global::Gtk.IconSize.Button);
			this.hbox3.Add (this.imageWarning);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.imageWarning]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelWarning = new global::Gtk.Label ();
			this.labelWarning.Name = "labelWarning";
			this.hbox3.Add (this.labelWarning);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.labelWarning]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w17.Position = 4;
			w17.Expand = false;
			w17.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w18.Position = 0;
			// Internal child MonoDevelop.CSharp.Refactoring.ExtractMethod.ExtractMethodDialog.ActionArea
			global::Gtk.HButtonBox w19 = this.ActionArea;
			w19.Name = "dialog1_ActionArea";
			w19.Spacing = 10;
			w19.BorderWidth = ((uint)(5));
			w19.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel,-6);
			global::Gtk.ButtonBox.ButtonBoxChild w20 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w19[this.buttonCancel]));
			w20.Expand = false;
			w20.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPreview = new global::Gtk.Button ();
			this.buttonPreview.CanFocus = true;
			this.buttonPreview.Name = "buttonPreview";
			this.buttonPreview.UseUnderline = true;
			this.buttonPreview.Label = global::Mono.Unix.Catalog.GetString ("_Preview");
			this.AddActionWidget (this.buttonPreview,0);
			global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w19[this.buttonPreview]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk,-5);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w19[this.buttonOk]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 461;
			this.DefaultHeight = 368;
			this.labelNewName.MnemonicWidget = this.entry;
			this.label2.MnemonicWidget = this.treeviewParameters;
			this.Show ();
		}
	}
}